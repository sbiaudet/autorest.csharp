// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace body_complex.Models
{
    /// <summary> The Cookiecuttershark. </summary>
    public partial class Cookiecuttershark : Shark
    {
        /// <summary> Initializes a new instance of Cookiecuttershark. </summary>
        public Cookiecuttershark()
        {
            Fishtype = "cookiecuttershark";
        }

        /// <summary> Initializes a new instance of Cookiecuttershark. </summary>
        /// <param name="age"> . </param>
        /// <param name="birthday"> . </param>
        /// <param name="fishtype"> . </param>
        /// <param name="species"> . </param>
        /// <param name="length"> . </param>
        /// <param name="siblings"> . </param>
        internal Cookiecuttershark(int? age, DateTimeOffset birthday, string fishtype, string species, float length, IList<Fish> siblings) : base(age, birthday, fishtype, species, length, siblings)
        {
            Fishtype = "cookiecuttershark";
        }
    }
}
