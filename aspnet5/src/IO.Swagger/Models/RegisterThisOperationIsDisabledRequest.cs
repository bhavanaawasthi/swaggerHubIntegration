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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RegisterThisOperationIsDisabledRequest :  IEquatable<RegisterThisOperationIsDisabledRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterThisOperationIsDisabledRequest" /> class.
        /// </summary>
        /// <param name="Name"> (required).</param>
        /// <param name="Address"> (required).</param>
        /// <param name="Nationality"> (required).</param>
        /// <param name="TelephoneNumber"> (required).</param>
        /// <param name="MobileNumber"> (required).</param>
        /// <param name="DateOfBirth"> (required).</param>
        /// <param name="EmailAddress"> (required).</param>
        /// <param name="Club"> (required).</param>
        /// <param name="Contactable"> (required).</param>
        /// <param name="ContactChannel"> (required).</param>
        /// <param name="AgeVerified"> (required).</param>
        public RegisterThisOperationIsDisabledRequest(Object Name = null, Object Address = null, string Nationality = null, string TelephoneNumber = null, string MobileNumber = null, string DateOfBirth = null, string EmailAddress = null, Object Club = null, bool? Contactable = null, string ContactChannel = null, bool? AgeVerified = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "Nationality" is required (not null)
            if (Nationality == null)
            {
                throw new InvalidDataException("Nationality is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.Nationality = Nationality;
            }
            // to ensure "TelephoneNumber" is required (not null)
            if (TelephoneNumber == null)
            {
                throw new InvalidDataException("TelephoneNumber is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.TelephoneNumber = TelephoneNumber;
            }
            // to ensure "MobileNumber" is required (not null)
            if (MobileNumber == null)
            {
                throw new InvalidDataException("MobileNumber is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.MobileNumber = MobileNumber;
            }
            // to ensure "DateOfBirth" is required (not null)
            if (DateOfBirth == null)
            {
                throw new InvalidDataException("DateOfBirth is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.DateOfBirth = DateOfBirth;
            }
            // to ensure "EmailAddress" is required (not null)
            if (EmailAddress == null)
            {
                throw new InvalidDataException("EmailAddress is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.EmailAddress = EmailAddress;
            }
            // to ensure "Club" is required (not null)
            if (Club == null)
            {
                throw new InvalidDataException("Club is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.Club = Club;
            }
            // to ensure "Contactable" is required (not null)
            if (Contactable == null)
            {
                throw new InvalidDataException("Contactable is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.Contactable = Contactable;
            }
            // to ensure "ContactChannel" is required (not null)
            if (ContactChannel == null)
            {
                throw new InvalidDataException("ContactChannel is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.ContactChannel = ContactChannel;
            }
            // to ensure "AgeVerified" is required (not null)
            if (AgeVerified == null)
            {
                throw new InvalidDataException("AgeVerified is a required property for RegisterThisOperationIsDisabledRequest and cannot be null");
            }
            else
            {
                this.AgeVerified = AgeVerified;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Name")]
        public Object Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Address")]
        public Object Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="TelephoneNumber")]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MobileNumber")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="DateOfBirth")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Club")]
        public Object Club { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Contactable")]
        public bool? Contactable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ContactChannel")]
        public string ContactChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="AgeVerified")]
        public bool? AgeVerified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterThisOperationIsDisabledRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Club: ").Append(Club).Append("\n");
            sb.Append("  Contactable: ").Append(Contactable).Append("\n");
            sb.Append("  ContactChannel: ").Append(ContactChannel).Append("\n");
            sb.Append("  AgeVerified: ").Append(AgeVerified).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RegisterThisOperationIsDisabledRequest)obj);
        }

        /// <summary>
        /// Returns true if RegisterThisOperationIsDisabledRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterThisOperationIsDisabledRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterThisOperationIsDisabledRequest other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

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
                    this.Nationality == other.Nationality ||
                    this.Nationality != null &&
                    this.Nationality.Equals(other.Nationality)
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
                    this.Contactable == other.Contactable ||
                    this.Contactable != null &&
                    this.Contactable.Equals(other.Contactable)
                ) && 
                (
                    this.ContactChannel == other.ContactChannel ||
                    this.ContactChannel != null &&
                    this.ContactChannel.Equals(other.ContactChannel)
                ) && 
                (
                    this.AgeVerified == other.AgeVerified ||
                    this.AgeVerified != null &&
                    this.AgeVerified.Equals(other.AgeVerified)
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
                if (this.Nationality != null)
                    hash = hash * 59 + this.Nationality.GetHashCode();
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
                if (this.Contactable != null)
                    hash = hash * 59 + this.Contactable.GetHashCode();
                if (this.ContactChannel != null)
                    hash = hash * 59 + this.ContactChannel.GetHashCode();
                if (this.AgeVerified != null)
                    hash = hash * 59 + this.AgeVerified.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RegisterThisOperationIsDisabledRequest left, RegisterThisOperationIsDisabledRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RegisterThisOperationIsDisabledRequest left, RegisterThisOperationIsDisabledRequest right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
