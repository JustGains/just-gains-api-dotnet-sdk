// <copyright file="MeasurementData.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Models
{
    /// <summary>
    /// MeasurementData.
    /// </summary>
    public class MeasurementData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData"/> class.
        /// </summary>
        public MeasurementData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementData"/> class.
        /// </summary>
        /// <param name="metricCode">metricCode.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="units">units.</param>
        /// <param name="displayFormat">displayFormat.</param>
        /// <param name="inputType">inputType.</param>
        /// <param name="step">step.</param>
        /// <param name="minValue">minValue.</param>
        /// <param name="maxValue">maxValue.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="conversionFactor">conversionFactor.</param>
        public MeasurementData(
            string metricCode = null,
            string displayName = null,
            Models.Units units = null,
            string displayFormat = null,
            string inputType = null,
            double? step = null,
            double? minValue = null,
            double? maxValue = null,
            double? defaultValue = null,
            Models.ConversionFactor conversionFactor = null)
        {
            this.MetricCode = metricCode;
            this.DisplayName = displayName;
            this.Units = units;
            this.DisplayFormat = displayFormat;
            this.InputType = inputType;
            this.Step = step;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.DefaultValue = defaultValue;
            this.ConversionFactor = conversionFactor;
        }

        /// <summary>
        /// Gets or sets MetricCode.
        /// </summary>
        [JsonProperty("metricCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricCode { get; set; }

        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Units Units { get; set; }

        /// <summary>
        /// Gets or sets DisplayFormat.
        /// </summary>
        [JsonProperty("displayFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayFormat { get; set; }

        /// <summary>
        /// Gets or sets InputType.
        /// </summary>
        [JsonProperty("inputType", NullValueHandling = NullValueHandling.Ignore)]
        public string InputType { get; set; }

        /// <summary>
        /// Gets or sets Step.
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public double? Step { get; set; }

        /// <summary>
        /// Gets or sets MinValue.
        /// </summary>
        [JsonProperty("minValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinValue { get; set; }

        /// <summary>
        /// Gets or sets MaxValue.
        /// </summary>
        [JsonProperty("maxValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// Gets or sets DefaultValue.
        /// </summary>
        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets ConversionFactor.
        /// </summary>
        [JsonProperty("conversionFactor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ConversionFactor ConversionFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MeasurementData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is MeasurementData other &&                ((this.MetricCode == null && other.MetricCode == null) || (this.MetricCode?.Equals(other.MetricCode) == true)) &&
                ((this.DisplayName == null && other.DisplayName == null) || (this.DisplayName?.Equals(other.DisplayName) == true)) &&
                ((this.Units == null && other.Units == null) || (this.Units?.Equals(other.Units) == true)) &&
                ((this.DisplayFormat == null && other.DisplayFormat == null) || (this.DisplayFormat?.Equals(other.DisplayFormat) == true)) &&
                ((this.InputType == null && other.InputType == null) || (this.InputType?.Equals(other.InputType) == true)) &&
                ((this.Step == null && other.Step == null) || (this.Step?.Equals(other.Step) == true)) &&
                ((this.MinValue == null && other.MinValue == null) || (this.MinValue?.Equals(other.MinValue) == true)) &&
                ((this.MaxValue == null && other.MaxValue == null) || (this.MaxValue?.Equals(other.MaxValue) == true)) &&
                ((this.DefaultValue == null && other.DefaultValue == null) || (this.DefaultValue?.Equals(other.DefaultValue) == true)) &&
                ((this.ConversionFactor == null && other.ConversionFactor == null) || (this.ConversionFactor?.Equals(other.ConversionFactor) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MetricCode = {(this.MetricCode == null ? "null" : this.MetricCode)}");
            toStringOutput.Add($"this.DisplayName = {(this.DisplayName == null ? "null" : this.DisplayName)}");
            toStringOutput.Add($"this.Units = {(this.Units == null ? "null" : this.Units.ToString())}");
            toStringOutput.Add($"this.DisplayFormat = {(this.DisplayFormat == null ? "null" : this.DisplayFormat)}");
            toStringOutput.Add($"this.InputType = {(this.InputType == null ? "null" : this.InputType)}");
            toStringOutput.Add($"this.Step = {(this.Step == null ? "null" : this.Step.ToString())}");
            toStringOutput.Add($"this.MinValue = {(this.MinValue == null ? "null" : this.MinValue.ToString())}");
            toStringOutput.Add($"this.MaxValue = {(this.MaxValue == null ? "null" : this.MaxValue.ToString())}");
            toStringOutput.Add($"this.DefaultValue = {(this.DefaultValue == null ? "null" : this.DefaultValue.ToString())}");
            toStringOutput.Add($"this.ConversionFactor = {(this.ConversionFactor == null ? "null" : this.ConversionFactor.ToString())}");
        }
    }
}