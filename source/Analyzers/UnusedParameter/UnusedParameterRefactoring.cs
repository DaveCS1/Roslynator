﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.Syntax;

namespace Roslynator.CSharp.Analyzers.UnusedParameter
{
    internal static class UnusedParameterRefactoring
    {
        public static void AnalyzeConstructorDeclaration(SyntaxNodeAnalysisContext context)
        {
            var constructorDeclaration = (ConstructorDeclarationSyntax)context.Node;

            if (constructorDeclaration.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(constructorDeclaration);

            if (!parametersInfo.Success)
                return;

            if (ContainsOnlyThrowNewException(parametersInfo.Body, context.SemanticModel, context.CancellationToken))
                return;

            Analyze(context, parametersInfo);
        }

        public static void AnalyzeMethodDeclaration(SyntaxNodeAnalysisContext context)
        {
            var methodDeclaration = (MethodDeclarationSyntax)context.Node;

            if (methodDeclaration.ContainsDiagnostics)
                return;

            if (methodDeclaration.IsParentKind(SyntaxKind.InterfaceDeclaration))
                return;

            if (methodDeclaration.Modifiers.ContainsAny(SyntaxKind.AbstractKeyword, SyntaxKind.VirtualKeyword, SyntaxKind.OverrideKeyword))
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(methodDeclaration);

            if (!parametersInfo.Success)
                return;

            if (ContainsOnlyThrowNewException(parametersInfo.Body, context.SemanticModel, context.CancellationToken))
                return;

            IMethodSymbol methodSymbol = context.SemanticModel.GetDeclaredSymbol(methodDeclaration, context.CancellationToken);

            if (methodSymbol?.IsEventHandler(context.SemanticModel) != false)
                return;

            if (!methodSymbol.ExplicitInterfaceImplementations.IsDefaultOrEmpty)
                return;

            if (methodSymbol.ImplementsInterfaceMember())
                return;

            ImmutableArray<SyntaxNode> unusedNodes = FindUnusedNodes(context, parametersInfo);

            if (!unusedNodes.Any())
                return;

            if (IsReferencedAsMethodGroup(context, methodDeclaration))
                return;

            foreach (SyntaxNode node in unusedNodes)
                ReportDiagnostic(context, node);
        }

        public static void AnalyzeOperatorDeclaration(SyntaxNodeAnalysisContext context)
        {
            var operatorDeclaration = (OperatorDeclarationSyntax)context.Node;

            if (operatorDeclaration.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(operatorDeclaration);

            if (!parametersInfo.Success)
                return;

            if (ContainsOnlyThrowNewException(parametersInfo.Body, context.SemanticModel, context.CancellationToken))
                return;

            Analyze(context, parametersInfo);
        }

        public static void AnalyzeConversionOperatorDeclaration(SyntaxNodeAnalysisContext context)
        {
            var conversionOperatorDeclaration = (ConversionOperatorDeclarationSyntax)context.Node;

            if (conversionOperatorDeclaration.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(conversionOperatorDeclaration);

            if (!parametersInfo.Success)
                return;

            if (ContainsOnlyThrowNewException(parametersInfo.Body, context.SemanticModel, context.CancellationToken))
                return;

            Analyze(context, parametersInfo);
        }

        public static void AnalyzeIndexerDeclaration(SyntaxNodeAnalysisContext context)
        {
            var indexerDeclaration = (IndexerDeclarationSyntax)context.Node;

            if (indexerDeclaration.ContainsDiagnostics)
                return;

            if (indexerDeclaration.IsParentKind(SyntaxKind.InterfaceDeclaration))
                return;

            if (indexerDeclaration.Modifiers.ContainsAny(SyntaxKind.AbstractKeyword, SyntaxKind.VirtualKeyword, SyntaxKind.OverrideKeyword))
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(indexerDeclaration);

            if (!parametersInfo.Success)
                return;

            if (ContainsOnlyThrowNewException(parametersInfo.Body, context.SemanticModel, context.CancellationToken))
                return;

            IPropertySymbol propertySymbol = context.SemanticModel.GetDeclaredSymbol(indexerDeclaration, context.CancellationToken);

            if (propertySymbol?.ExplicitInterfaceImplementations.IsDefaultOrEmpty != true)
                return;

            if (propertySymbol.ImplementsInterfaceMember())
                return;

            Analyze(context, parametersInfo, isIndexer: true);
        }

        public static void AnalyzeLocalFunctionStatement(SyntaxNodeAnalysisContext context)
        {
            var localFunctionStatement = (LocalFunctionStatementSyntax)context.Node;

            if (localFunctionStatement.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(localFunctionStatement);

            if (!parametersInfo.Success)
                return;

            Analyze(context, parametersInfo);
        }

        public static void AnalyzeSimpleLambdaExpression(SyntaxNodeAnalysisContext context)
        {
            var lambda = (SimpleLambdaExpressionSyntax)context.Node;

            if (lambda.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(lambda);

            if (!parametersInfo.Success)
                return;

            Analyze(context, parametersInfo);
        }

        public static void AnalyzeParenthesizedLambdaExpression(SyntaxNodeAnalysisContext context)
        {
            var lambda = (ParenthesizedLambdaExpressionSyntax)context.Node;

            if (lambda.ContainsDiagnostics)
                return;

            ParametersInfo parametersInfo = ParametersInfo.Create(lambda);

            if (!parametersInfo.Success)
                return;

            Analyze(context, parametersInfo);
        }

        private static void Analyze(SyntaxNodeAnalysisContext context, ParametersInfo parametersInfo, bool isIndexer = false)
        {
            foreach (SyntaxNode node in FindUnusedNodes(context, parametersInfo, isIndexer))
                ReportDiagnostic(context, node);
        }

        private static ImmutableArray<SyntaxNode> FindUnusedNodes(SyntaxNodeAnalysisContext context, ParametersInfo parametersInfo, bool isIndexer = false)
        {
            UnusedSyntaxWalker walker = UnusedSyntaxWalkerCache.Acquire(context.SemanticModel, context.CancellationToken, isIndexer);

            if (parametersInfo.Parameter != null)
            {
                walker.AddParameter(parametersInfo.Parameter);
            }
            else
            {
                foreach (ParameterSyntax parameter in parametersInfo.Parameters)
                    walker.AddParameter(parameter);
            }

            foreach (TypeParameterSyntax typeParameter in parametersInfo.TypeParameters)
                walker.AddTypeParameter(typeParameter);

            walker.Visit(parametersInfo.Node);

            return UnusedSyntaxWalkerCache.GetNodesAndRelease(walker);
        }

        private static void ReportDiagnostic(SyntaxNodeAnalysisContext context, SyntaxNode node)
        {
            if (node is ParameterSyntax parameter)
            {
                if (parameter.IsThis())
                {
                    context.ReportDiagnostic(DiagnosticDescriptors.UnusedThisParameter, parameter, parameter.Identifier.ValueText);
                }
                else
                {
                    context.ReportDiagnostic(DiagnosticDescriptors.UnusedParameter, parameter, parameter.Identifier.ValueText);
                }
            }
            else if (node is TypeParameterSyntax typeParameter)
            {
                context.ReportDiagnostic(DiagnosticDescriptors.UnusedTypeParameter, typeParameter, typeParameter.Identifier.ValueText);
            }
            else
            {
                Debug.Fail(node.ToString());
            }
        }

        //TODO: UnusedMemberWalker
        private static bool IsReferencedAsMethodGroup(SyntaxNodeAnalysisContext context, MethodDeclarationSyntax methodDeclaration)
        {
            ISymbol methodSymbol = context.SemanticModel.GetDeclaredSymbol(methodDeclaration, context.CancellationToken);

            string methodName = methodSymbol.Name;

            foreach (SyntaxReference syntaxReference in methodSymbol.ContainingType.DeclaringSyntaxReferences)
            {
                SyntaxNode typeDeclaration = syntaxReference.GetSyntax(context.CancellationToken);

                SemanticModel semanticModel = null;

                foreach (SyntaxNode node in typeDeclaration.DescendantNodes())
                {
                    if (node.IsKind(SyntaxKind.IdentifierName))
                    {
                        var identifierName = (IdentifierNameSyntax)node;

                        if (string.Equals(methodName, identifierName.Identifier.ValueText, StringComparison.Ordinal)
                            && !IsInvoked(identifierName))
                        {
                            if (semanticModel == null)
                            {
                                semanticModel = (context.SemanticModel.SyntaxTree == typeDeclaration.SyntaxTree)
                                    ? context.SemanticModel
                                    : context.Compilation.GetSemanticModel(typeDeclaration.SyntaxTree);
                            }

                            if (methodSymbol.Equals(semanticModel.GetSymbol(identifierName, context.CancellationToken)))
                                return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool IsInvoked(IdentifierNameSyntax identifierName)
        {
            SyntaxNode parent = identifierName.Parent;

            switch (parent.Kind())
            {
                case SyntaxKind.InvocationExpression:
                    {
                        return true;
                    }
                case SyntaxKind.SimpleMemberAccessExpression:
                case SyntaxKind.MemberBindingExpression:
                    {
                        if (parent.IsParentKind(SyntaxKind.InvocationExpression))
                            return true;

                        break;
                    }
            }

            return false;
        }

        private static bool ContainsOnlyThrowNewException(
            CSharpSyntaxNode node,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            switch (node?.Kind())
            {
                case SyntaxKind.Block:
                    return ContainsOnlyThrowNewException((BlockSyntax)node, semanticModel, cancellationToken);
                case SyntaxKind.ArrowExpressionClause:
                    return ContainsOnlyThrowNewException((ArrowExpressionClauseSyntax)node, semanticModel, cancellationToken);
                case SyntaxKind.AccessorList:
                    {
                        return ((AccessorListSyntax)node)
                            .Accessors
                            .All(f => ContainsOnlyThrowNewException(f.BodyOrExpressionBody(), semanticModel, cancellationToken)) == true;

                    }
            }

            return false;
        }

        private static bool ContainsOnlyThrowNewException(
            BlockSyntax body,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            StatementSyntax statement = body?.Statements.SingleOrDefault(shouldThrow: false);

            if (statement?.IsKind(SyntaxKind.ThrowStatement) == true)
            {
                var throwStatement = (ThrowStatementSyntax)statement;

                return IsThrowNewException(throwStatement.Expression, semanticModel, cancellationToken);
            }

            return false;
        }

        private static bool ContainsOnlyThrowNewException(
            ArrowExpressionClauseSyntax expressionBody,
            SemanticModel semanticModel,
            CancellationToken cancellationToken)
        {
            ExpressionSyntax expression = expressionBody?.Expression;

            if (expression?.IsKind(SyntaxKind.ThrowExpression) == true)
            {
                var throwExpression = (ThrowExpressionSyntax)expression;

                return IsThrowNewException(throwExpression.Expression, semanticModel, cancellationToken);
            }

            return false;
        }

        private static bool IsThrowNewException(ExpressionSyntax expression, SemanticModel semanticModel, CancellationToken cancellationToken)
        {
            if (expression?.IsKind(SyntaxKind.ObjectCreationExpression) == true)
            {
                var objectCreation = (ObjectCreationExpressionSyntax)expression;

                ITypeSymbol typeSymbol = semanticModel.GetTypeSymbol(objectCreation, cancellationToken);

                if (typeSymbol != null)
                {
                    if (typeSymbol.Equals(semanticModel.GetTypeByMetadataName(MetadataNames.System_NotImplementedException))
                        || typeSymbol.Equals(semanticModel.GetTypeByMetadataName(MetadataNames.System_NotSupportedException)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static Task<Document> RefactorAsync(
            Document document,
            TypeParameterSyntax typeParameter,
            CancellationToken cancellationToken)
        {
            SyntaxNode node = typeParameter;

            var typeParameterList = (TypeParameterListSyntax)typeParameter.Parent;

            if (typeParameterList.Parameters.Count == 1)
                node = typeParameterList;

            SyntaxRemoveOptions options = RemoveHelper.DefaultRemoveOptions;

            if (node.GetLeadingTrivia().All(f => f.IsWhitespaceTrivia()))
                options &= ~SyntaxRemoveOptions.KeepLeadingTrivia;

            if (node.GetTrailingTrivia().All(f => f.IsWhitespaceTrivia()))
                options &= ~SyntaxRemoveOptions.KeepTrailingTrivia;

            return document.RemoveNodeAsync(node, options, cancellationToken);
        }
    }
}
