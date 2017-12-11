﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp.Helpers.ModifierHelpers;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Roslynator.CSharp
{
    internal static class Modifier
    {
        public static ClassDeclarationSyntax Insert(ClassDeclarationSyntax classDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return ClassDeclarationModifierHelper.Instance.InsertModifier(classDeclaration, modifier, comparer);
        }

        public static ClassDeclarationSyntax Insert(ClassDeclarationSyntax classDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return ClassDeclarationModifierHelper.Instance.InsertModifier(classDeclaration, modifierKind, comparer);
        }

        public static ConstructorDeclarationSyntax Insert(ConstructorDeclarationSyntax constructorDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return ConstructorDeclarationModifierHelper.Instance.InsertModifier(constructorDeclaration, modifier, comparer);
        }

        public static ConstructorDeclarationSyntax Insert(ConstructorDeclarationSyntax constructorDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return ConstructorDeclarationModifierHelper.Instance.InsertModifier(constructorDeclaration, modifierKind, comparer);
        }

        public static ConversionOperatorDeclarationSyntax Insert(ConversionOperatorDeclarationSyntax conversionOperatorDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return ConversionOperatorDeclarationModifierHelper.Instance.InsertModifier(conversionOperatorDeclaration, modifier, comparer);
        }

        public static ConversionOperatorDeclarationSyntax Insert(ConversionOperatorDeclarationSyntax conversionOperatorDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return ConversionOperatorDeclarationModifierHelper.Instance.InsertModifier(conversionOperatorDeclaration, modifierKind, comparer);
        }

        public static DelegateDeclarationSyntax Insert(DelegateDeclarationSyntax delegateDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return DelegateDeclarationModifierHelper.Instance.InsertModifier(delegateDeclaration, modifier, comparer);
        }

        public static DelegateDeclarationSyntax Insert(DelegateDeclarationSyntax delegateDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return DelegateDeclarationModifierHelper.Instance.InsertModifier(delegateDeclaration, modifierKind, comparer);
        }

        public static DestructorDeclarationSyntax Insert(DestructorDeclarationSyntax destructorDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return DestructorDeclarationModifierHelper.Instance.InsertModifier(destructorDeclaration, modifier, comparer);
        }

        public static DestructorDeclarationSyntax Insert(DestructorDeclarationSyntax destructorDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return DestructorDeclarationModifierHelper.Instance.InsertModifier(destructorDeclaration, modifierKind, comparer);
        }

        public static EnumDeclarationSyntax Insert(EnumDeclarationSyntax enumDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return EnumDeclarationModifierHelper.Instance.InsertModifier(enumDeclaration, modifier, comparer);
        }

        public static EnumDeclarationSyntax Insert(EnumDeclarationSyntax enumDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return EnumDeclarationModifierHelper.Instance.InsertModifier(enumDeclaration, modifierKind, comparer);
        }

        public static EventDeclarationSyntax Insert(EventDeclarationSyntax eventDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return EventDeclarationModifierHelper.Instance.InsertModifier(eventDeclaration, modifier, comparer);
        }

        public static EventDeclarationSyntax Insert(EventDeclarationSyntax eventDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return EventDeclarationModifierHelper.Instance.InsertModifier(eventDeclaration, modifierKind, comparer);
        }

        public static EventFieldDeclarationSyntax Insert(EventFieldDeclarationSyntax eventFieldDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return EventFieldDeclarationModifierHelper.Instance.InsertModifier(eventFieldDeclaration, modifier, comparer);
        }

        public static EventFieldDeclarationSyntax Insert(EventFieldDeclarationSyntax eventFieldDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return EventFieldDeclarationModifierHelper.Instance.InsertModifier(eventFieldDeclaration, modifierKind, comparer);
        }

        public static FieldDeclarationSyntax Insert(FieldDeclarationSyntax fieldDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return FieldDeclarationModifierHelper.Instance.InsertModifier(fieldDeclaration, modifier, comparer);
        }

        public static FieldDeclarationSyntax Insert(FieldDeclarationSyntax fieldDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return FieldDeclarationModifierHelper.Instance.InsertModifier(fieldDeclaration, modifierKind, comparer);
        }

        public static IndexerDeclarationSyntax Insert(IndexerDeclarationSyntax indexerDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return IndexerDeclarationModifierHelper.Instance.InsertModifier(indexerDeclaration, modifier, comparer);
        }

        public static IndexerDeclarationSyntax Insert(IndexerDeclarationSyntax indexerDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return IndexerDeclarationModifierHelper.Instance.InsertModifier(indexerDeclaration, modifierKind, comparer);
        }

        public static InterfaceDeclarationSyntax Insert(InterfaceDeclarationSyntax interfaceDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return InterfaceDeclarationModifierHelper.Instance.InsertModifier(interfaceDeclaration, modifier, comparer);
        }

        public static InterfaceDeclarationSyntax Insert(InterfaceDeclarationSyntax interfaceDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return InterfaceDeclarationModifierHelper.Instance.InsertModifier(interfaceDeclaration, modifierKind, comparer);
        }

        public static MethodDeclarationSyntax Insert(MethodDeclarationSyntax methodDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return MethodDeclarationModifierHelper.Instance.InsertModifier(methodDeclaration, modifier, comparer);
        }

        public static MethodDeclarationSyntax Insert(MethodDeclarationSyntax methodDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return MethodDeclarationModifierHelper.Instance.InsertModifier(methodDeclaration, modifierKind, comparer);
        }

        public static OperatorDeclarationSyntax Insert(OperatorDeclarationSyntax operatorDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return OperatorDeclarationModifierHelper.Instance.InsertModifier(operatorDeclaration, modifier, comparer);
        }

        public static OperatorDeclarationSyntax Insert(OperatorDeclarationSyntax operatorDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return OperatorDeclarationModifierHelper.Instance.InsertModifier(operatorDeclaration, modifierKind, comparer);
        }

        public static PropertyDeclarationSyntax Insert(PropertyDeclarationSyntax propertyDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return PropertyDeclarationModifierHelper.Instance.InsertModifier(propertyDeclaration, modifier, comparer);
        }

        public static PropertyDeclarationSyntax Insert(PropertyDeclarationSyntax propertyDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return PropertyDeclarationModifierHelper.Instance.InsertModifier(propertyDeclaration, modifierKind, comparer);
        }

        public static StructDeclarationSyntax Insert(StructDeclarationSyntax structDeclaration, SyntaxToken modifier, IModifierComparer comparer)
        {
            return StructDeclarationModifierHelper.Instance.InsertModifier(structDeclaration, modifier, comparer);
        }

        public static StructDeclarationSyntax Insert(StructDeclarationSyntax structDeclaration, SyntaxKind modifierKind, IModifierComparer comparer)
        {
            return StructDeclarationModifierHelper.Instance.InsertModifier(structDeclaration, modifierKind, comparer);
        }

        public static TNode Insert<TNode>(TNode node, SyntaxKind modifierKind, IModifierComparer comparer = null) where TNode : SyntaxNode
        {
            return Insert(node, Token(modifierKind), comparer);
        }

        public static TNode Insert<TNode>(TNode node, SyntaxToken modifier, IModifierComparer comparer = null) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)Insert((ClassDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)Insert((ConstructorDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)Insert((ConversionOperatorDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)Insert((DelegateDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)Insert((DestructorDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)Insert((EnumDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)Insert((EventDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)Insert((EventFieldDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)Insert((FieldDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)Insert((IndexerDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)Insert((InterfaceDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)Insert((MethodDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)Insert((OperatorDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)Insert((PropertyDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)Insert((StructDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.InsertModifier((AccessorDeclarationSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.InsertModifier((LocalDeclarationStatementSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.InsertModifier((LocalFunctionStatementSyntax)(SyntaxNode)node, modifier, comparer);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.InsertModifier((ParameterSyntax)(SyntaxNode)node, modifier, comparer);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static TNode Remove<TNode>(TNode node, SyntaxKind modifierKind) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)ClassDeclarationModifierHelper.Instance.RemoveModifier((ClassDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)ConstructorDeclarationModifierHelper.Instance.RemoveModifier((ConstructorDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)ConversionOperatorDeclarationModifierHelper.Instance.RemoveModifier((ConversionOperatorDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)DelegateDeclarationModifierHelper.Instance.RemoveModifier((DelegateDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)DestructorDeclarationModifierHelper.Instance.RemoveModifier((DestructorDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)EnumDeclarationModifierHelper.Instance.RemoveModifier((EnumDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)EventDeclarationModifierHelper.Instance.RemoveModifier((EventDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)EventFieldDeclarationModifierHelper.Instance.RemoveModifier((EventFieldDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)FieldDeclarationModifierHelper.Instance.RemoveModifier((FieldDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)IndexerDeclarationModifierHelper.Instance.RemoveModifier((IndexerDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)InterfaceDeclarationModifierHelper.Instance.RemoveModifier((InterfaceDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)MethodDeclarationModifierHelper.Instance.RemoveModifier((MethodDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)OperatorDeclarationModifierHelper.Instance.RemoveModifier((OperatorDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)PropertyDeclarationModifierHelper.Instance.RemoveModifier((PropertyDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)StructDeclarationModifierHelper.Instance.RemoveModifier((StructDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.RemoveModifier((AccessorDeclarationSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.RemoveModifier((LocalDeclarationStatementSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.RemoveModifier((LocalFunctionStatementSyntax)(SyntaxNode)node, modifierKind);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.RemoveModifier((ParameterSyntax)(SyntaxNode)node, modifierKind);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static TNode Remove<TNode>(TNode node, SyntaxToken modifier) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)ClassDeclarationModifierHelper.Instance.RemoveModifier((ClassDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)ConstructorDeclarationModifierHelper.Instance.RemoveModifier((ConstructorDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)ConversionOperatorDeclarationModifierHelper.Instance.RemoveModifier((ConversionOperatorDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)DelegateDeclarationModifierHelper.Instance.RemoveModifier((DelegateDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)DestructorDeclarationModifierHelper.Instance.RemoveModifier((DestructorDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)EnumDeclarationModifierHelper.Instance.RemoveModifier((EnumDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)EventDeclarationModifierHelper.Instance.RemoveModifier((EventDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)EventFieldDeclarationModifierHelper.Instance.RemoveModifier((EventFieldDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)FieldDeclarationModifierHelper.Instance.RemoveModifier((FieldDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)IndexerDeclarationModifierHelper.Instance.RemoveModifier((IndexerDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)InterfaceDeclarationModifierHelper.Instance.RemoveModifier((InterfaceDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)MethodDeclarationModifierHelper.Instance.RemoveModifier((MethodDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)OperatorDeclarationModifierHelper.Instance.RemoveModifier((OperatorDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)PropertyDeclarationModifierHelper.Instance.RemoveModifier((PropertyDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)StructDeclarationModifierHelper.Instance.RemoveModifier((StructDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.RemoveModifier((AccessorDeclarationSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.RemoveModifier((LocalDeclarationStatementSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.RemoveModifier((LocalFunctionStatementSyntax)(SyntaxNode)node, modifier);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.RemoveModifier((ParameterSyntax)(SyntaxNode)node, modifier);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static TNode RemoveAt<TNode>(TNode node, int index) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)ClassDeclarationModifierHelper.Instance.RemoveModifierAt((ClassDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)ConstructorDeclarationModifierHelper.Instance.RemoveModifierAt((ConstructorDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)ConversionOperatorDeclarationModifierHelper.Instance.RemoveModifierAt((ConversionOperatorDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)DelegateDeclarationModifierHelper.Instance.RemoveModifierAt((DelegateDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)DestructorDeclarationModifierHelper.Instance.RemoveModifierAt((DestructorDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)EnumDeclarationModifierHelper.Instance.RemoveModifierAt((EnumDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)EventDeclarationModifierHelper.Instance.RemoveModifierAt((EventDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)EventFieldDeclarationModifierHelper.Instance.RemoveModifierAt((EventFieldDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)FieldDeclarationModifierHelper.Instance.RemoveModifierAt((FieldDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)IndexerDeclarationModifierHelper.Instance.RemoveModifierAt((IndexerDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)InterfaceDeclarationModifierHelper.Instance.RemoveModifierAt((InterfaceDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)MethodDeclarationModifierHelper.Instance.RemoveModifierAt((MethodDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)OperatorDeclarationModifierHelper.Instance.RemoveModifierAt((OperatorDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)PropertyDeclarationModifierHelper.Instance.RemoveModifierAt((PropertyDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)StructDeclarationModifierHelper.Instance.RemoveModifierAt((StructDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.RemoveModifierAt((AccessorDeclarationSyntax)(SyntaxNode)node, index);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.RemoveModifierAt((LocalDeclarationStatementSyntax)(SyntaxNode)node, index);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.RemoveModifierAt((LocalFunctionStatementSyntax)(SyntaxNode)node, index);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.RemoveModifierAt((ParameterSyntax)(SyntaxNode)node, index);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static TNode RemoveAccess<TNode>(TNode node) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)ClassDeclarationModifierHelper.Instance.RemoveAccessModifiers((ClassDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)ConstructorDeclarationModifierHelper.Instance.RemoveAccessModifiers((ConstructorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)ConversionOperatorDeclarationModifierHelper.Instance.RemoveAccessModifiers((ConversionOperatorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)DelegateDeclarationModifierHelper.Instance.RemoveAccessModifiers((DelegateDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)DestructorDeclarationModifierHelper.Instance.RemoveAccessModifiers((DestructorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)EnumDeclarationModifierHelper.Instance.RemoveAccessModifiers((EnumDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)EventDeclarationModifierHelper.Instance.RemoveAccessModifiers((EventDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)EventFieldDeclarationModifierHelper.Instance.RemoveAccessModifiers((EventFieldDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)FieldDeclarationModifierHelper.Instance.RemoveAccessModifiers((FieldDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)IndexerDeclarationModifierHelper.Instance.RemoveAccessModifiers((IndexerDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)InterfaceDeclarationModifierHelper.Instance.RemoveAccessModifiers((InterfaceDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)MethodDeclarationModifierHelper.Instance.RemoveAccessModifiers((MethodDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)OperatorDeclarationModifierHelper.Instance.RemoveAccessModifiers((OperatorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)PropertyDeclarationModifierHelper.Instance.RemoveAccessModifiers((PropertyDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)StructDeclarationModifierHelper.Instance.RemoveAccessModifiers((StructDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.RemoveAccessModifiers((AccessorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.RemoveAccessModifiers((LocalDeclarationStatementSyntax)(SyntaxNode)node);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.RemoveAccessModifiers((LocalFunctionStatementSyntax)(SyntaxNode)node);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.RemoveAccessModifiers((ParameterSyntax)(SyntaxNode)node);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static TNode RemoveAll<TNode>(TNode node) where TNode : SyntaxNode
        {
            switch (node.Kind())
            {
                case SyntaxKind.ClassDeclaration:
                    return (TNode)(SyntaxNode)ClassDeclarationModifierHelper.Instance.RemoveModifiers((ClassDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.ConstructorDeclaration:
                    return (TNode)(SyntaxNode)ConstructorDeclarationModifierHelper.Instance.RemoveModifiers((ConstructorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.ConversionOperatorDeclaration:
                    return (TNode)(SyntaxNode)ConversionOperatorDeclarationModifierHelper.Instance.RemoveModifiers((ConversionOperatorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.DelegateDeclaration:
                    return (TNode)(SyntaxNode)DelegateDeclarationModifierHelper.Instance.RemoveModifiers((DelegateDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.DestructorDeclaration:
                    return (TNode)(SyntaxNode)DestructorDeclarationModifierHelper.Instance.RemoveModifiers((DestructorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EnumDeclaration:
                    return (TNode)(SyntaxNode)EnumDeclarationModifierHelper.Instance.RemoveModifiers((EnumDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EventDeclaration:
                    return (TNode)(SyntaxNode)EventDeclarationModifierHelper.Instance.RemoveModifiers((EventDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.EventFieldDeclaration:
                    return (TNode)(SyntaxNode)EventFieldDeclarationModifierHelper.Instance.RemoveModifiers((EventFieldDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.FieldDeclaration:
                    return (TNode)(SyntaxNode)FieldDeclarationModifierHelper.Instance.RemoveModifiers((FieldDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.IndexerDeclaration:
                    return (TNode)(SyntaxNode)IndexerDeclarationModifierHelper.Instance.RemoveModifiers((IndexerDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.InterfaceDeclaration:
                    return (TNode)(SyntaxNode)InterfaceDeclarationModifierHelper.Instance.RemoveModifiers((InterfaceDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.MethodDeclaration:
                    return (TNode)(SyntaxNode)MethodDeclarationModifierHelper.Instance.RemoveModifiers((MethodDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.OperatorDeclaration:
                    return (TNode)(SyntaxNode)OperatorDeclarationModifierHelper.Instance.RemoveModifiers((OperatorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.PropertyDeclaration:
                    return (TNode)(SyntaxNode)PropertyDeclarationModifierHelper.Instance.RemoveModifiers((PropertyDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.StructDeclaration:
                    return (TNode)(SyntaxNode)StructDeclarationModifierHelper.Instance.RemoveModifiers((StructDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                    return (TNode)(SyntaxNode)AccessorDeclarationModifierHelper.Instance.RemoveModifiers((AccessorDeclarationSyntax)(SyntaxNode)node);
                case SyntaxKind.LocalDeclarationStatement:
                    return (TNode)(SyntaxNode)LocalDeclarationStatementModifierHelper.Instance.RemoveModifiers((LocalDeclarationStatementSyntax)(SyntaxNode)node);
                case SyntaxKind.LocalFunctionStatement:
                    return (TNode)(SyntaxNode)LocalFunctionStatementModifierHelper.Instance.RemoveModifiers((LocalFunctionStatementSyntax)(SyntaxNode)node);
                case SyntaxKind.Parameter:
                    return (TNode)(SyntaxNode)ParameterModifierHelper.Instance.RemoveModifiers((ParameterSyntax)(SyntaxNode)node);
            }

            Debug.Assert(node.IsKind(SyntaxKind.IncompleteMember), node.ToString());

            return node;
        }

        public static string GetName(SyntaxKind modifierKind)
        {
            switch (modifierKind)
            {
                case SyntaxKind.NewKeyword:
                    return "new";
                case SyntaxKind.PublicKeyword:
                    return "public";
                case SyntaxKind.ProtectedKeyword:
                    return "protected";
                case SyntaxKind.InternalKeyword:
                    return "internal";
                case SyntaxKind.PrivateKeyword:
                    return "private";
                case SyntaxKind.ConstKeyword:
                    return "const";
                case SyntaxKind.StaticKeyword:
                    return "static";
                case SyntaxKind.VirtualKeyword:
                    return "virtual";
                case SyntaxKind.SealedKeyword:
                    return "sealed";
                case SyntaxKind.OverrideKeyword:
                    return "override";
                case SyntaxKind.AbstractKeyword:
                    return "abstract";
                case SyntaxKind.ReadOnlyKeyword:
                    return "readonly";
                case SyntaxKind.ExternKeyword:
                    return "extern";
                case SyntaxKind.UnsafeKeyword:
                    return "unsafe";
                case SyntaxKind.VolatileKeyword:
                    return "volatile";
                case SyntaxKind.AsyncKeyword:
                    return "async";
                case SyntaxKind.PartialKeyword:
                    return "partial";
                case SyntaxKind.ThisKeyword:
                    return "this";
                case SyntaxKind.ParamsKeyword:
                    return "params";
                case SyntaxKind.InKeyword:
                    return "in";
                case SyntaxKind.OutKeyword:
                    return "out";
                case SyntaxKind.RefKeyword:
                    return "ref";
                default:
                    {
                        Debug.Fail(modifierKind.ToString());
                        return null;
                    }
            }
        }
    }
}
