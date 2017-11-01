/* 
 * Res.Grosvenor - Rank
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// LookupResponse2
    /// </summary>
    [DataContract]
    public partial class LookupResponse2 :  IEquatable<LookupResponse2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupResponse2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LookupResponse2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupResponse2" /> class.
        /// </summary>
        /// <param name="Name"> (required).</param>
        /// <param name="Address"> (required).</param>
        /// <param name="TelephoneNumber"> (required).</param>
        /// <param name="MobileNumber"> (required).</param>
        /// <param name="DateOfBirth"> (required).</param>
        /// <param name="EmailAddress"> (required).</param>
        /// <param name="Club"> (required).</param>
        /// <param name="AffId"> (required).</param>
        /// <param name="MembershipNo"> (required).</param>
        /// <param name="CardNo"> (required).</param>
        /// <param name="IsAlreadyUsedOnDigital"> (required).</param>
        public LookupResponse2(Object Name = null, Object Address = null, string TelephoneNumber = null, string MobileNumber = null, string DateOfBirth = null, string EmailAddress = null, Object Club = null, string AffId = null, string MembershipNo = null, int? CardNo = null, bool? IsAlreadyUsedOnDigital = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "TelephoneNumber" is required (not null)
            if (TelephoneNumber == null)
            {
                throw new InvalidDataException("TelephoneNumber is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.TelephoneNumber = TelephoneNumber;
            }
            // to ensure "MobileNumber" is required (not null)
            if (MobileNumber == null)
            {
                throw new InvalidDataException("MobileNumber is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.MobileNumber = MobileNumber;
            }
            // to ensure "DateOfBirth" is required (not null)
            if (DateOfBirth == null)
            {
                throw new InvalidDataException("DateOfBirth is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.DateOfBirth = DateOfBirth;
            }
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            // to ensure "Club" is required (not null)
            if (Club == null)
            {
                throw new InvalidDataException("Club is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.Club = Club;
            }
            // to ensure "AffId" is required (not null)
            if (AffId == null)
            {
                throw new InvalidDataException("AffId is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.AffId = AffId;
            }
            // to ensure "MembershipNo" is required (not null)
            if (MembershipNo == null)
            {
                throw new InvalidDataException("MembershipNo is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.MembershipNo = MembershipNo;
            }
            // to ensure "CardNo" is required (not null)
            if (CardNo == null)
            {
                throw new InvalidDataException("CardNo is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.CardNo = CardNo;
            }
            // to ensure "IsAlreadyUsedOnDigital" is required (not null)
            if (IsAlreadyUsedOnDigital == null)
            {
                throw new InvalidDataException("IsAlreadyUsedOnDigital is a required property for LookupResponse2 and cannot be null");
            }
            else
            {
                this.IsAlreadyUsedOnDigital = IsAlreadyUsedOnDigital;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public Object Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public Object Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="TelephoneNumber", EmitDefaultValue=false)]
        public string TelephoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MobileNumber", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Club", EmitDefaultValue=false)]
        public Object Club { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="AffId", EmitDefaultValue=false)]
        public string AffId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MembershipNo", EmitDefaultValue=false)]
        public string MembershipNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CardNo", EmitDefaultValue=false)]
        public int? CardNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="IsAlreadyUsedOnDigital", EmitDefaultValue=false)]
        public bool? IsAlreadyUsedOnDigital { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupResponse2 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Club: ").Append(Club).Append("\n");
            sb.Append("  AffId: ").Append(AffId).Append("\n");
            sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
            sb.Append("  CardNo: ").Append(CardNo).Append("\n");
            sb.Append("  IsAlreadyUsedOnDigital: ").Append(IsAlreadyUsedOnDigital).Append("\n");
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
            return this.Equals(obj as LookupResponse2);
        }

        /// <summary>
        /// Returns true if LookupResponse2 instances are equal
        /// </summary>
        /// <param name="other">Instance of LookupResponse2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupResponse2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.TelephoneNumber == other.TelephoneNumber ||
                    this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(other.TelephoneNumber)
                ) && 
                (
                    this.MobileNumber == other.MobileNumber ||
                    this.MobileNumber != null &&
                    this.MobileNumber.Equals(other.MobileNumber)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.Club == other.Club ||
                    this.Club != null &&
                    this.Club.Equals(other.Club)
                ) && 
                (
                    this.AffId == other.AffId ||
                    this.AffId != null &&
                    this.AffId.Equals(other.AffId)
                ) && 
                (
                    this.MembershipNo == other.MembershipNo ||
                    this.MembershipNo != null &&
                    this.MembershipNo.Equals(other.MembershipNo)
                ) && 
                (
                    this.CardNo == other.CardNo ||
                    this.CardNo != null &&
                    this.CardNo.Equals(other.CardNo)
                ) && 
                (
                    this.IsAlreadyUsedOnDigital == other.IsAlreadyUsedOnDigital ||
                    this.IsAlreadyUsedOnDigital != null &&
                    this.IsAlreadyUsedOnDigital.Equals(other.IsAlreadyUsedOnDigital)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.TelephoneNumber != null)
                    hash = hash * 59 + this.TelephoneNumber.GetHashCode();
                if (this.MobileNumber != null)
                    hash = hash * 59 + this.MobileNumber.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.Club != null)
                    hash = hash * 59 + this.Club.GetHashCode();
                if (this.AffId != null)
                    hash = hash * 59 + this.AffId.GetHashCode();
                if (this.MembershipNo != null)
                    hash = hash * 59 + this.MembershipNo.GetHashCode();
                if (this.CardNo != null)
                    hash = hash * 59 + this.CardNo.GetHashCode();
                if (this.IsAlreadyUsedOnDigital != null)
                    hash = hash * 59 + this.IsAlreadyUsedOnDigital.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
