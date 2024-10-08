// <copyright file="ContributionTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace JustGainsAPI.Standard.Models
{
    /// <summary>
    /// ContributionTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContributionTypeEnum
    {
        /// <summary>
        /// ORIGINALAUTHOR.
        /// </summary>
        [EnumMember(Value = "ORIGINAL_AUTHOR")]
        ORIGINALAUTHOR,

        /// <summary>
        /// PARTIALCONTRIBUTOR.
        /// </summary>
        [EnumMember(Value = "PARTIAL_CONTRIBUTOR")]
        PARTIALCONTRIBUTOR,

        /// <summary>
        /// SUBMITTER.
        /// </summary>
        [EnumMember(Value = "SUBMITTER")]
        SUBMITTER,

        /// <summary>
        /// CURATOR.
        /// </summary>
        [EnumMember(Value = "CURATOR")]
        CURATOR
    }
}