// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The DocumentSentiment. </summary>
    public partial class DocumentSentiment
    {
        /// <summary> Initializes a new instance of DocumentSentiment. </summary>
        internal DocumentSentiment()
        {
        }

        /// <summary> Initializes a new instance of DocumentSentiment. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="sentiment"> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="documentScores"> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </param>
        /// <param name="sentences"> Sentence level sentiment analysis. </param>
        internal DocumentSentiment(string id, DocumentSentimentValue sentiment, DocumentStatistics statistics, SentimentConfidenceScorePerLabel documentScores, IList<SentenceSentiment> sentences)
        {
            Id = id;
            Sentiment = sentiment;
            Statistics = statistics;
            DocumentScores = documentScores;
            Sentences = sentences;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; internal set; }
        /// <summary> Predicted sentiment for document (Negative, Neutral, Positive, or Mixed). </summary>
        public DocumentSentimentValue Sentiment { get; internal set; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public DocumentStatistics Statistics { get; internal set; }
        /// <summary> Document level sentiment confidence scores between 0 and 1 for each sentiment class. </summary>
        public SentimentConfidenceScorePerLabel DocumentScores { get; internal set; } = new SentimentConfidenceScorePerLabel();
        /// <summary> Sentence level sentiment analysis. </summary>
        public IList<SentenceSentiment> Sentences { get; internal set; } = new List<SentenceSentiment>();
    }
}
