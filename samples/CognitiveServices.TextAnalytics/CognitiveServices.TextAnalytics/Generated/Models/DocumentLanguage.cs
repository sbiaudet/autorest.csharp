// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentLanguage. </summary>
    public partial class DocumentLanguage
    {
        /// <summary> Initializes a new instance of DocumentLanguage. </summary>
        internal DocumentLanguage()
        {
        }

        /// <summary> Initializes a new instance of DocumentLanguage. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="detectedLanguages"> A list of extracted languages. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal DocumentLanguage(string id, IList<DetectedLanguage> detectedLanguages, DocumentStatistics statistics)
        {
            Id = id;
            DetectedLanguages = detectedLanguages;
            Statistics = statistics;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; internal set; }
        /// <summary> A list of extracted languages. </summary>
        public IList<DetectedLanguage> DetectedLanguages { get; internal set; } = new List<DetectedLanguage>();
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; internal set; }
    }
}
