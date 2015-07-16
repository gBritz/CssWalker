﻿using System;

namespace CssWalker.SyntaxTree
{
    public class PropertySyntax : ISyntax
    {
        public String Name { get; set; }

        public String Value { get; set; }

        public String Content
        {
            get { return Name + ":" + Value; }
        }

        public Position StartAt { get; set; }

        public Position EndAt { get; set; }
    }
}