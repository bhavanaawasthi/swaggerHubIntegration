/* 
 * Res.Grosvenor - Rank
 *
 * Rank Enterprise Services API is a collection of business services exposed over a RESTful inteface. This endpoint is specific to Grosvenor Casinos implementation.
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
    /// CreateLoyaltyAccountForRetailMembershipAccountRequest
    /// </summary>
    [DataContract]
    public partial class CreateLoyaltyAccountForRetailMembershipAccountRequest :  IEquatable<CreateLoyaltyAccountForRetailMembershipAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoyaltyAccountForRetailMembershipAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateLoyaltyAccountForRetailMembershipAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoyaltyAccountForRetailMembershipAccountRequest" /> class.
        /// </summary>
        /// <param name="Name"> (required).</param>
        /// <param name="Address"> (required).</param>
        /// <param name="TelephoneNumber"> (required).</param>
        /// <param name="MobileNumber"> (required).</param>
        /// <param name="EmailAddress"> (required).</param>
        /// <param name="DateOfBirth"> (required).</param>
        /// <param name="Ethnicity"> (required).</param>
        /// <param name="Gender"> (required).</param>
        /// <param name="MailReturned"> (required).</param>
        /// <param name="FirstTrip"> (required).</param>
        /// <param name="LastTrip"> (required).</param>
        /// <param name="ComputerRating"> (required).</param>
        /// <param name="MembershipNo"> (required).</param>
        /// <param name="CardNo"> (required).</param>
        public CreateLoyaltyAccountForRetailMembershipAccountRequest(Object Name = null, Object Address = null, string TelephoneNumber = null, string MobileNumber = null, string EmailAddress = null, string DateOfBirth = null, string Ethnicity = null, string Gender = null, bool? MailReturned = null, string FirstTrip = null, string LastTrip = null, string ComputerRating = null, string MembershipNo = null, int? CardNo = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "TelephoneNumber" is required (not null)
            if (TelephoneNumber == null)
            {
                throw new InvalidDataException("TelephoneNumber is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.TelephoneNumber = TelephoneNumber;
            }
            // to ensure "MobileNumber" is required (not null)
            if (MobileNumber == null)
            {
                throw new InvalidDataException("MobileNumber is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.MobileNumber = MobileNumber;
            }
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            // to ensure "DateOfBirth" is required (not null)
            if (DateOfBirth == null)
            {
                throw new InvalidDataException("DateOfBirth is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.DateOfBirth = DateOfBirth;
            }
            // to ensure "Ethnicity" is required (not null)
            if (Ethnicity == null)
            {
                throw new InvalidDataException("Ethnicity is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.Ethnicity = Ethnicity;
            }
            // to ensure "Gender" is required (not null)
            if (Gender == null)
            {
                throw new InvalidDataException("Gender is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.Gender = Gender;
            }
            // to ensure "MailReturned" is required (not null)
            if (MailReturned == null)
            {
                throw new InvalidDataException("MailReturned is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.MailReturned = MailReturned;
            }
            // to ensure "FirstTrip" is required (not null)
            if (FirstTrip == null)
            {
                throw new InvalidDataException("FirstTrip is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.FirstTrip = FirstTrip;
            }
            // to ensure "LastTrip" is required (not null)
            if (LastTrip == null)
            {
                throw new InvalidDataException("LastTrip is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.LastTrip = LastTrip;
            }
            // to ensure "ComputerRating" is required (not null)
            if (ComputerRating == null)
            {
                throw new InvalidDataException("ComputerRating is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.ComputerRating = ComputerRating;
            }
            // to ensure "MembershipNo" is required (not null)
            if (MembershipNo == null)
            {
                throw new InvalidDataException("MembershipNo is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.MembershipNo = MembershipNo;
            }
            // to ensure "CardNo" is required (not null)
            if (CardNo == null)
            {
                throw new InvalidDataException("CardNo is a required property for CreateLoyaltyAccountForRetailMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.CardNo = CardNo;
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
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }
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
        [DataMember(Name="Ethnicity", EmitDefaultValue=false)]
        public string Ethnicity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MailReturned", EmitDefaultValue=false)]
        public bool? MailReturned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="FirstTrip", EmitDefaultValue=false)]
        public string FirstTrip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="LastTrip", EmitDefaultValue=false)]
        public string LastTrip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ComputerRating", EmitDefaultValue=false)]
        public string ComputerRating { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoyaltyAccountForRetailMembershipAccountRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  MailReturned: ").Append(MailReturned).Append("\n");
            sb.Append("  FirstTrip: ").Append(FirstTrip).Append("\n");
            sb.Append("  LastTrip: ").Append(LastTrip).Append("\n");
            sb.Append("  ComputerRating: ").Append(ComputerRating).Append("\n");
            sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
            sb.Append("  CardNo: ").Append(CardNo).Append("\n");
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
            return this.Equals(obj as CreateLoyaltyAccountForRetailMembershipAccountRequest);
        }

        /// <summary>
        /// Returns true if CreateLoyaltyAccountForRetailMembershipAccountRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateLoyaltyAccountForRetailMembershipAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLoyaltyAccountForRetailMembershipAccountRequest other)
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
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.Ethnicity == other.Ethnicity ||
                    this.Ethnicity != null &&
                    this.Ethnicity.Equals(other.Ethnicity)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.MailReturned == other.MailReturned ||
                    this.MailReturned != null &&
                    this.MailReturned.Equals(other.MailReturned)
                ) && 
                (
                    this.FirstTrip == other.FirstTrip ||
                    this.FirstTrip != null &&
                    this.FirstTrip.Equals(other.FirstTrip)
                ) && 
                (
                    this.LastTrip == other.LastTrip ||
                    this.LastTrip != null &&
                    this.LastTrip.Equals(other.LastTrip)
                ) && 
                (
                    this.ComputerRating == other.ComputerRating ||
                    this.ComputerRating != null &&
                    this.ComputerRating.Equals(other.ComputerRating)
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
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.Ethnicity != null)
                    hash = hash * 59 + this.Ethnicity.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.MailReturned != null)
                    hash = hash * 59 + this.MailReturned.GetHashCode();
                if (this.FirstTrip != null)
                    hash = hash * 59 + this.FirstTrip.GetHashCode();
                if (this.LastTrip != null)
                    hash = hash * 59 + this.LastTrip.GetHashCode();
                if (this.ComputerRating != null)
                    hash = hash * 59 + this.ComputerRating.GetHashCode();
                if (this.MembershipNo != null)
                    hash = hash * 59 + this.MembershipNo.GetHashCode();
                if (this.CardNo != null)
                    hash = hash * 59 + this.CardNo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
