﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.Markdown
{
    public class TableRow : MContainer
    {
        public TableRow()
        {
        }

        public TableRow(object content)
            : base(content)
        {
        }

        public TableRow(params object[] content)
            : base(content)
        {
        }

        public TableRow(TableRow other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.TableRow;

        internal override bool AllowStringConcatenation => false;

        public override MarkdownBuilder AppendTo(MarkdownBuilder builder)
        {
            return builder.AppendTableRow(this);
        }

        public override string ToString()
        {
            return ToString(MarkdownFormat.DefaultWithTableOuterDelimiter);
        }

        internal override MElement Clone()
        {
            return new TableRow(this);
        }
    }
}
