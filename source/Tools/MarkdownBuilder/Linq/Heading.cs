﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace Pihrtsoft.Markdown.Linq
{
    [DebuggerDisplay("{Kind} {Level} {GetString(),nq}")]
    public class Heading : MContainer
    {
        private int _level;

        public Heading(int level)
        {
            Level = level;
        }

        public Heading(int level, object content)
            : base(content)
        {
            Level = level;
        }

        public Heading(int level, params object[] content)
            : base(content)
        {
            Level = level;
        }

        public Heading(Heading other)
            : base(other)
        {
            Level = other.Level;
        }

        public int Level
        {
            get { return _level; }
            set
            {
                Error.ThrowOnInvalidHeadingLevel(value);
                _level = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.Heading;

        public override MarkdownWriter WriteTo(MarkdownWriter writer)
        {
            return writer.WriteHeading(Level, TextOrElements());
        }

        internal override MElement Clone()
        {
            return new Heading(this);
        }
    }
}
