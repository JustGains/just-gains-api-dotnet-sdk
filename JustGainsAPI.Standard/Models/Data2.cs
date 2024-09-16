// <copyright file="Data2.cs" company="APIMatic">
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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JustGainsAPI.Standard.Models
{
    /// <summary>
    /// Data2.
    /// </summary>
    public class Data2
    {
        private string text;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "text", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        public Data2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        /// <param name="text">text.</param>
        public Data2(
            string text = null)
        {
            if (text != null)
            {
                this.Text = text;
            }

        }

        /// <summary>
        /// Gets or sets Text.
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.shouldSerialize["text"] = true;
                this.text = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetText()
        {
            this.shouldSerialize["text"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeText()
        {
            return this.shouldSerialize["text"];
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
            return obj is Data2 other &&                ((this.Text == null && other.Text == null) || (this.Text?.Equals(other.Text) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Text = {(this.Text == null ? "null" : this.Text)}");
        }
    }
}