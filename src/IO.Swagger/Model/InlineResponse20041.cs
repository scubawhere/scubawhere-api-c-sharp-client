/* 
 * Scubawhere API Documentation
 *
 * This is the documentation for scubawhere's RMS API. This API is only to be used by authorized parties with valid auth tokens.  [Learn about scubawhere](http://www.scubawhere.com) to become an authorized consumer of our API 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: bryan@scubawhere.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse20041
    /// </summary>
    [DataContract]
    public partial class InlineResponse20041 :  IEquatable<InlineResponse20041>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20041" /> class.
        /// </summary>
        /// <param name="Daterange">Daterange.</param>
        /// <param name="SourceFrequency">SourceFrequency.</param>
        /// <param name="SourceRevenue">SourceRevenue.</param>
        public InlineResponse20041(DateRange Daterange = null, List<int?> SourceFrequency = null, List<int?> SourceRevenue = null)
        {
            this.Daterange = Daterange;
            this.SourceFrequency = SourceFrequency;
            this.SourceRevenue = SourceRevenue;
        }
        
        /// <summary>
        /// Gets or Sets Daterange
        /// </summary>
        [DataMember(Name="daterange", EmitDefaultValue=false)]
        public DateRange Daterange { get; set; }
        /// <summary>
        /// Gets or Sets SourceFrequency
        /// </summary>
        [DataMember(Name="source_frequency", EmitDefaultValue=false)]
        public List<int?> SourceFrequency { get; set; }
        /// <summary>
        /// Gets or Sets SourceRevenue
        /// </summary>
        [DataMember(Name="source_revenue", EmitDefaultValue=false)]
        public List<int?> SourceRevenue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20041 {\n");
            sb.Append("  Daterange: ").Append(Daterange).Append("\n");
            sb.Append("  SourceFrequency: ").Append(SourceFrequency).Append("\n");
            sb.Append("  SourceRevenue: ").Append(SourceRevenue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20041);
        }

        /// <summary>
        /// Returns true if InlineResponse20041 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20041 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20041 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Daterange == other.Daterange ||
                    this.Daterange != null &&
                    this.Daterange.Equals(other.Daterange)
                ) && 
                (
                    this.SourceFrequency == other.SourceFrequency ||
                    this.SourceFrequency != null &&
                    this.SourceFrequency.SequenceEqual(other.SourceFrequency)
                ) && 
                (
                    this.SourceRevenue == other.SourceRevenue ||
                    this.SourceRevenue != null &&
                    this.SourceRevenue.SequenceEqual(other.SourceRevenue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Daterange != null)
                    hash = hash * 59 + this.Daterange.GetHashCode();
                if (this.SourceFrequency != null)
                    hash = hash * 59 + this.SourceFrequency.GetHashCode();
                if (this.SourceRevenue != null)
                    hash = hash * 59 + this.SourceRevenue.GetHashCode();
                return hash;
            }
        }
    }

}
