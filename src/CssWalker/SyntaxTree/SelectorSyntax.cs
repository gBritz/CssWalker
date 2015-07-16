﻿using System;
using System.Collections.Generic;

namespace CssWalker.SyntaxTree
{
    public class SelectorSyntax
    {
        public SelectorSyntax()
        {
            Properties = new List<PropertySyntax>();
            Comments = new List<CommentarySyntax>();
        }

        public String Selector { get; set; }

        public Position StartAt { get; set; }

        public Position EndAt { get; set; }

        public IList<PropertySyntax> Properties { get; private set; }

        public IList<CommentarySyntax> Comments { get; private set; }
    }
}