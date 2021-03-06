// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace body_complex.Models
{
    /// <summary> The Sawshark. </summary>
    public partial class Sawshark : Shark
    {
        /// <summary> Initializes a new instance of Sawshark. </summary>
        public Sawshark()
        {
            Fishtype = "sawshark";
        }

        /// <summary> Initializes a new instance of Sawshark. </summary>
        /// <param name="picture"> . </param>
        /// <param name="age"> . </param>
        /// <param name="birthday"> . </param>
        /// <param name="fishtype"> . </param>
        /// <param name="species"> . </param>
        /// <param name="length"> . </param>
        /// <param name="siblings"> . </param>
        internal Sawshark(byte[] picture, int? age, DateTimeOffset birthday, string fishtype, string species, float length, IList<Fish> siblings) : base(age, birthday, fishtype, species, length, siblings)
        {
            Picture = picture;
            Fishtype = "sawshark";
        }

        public byte[] Picture { get; set; }
    }
}
