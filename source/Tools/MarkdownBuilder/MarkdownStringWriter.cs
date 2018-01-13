﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Pihrtsoft.Markdown.Linq;

namespace Pihrtsoft.Markdown
{
    internal class MarkdownStringWriter : MarkdownWriter
    {
        private bool _isOpen;
        private readonly IFormatProvider _formatProvider;

        public MarkdownStringWriter(IFormatProvider formatProvider, StringBuilder stringBuilder = null, MarkdownWriterSettings settings = null)
            : base(settings)
        {
            _formatProvider = formatProvider ?? throw new ArgumentNullException(nameof(formatProvider));
            StringBuilder = stringBuilder ?? new StringBuilder();
            _isOpen = true;
        }

        public StringBuilder StringBuilder { get; }

        protected internal override int Length
        {
            get { return StringBuilder.Length; }
            set { StringBuilder.Length = value; }
        }

        protected override void WriteCore(string value)
        {
            ThrowIfClosed();

            StringBuilder.Append(value);
        }

        protected override void WriteCore(string value, int startIndex, int count)
        {
            ThrowIfClosed();

            StringBuilder.Append(value, startIndex, count);
        }

        protected override void WriteCore(char value)
        {
            ThrowIfClosed();

            StringBuilder.Append(value);
        }

        private void ThrowIfClosed()
        {
            if (!_isOpen)
                throw new ObjectDisposedException(null, "Cannot write to a closed TextWriter.");
        }

        public override void Close()
        {
            _isOpen = false;
        }

        internal override void Reset()
        {
            StringBuilder.Clear();
            base.Reset();
        }

        protected override void WriteCore(int value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(uint value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(long value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(ulong value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(float value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(double value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override void WriteCore(decimal value)
        {
            StringBuilder.Append(value.ToString(_formatProvider));
        }

        protected override List<TableColumnInfo> MeasureTable(IEnumerable<MElement> rows)
        {
            throw new InvalidOperationException();
        }
    }
}