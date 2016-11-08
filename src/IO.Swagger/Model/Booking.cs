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
    /// Booking
    /// </summary>
    [DataContract]
    public partial class Booking :  IEquatable<Booking>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Booking" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Reference">Reference.</param>
        /// <param name="LeadCustomerId">LeadCustomerId.</param>
        /// <param name="AgentId">AgentId.</param>
        /// <param name="AgentReference">AgentReference.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="Status">Status.</param>
        /// <param name="ReservedUntil">ReservedUntil.</param>
        /// <param name="CancellationFee">CancellationFee.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="DecimalPrice">DecimalPrice.</param>
        /// <param name="RealDecimalPrice">RealDecimalPrice.</param>
        /// <param name="ArrivalDate">ArrivalDate.</param>
        /// <param name="CreatedAtLocal">CreatedAtLocal.</param>
        /// <param name="LeadCustomer">LeadCustomer.</param>
        /// <param name="Payments">Payments.</param>
        /// <param name="Refunds">Refunds.</param>
        public Booking(long? Id = null, string Reference = null, long? LeadCustomerId = null, long? AgentId = null, string AgentReference = null, string Source = null, long? Price = null, int? Discount = null, string Status = null, DateTime? ReservedUntil = null, long? CancellationFee = null, string Comment = null, long? ParentId = null, string DecimalPrice = null, string RealDecimalPrice = null, DateTime? ArrivalDate = null, DateTime? CreatedAtLocal = null, Customer LeadCustomer = null, List<Payment> Payments = null, List<Refund> Refunds = null)
        {
            this.Id = Id;
            this.Reference = Reference;
            this.LeadCustomerId = LeadCustomerId;
            this.AgentId = AgentId;
            this.AgentReference = AgentReference;
            this.Source = Source;
            this.Price = Price;
            this.Discount = Discount;
            this.Status = Status;
            this.ReservedUntil = ReservedUntil;
            this.CancellationFee = CancellationFee;
            this.Comment = Comment;
            this.ParentId = ParentId;
            this.DecimalPrice = DecimalPrice;
            this.RealDecimalPrice = RealDecimalPrice;
            this.ArrivalDate = ArrivalDate;
            this.CreatedAtLocal = CreatedAtLocal;
            this.LeadCustomer = LeadCustomer;
            this.Payments = Payments;
            this.Refunds = Refunds;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }
        /// <summary>
        /// Gets or Sets LeadCustomerId
        /// </summary>
        [DataMember(Name="lead_customer_id", EmitDefaultValue=false)]
        public long? LeadCustomerId { get; set; }
        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agent_id", EmitDefaultValue=false)]
        public long? AgentId { get; set; }
        /// <summary>
        /// Gets or Sets AgentReference
        /// </summary>
        [DataMember(Name="agent_reference", EmitDefaultValue=false)]
        public string AgentReference { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public long? Price { get; set; }
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public int? Discount { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets ReservedUntil
        /// </summary>
        [DataMember(Name="reserved_until", EmitDefaultValue=false)]
        public DateTime? ReservedUntil { get; set; }
        /// <summary>
        /// Gets or Sets CancellationFee
        /// </summary>
        [DataMember(Name="cancellation_fee", EmitDefaultValue=false)]
        public long? CancellationFee { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public long? ParentId { get; set; }
        /// <summary>
        /// Gets or Sets DecimalPrice
        /// </summary>
        [DataMember(Name="decimal_price", EmitDefaultValue=false)]
        public string DecimalPrice { get; set; }
        /// <summary>
        /// Gets or Sets RealDecimalPrice
        /// </summary>
        [DataMember(Name="real_decimal_price", EmitDefaultValue=false)]
        public string RealDecimalPrice { get; set; }
        /// <summary>
        /// Gets or Sets ArrivalDate
        /// </summary>
        [DataMember(Name="arrival_date", EmitDefaultValue=false)]
        public DateTime? ArrivalDate { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAtLocal
        /// </summary>
        [DataMember(Name="created_at_local", EmitDefaultValue=false)]
        public DateTime? CreatedAtLocal { get; set; }
        /// <summary>
        /// Gets or Sets LeadCustomer
        /// </summary>
        [DataMember(Name="lead_customer", EmitDefaultValue=false)]
        public Customer LeadCustomer { get; set; }
        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }
        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<Refund> Refunds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Booking {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LeadCustomerId: ").Append(LeadCustomerId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentReference: ").Append(AgentReference).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReservedUntil: ").Append(ReservedUntil).Append("\n");
            sb.Append("  CancellationFee: ").Append(CancellationFee).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  DecimalPrice: ").Append(DecimalPrice).Append("\n");
            sb.Append("  RealDecimalPrice: ").Append(RealDecimalPrice).Append("\n");
            sb.Append("  ArrivalDate: ").Append(ArrivalDate).Append("\n");
            sb.Append("  CreatedAtLocal: ").Append(CreatedAtLocal).Append("\n");
            sb.Append("  LeadCustomer: ").Append(LeadCustomer).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
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
            return this.Equals(obj as Booking);
        }

        /// <summary>
        /// Returns true if Booking instances are equal
        /// </summary>
        /// <param name="other">Instance of Booking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Booking other)
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
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.LeadCustomerId == other.LeadCustomerId ||
                    this.LeadCustomerId != null &&
                    this.LeadCustomerId.Equals(other.LeadCustomerId)
                ) && 
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) && 
                (
                    this.AgentReference == other.AgentReference ||
                    this.AgentReference != null &&
                    this.AgentReference.Equals(other.AgentReference)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ReservedUntil == other.ReservedUntil ||
                    this.ReservedUntil != null &&
                    this.ReservedUntil.Equals(other.ReservedUntil)
                ) && 
                (
                    this.CancellationFee == other.CancellationFee ||
                    this.CancellationFee != null &&
                    this.CancellationFee.Equals(other.CancellationFee)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.DecimalPrice == other.DecimalPrice ||
                    this.DecimalPrice != null &&
                    this.DecimalPrice.Equals(other.DecimalPrice)
                ) && 
                (
                    this.RealDecimalPrice == other.RealDecimalPrice ||
                    this.RealDecimalPrice != null &&
                    this.RealDecimalPrice.Equals(other.RealDecimalPrice)
                ) && 
                (
                    this.ArrivalDate == other.ArrivalDate ||
                    this.ArrivalDate != null &&
                    this.ArrivalDate.Equals(other.ArrivalDate)
                ) && 
                (
                    this.CreatedAtLocal == other.CreatedAtLocal ||
                    this.CreatedAtLocal != null &&
                    this.CreatedAtLocal.Equals(other.CreatedAtLocal)
                ) && 
                (
                    this.LeadCustomer == other.LeadCustomer ||
                    this.LeadCustomer != null &&
                    this.LeadCustomer.Equals(other.LeadCustomer)
                ) && 
                (
                    this.Payments == other.Payments ||
                    this.Payments != null &&
                    this.Payments.SequenceEqual(other.Payments)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
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
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.LeadCustomerId != null)
                    hash = hash * 59 + this.LeadCustomerId.GetHashCode();
                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();
                if (this.AgentReference != null)
                    hash = hash * 59 + this.AgentReference.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReservedUntil != null)
                    hash = hash * 59 + this.ReservedUntil.GetHashCode();
                if (this.CancellationFee != null)
                    hash = hash * 59 + this.CancellationFee.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.DecimalPrice != null)
                    hash = hash * 59 + this.DecimalPrice.GetHashCode();
                if (this.RealDecimalPrice != null)
                    hash = hash * 59 + this.RealDecimalPrice.GetHashCode();
                if (this.ArrivalDate != null)
                    hash = hash * 59 + this.ArrivalDate.GetHashCode();
                if (this.CreatedAtLocal != null)
                    hash = hash * 59 + this.CreatedAtLocal.GetHashCode();
                if (this.LeadCustomer != null)
                    hash = hash * 59 + this.LeadCustomer.GetHashCode();
                if (this.Payments != null)
                    hash = hash * 59 + this.Payments.GetHashCode();
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                return hash;
            }
        }
    }

}
