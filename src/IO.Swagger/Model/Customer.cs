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
    /// Customer
    /// </summary>
    [DataContract]
    public partial class Customer :  IEquatable<Customer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Firstname">Firstname.</param>
        /// <param name="Lastname">Lastname.</param>
        /// <param name="Verified">Verified.</param>
        /// <param name="Birthday">Birthday.</param>
        /// <param name="Gender">Gender.</param>
        /// <param name="Address1">Address1.</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="City">City.</param>
        /// <param name="County">County.</param>
        /// <param name="Postcode">Postcode.</param>
        /// <param name="CountryId">CountryId.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="LastDive">LastDive.</param>
        /// <param name="NumberOfDives">NumberOfDives.</param>
        /// <param name="ChestSize">ChestSize.</param>
        /// <param name="ShoeSize">ShoeSize.</param>
        /// <param name="Height">Height.</param>
        /// <param name="CylinderSize">CylinderSize.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="Unsubscribed">Unsubscribed.</param>
        /// <param name="Country">Country.</param>
        public Customer(long? Id = null, string Email = null, string Firstname = null, string Lastname = null, int? Verified = null, DateTime? Birthday = null, int? Gender = null, string Address1 = null, string Address2 = null, string City = null, string County = null, string Postcode = null, long? CountryId = null, string Phone = null, DateTime? LastDive = null, int? NumberOfDives = null, string ChestSize = null, string ShoeSize = null, string Height = null, string CylinderSize = null, string Notes = null, bool? Unsubscribed = null, Country Country = null)
        {
            this.Id = Id;
            this.Email = Email;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Verified = Verified;
            this.Birthday = Birthday;
            this.Gender = Gender;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.County = County;
            this.Postcode = Postcode;
            this.CountryId = CountryId;
            this.Phone = Phone;
            this.LastDive = LastDive;
            this.NumberOfDives = NumberOfDives;
            this.ChestSize = ChestSize;
            this.ShoeSize = ShoeSize;
            this.Height = Height;
            this.CylinderSize = CylinderSize;
            this.Notes = Notes;
            this.Unsubscribed = Unsubscribed;
            this.Country = Country;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }
        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }
        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public int? Verified { get; set; }
        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name="birthday", EmitDefaultValue=false)]
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public int? Gender { get; set; }
        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address_1", EmitDefaultValue=false)]
        public string Address1 { get; set; }
        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address_2", EmitDefaultValue=false)]
        public string Address2 { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }
        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        public string Postcode { get; set; }
        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public long? CountryId { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets LastDive
        /// </summary>
        [DataMember(Name="last_dive", EmitDefaultValue=false)]
        public DateTime? LastDive { get; set; }
        /// <summary>
        /// Gets or Sets NumberOfDives
        /// </summary>
        [DataMember(Name="number_of_dives", EmitDefaultValue=false)]
        public int? NumberOfDives { get; set; }
        /// <summary>
        /// Gets or Sets ChestSize
        /// </summary>
        [DataMember(Name="chest_size", EmitDefaultValue=false)]
        public string ChestSize { get; set; }
        /// <summary>
        /// Gets or Sets ShoeSize
        /// </summary>
        [DataMember(Name="shoe_size", EmitDefaultValue=false)]
        public string ShoeSize { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }
        /// <summary>
        /// Gets or Sets CylinderSize
        /// </summary>
        [DataMember(Name="cylinder_size", EmitDefaultValue=false)]
        public string CylinderSize { get; set; }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        /// <summary>
        /// Gets or Sets Unsubscribed
        /// </summary>
        [DataMember(Name="unsubscribed", EmitDefaultValue=false)]
        public bool? Unsubscribed { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public Country Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  LastDive: ").Append(LastDive).Append("\n");
            sb.Append("  NumberOfDives: ").Append(NumberOfDives).Append("\n");
            sb.Append("  ChestSize: ").Append(ChestSize).Append("\n");
            sb.Append("  ShoeSize: ").Append(ShoeSize).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  CylinderSize: ").Append(CylinderSize).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as Customer);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
                ) && 
                (
                    this.Birthday == other.Birthday ||
                    this.Birthday != null &&
                    this.Birthday.Equals(other.Birthday)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Postcode == other.Postcode ||
                    this.Postcode != null &&
                    this.Postcode.Equals(other.Postcode)
                ) && 
                (
                    this.CountryId == other.CountryId ||
                    this.CountryId != null &&
                    this.CountryId.Equals(other.CountryId)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.LastDive == other.LastDive ||
                    this.LastDive != null &&
                    this.LastDive.Equals(other.LastDive)
                ) && 
                (
                    this.NumberOfDives == other.NumberOfDives ||
                    this.NumberOfDives != null &&
                    this.NumberOfDives.Equals(other.NumberOfDives)
                ) && 
                (
                    this.ChestSize == other.ChestSize ||
                    this.ChestSize != null &&
                    this.ChestSize.Equals(other.ChestSize)
                ) && 
                (
                    this.ShoeSize == other.ShoeSize ||
                    this.ShoeSize != null &&
                    this.ShoeSize.Equals(other.ShoeSize)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.CylinderSize == other.CylinderSize ||
                    this.CylinderSize != null &&
                    this.CylinderSize.Equals(other.CylinderSize)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.Unsubscribed == other.Unsubscribed ||
                    this.Unsubscribed != null &&
                    this.Unsubscribed.Equals(other.Unsubscribed)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
                if (this.Birthday != null)
                    hash = hash * 59 + this.Birthday.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.Postcode != null)
                    hash = hash * 59 + this.Postcode.GetHashCode();
                if (this.CountryId != null)
                    hash = hash * 59 + this.CountryId.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.LastDive != null)
                    hash = hash * 59 + this.LastDive.GetHashCode();
                if (this.NumberOfDives != null)
                    hash = hash * 59 + this.NumberOfDives.GetHashCode();
                if (this.ChestSize != null)
                    hash = hash * 59 + this.ChestSize.GetHashCode();
                if (this.ShoeSize != null)
                    hash = hash * 59 + this.ShoeSize.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.CylinderSize != null)
                    hash = hash * 59 + this.CylinderSize.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.Unsubscribed != null)
                    hash = hash * 59 + this.Unsubscribed.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }
    }

}
