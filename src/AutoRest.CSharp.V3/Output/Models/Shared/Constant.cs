﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using AutoRest.CSharp.V3.Generation.Types;


namespace AutoRest.CSharp.V3.Output.Models.Shared
{
    internal struct Constant
    {
        public Constant(object? value, CSharpType type)
        {
            Debug.Assert(value == null || value.GetType().Namespace?.StartsWith("System") == true);
            Value = value;
            Type = type;

            if (value == null)
            {
                if (!type.IsNullable)
                {
                    throw new InvalidOperationException("Null constant with non-nullable type");
                }
                return;
            }

            Type expectedType;
            if (type.FrameworkType != null)
            {
                expectedType = type.FrameworkType;
            }
            else
            {
                throw new InvalidOperationException("Unexpected type kind");
            }

            if (value.GetType() != expectedType)
            {
                throw new InvalidOperationException("Constant type mismatch");
            }
        }

        public object? Value { get; }
        public CSharpType Type { get; }
    }
}
