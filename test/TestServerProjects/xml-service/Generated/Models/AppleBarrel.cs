// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace xml_service.Models
{
    /// <summary> A barrel of apples. </summary>
    public partial class AppleBarrel
    {
        /// <summary> Initializes a new instance of AppleBarrel. </summary>
        public AppleBarrel()
        {
        }

        /// <summary> Initializes a new instance of AppleBarrel. </summary>
        /// <param name="goodApples"> . </param>
        /// <param name="badApples"> . </param>
        internal AppleBarrel(IList<string> goodApples, IList<string> badApples)
        {
            GoodApples = goodApples;
            BadApples = badApples;
        }

        public IList<string> GoodApples { get; set; }
        public IList<string> BadApples { get; set; }
    }
}
