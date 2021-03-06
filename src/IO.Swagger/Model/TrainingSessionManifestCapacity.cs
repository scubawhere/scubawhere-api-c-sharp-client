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
    /// TrainingSessionManifestCapacity
    /// </summary>
    [DataContract]
    public partial class TrainingSessionManifestCapacity :  IEquatable<TrainingSessionManifestCapacity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingSessionManifestCapacity" /> class.
        /// </summary>
        /// <param name="Booked">Booked.</param>
        /// <param name="Capacity">Capacity.</param>
        public TrainingSessionManifestCapacity(int? Booked = null, int? Capacity = null)
        {
            this.Booked = Booked;
            this.Capacity = Capacity;
        }
        
        /// <summary>
        /// Gets or Sets Booked
        /// </summary>
        [DataMember(Name="booked", EmitDefaultValue=false)]
        public int? Booked { get; set; }
        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int? Capacity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingSessionManifestCapacity {\n");
            sb.Append("  Booked: ").Append(Booked).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
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
            return this.Equals(obj as TrainingSessionManifestCapacity);
        }

        /// <summary>
        /// Returns true if TrainingSessionManifestCapacity instances are equal
        /// </summary>
        /// <param name="other">Instance of TrainingSessionManifestCapacity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrainingSessionManifestCapacity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Booked == other.Booked ||
                    this.Booked != null &&
                    this.Booked.Equals(other.Booked)
                ) && 
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
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
                if (this.Booked != null)
                    hash = hash * 59 + this.Booked.GetHashCode();
                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();
                return hash;
            }
        }
    }

}
