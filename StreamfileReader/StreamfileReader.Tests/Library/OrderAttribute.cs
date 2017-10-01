﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamfileReader.Tests.Library {
    /// <summary>
    /// Used by CustomOrderer
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class OrderAttribute : Attribute {
        public int I { get; }

        public OrderAttribute(int i) {
            I = i;
        }
    }
}
