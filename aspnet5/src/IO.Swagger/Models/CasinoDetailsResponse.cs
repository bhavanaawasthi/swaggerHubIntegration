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
    public partial class CasinoDetailsResponse :  IEquatable<CasinoDetailsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoDetailsResponse" /> class.
        /// </summary>
        /// <param name="Number"> (required).</param>
        /// <param name="Name"> (required).</param>
        /// <param name="Address"> (required).</param>
        /// <param name="Postcode"> (required).</param>
        /// <param name="Town"> (required).</param>
        /// <param name="Location"> (required).</param>
        /// <param name="PhoneNumber"> (required).</param>
        /// <param name="RegionName"> (required).</param>
        /// <param name="Position"> (required).</param>
        /// <param name="CasinoManager"> (required).</param>
        /// <param name="SocialNetworkLinks"> (required).</param>
        /// <param name="AboutCasino"> (required).</param>
        /// <param name="Email"> (required).</param>
        /// <param name="Facilities"> (required).</param>
        /// <param name="OpeningTimes"> (required).</param>
        /// <param name="Games"> (required).</param>
        /// <param name="PanoramaUrl"> (required).</param>
        /// <param name="BookATableConnectionDetails"> (required).</param>
        public CasinoDetailsResponse(int? Number = null, string Name = null, string Address = null, string Postcode = null, string Town = null, string Location = null, string PhoneNumber = null, string RegionName = null, Object Position = null, Object CasinoManager = null, Object SocialNetworkLinks = null, string AboutCasino = null, string Email = null, Object Facilities = null, Object OpeningTimes = null, Object Games = null, string PanoramaUrl = null, Object BookATableConnectionDetails = null)
        {
            // to ensure "Number" is required (not null)
            if (Number == null)
            {
                throw new InvalidDataException("Number is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Number = Number;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "Postcode" is required (not null)
            if (Postcode == null)
            {
                throw new InvalidDataException("Postcode is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Postcode = Postcode;
            }
            // to ensure "Town" is required (not null)
            if (Town == null)
            {
                throw new InvalidDataException("Town is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Town = Town;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            // to ensure "RegionName" is required (not null)
            if (RegionName == null)
            {
                throw new InvalidDataException("RegionName is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.RegionName = RegionName;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "CasinoManager" is required (not null)
            if (CasinoManager == null)
            {
                throw new InvalidDataException("CasinoManager is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.CasinoManager = CasinoManager;
            }
            // to ensure "SocialNetworkLinks" is required (not null)
            if (SocialNetworkLinks == null)
            {
                throw new InvalidDataException("SocialNetworkLinks is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.SocialNetworkLinks = SocialNetworkLinks;
            }
            // to ensure "AboutCasino" is required (not null)
            if (AboutCasino == null)
            {
                throw new InvalidDataException("AboutCasino is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.AboutCasino = AboutCasino;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Facilities" is required (not null)
            if (Facilities == null)
            {
                throw new InvalidDataException("Facilities is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Facilities = Facilities;
            }
            // to ensure "OpeningTimes" is required (not null)
            if (OpeningTimes == null)
            {
                throw new InvalidDataException("OpeningTimes is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.OpeningTimes = OpeningTimes;
            }
            // to ensure "Games" is required (not null)
            if (Games == null)
            {
                throw new InvalidDataException("Games is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.Games = Games;
            }
            // to ensure "PanoramaUrl" is required (not null)
            if (PanoramaUrl == null)
            {
                throw new InvalidDataException("PanoramaUrl is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.PanoramaUrl = PanoramaUrl;
            }
            // to ensure "BookATableConnectionDetails" is required (not null)
            if (BookATableConnectionDetails == null)
            {
                throw new InvalidDataException("BookATableConnectionDetails is a required property for CasinoDetailsResponse and cannot be null");
            }
            else
            {
                this.BookATableConnectionDetails = BookATableConnectionDetails;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Address")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Town")]
        public string Town { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Location")]
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PhoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="RegionName")]
        public string RegionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Position")]
        public Object Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CasinoManager")]
        public Object CasinoManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="SocialNetworkLinks")]
        public Object SocialNetworkLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="AboutCasino")]
        public string AboutCasino { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Facilities")]
        public Object Facilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="OpeningTimes")]
        public Object OpeningTimes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Games")]
        public Object Games { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PanoramaUrl")]
        public string PanoramaUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="BookATableConnectionDetails")]
        public Object BookATableConnectionDetails { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CasinoDetailsResponse {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  RegionName: ").Append(RegionName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  CasinoManager: ").Append(CasinoManager).Append("\n");
            sb.Append("  SocialNetworkLinks: ").Append(SocialNetworkLinks).Append("\n");
            sb.Append("  AboutCasino: ").Append(AboutCasino).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Facilities: ").Append(Facilities).Append("\n");
            sb.Append("  OpeningTimes: ").Append(OpeningTimes).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
            sb.Append("  PanoramaUrl: ").Append(PanoramaUrl).Append("\n");
            sb.Append("  BookATableConnectionDetails: ").Append(BookATableConnectionDetails).Append("\n");
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
            return Equals((CasinoDetailsResponse)obj);
        }

        /// <summary>
        /// Returns true if CasinoDetailsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CasinoDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CasinoDetailsResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
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
                    this.Postcode == other.Postcode ||
                    this.Postcode != null &&
                    this.Postcode.Equals(other.Postcode)
                ) && 
                (
                    this.Town == other.Town ||
                    this.Town != null &&
                    this.Town.Equals(other.Town)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.RegionName == other.RegionName ||
                    this.RegionName != null &&
                    this.RegionName.Equals(other.RegionName)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.CasinoManager == other.CasinoManager ||
                    this.CasinoManager != null &&
                    this.CasinoManager.Equals(other.CasinoManager)
                ) && 
                (
                    this.SocialNetworkLinks == other.SocialNetworkLinks ||
                    this.SocialNetworkLinks != null &&
                    this.SocialNetworkLinks.Equals(other.SocialNetworkLinks)
                ) && 
                (
                    this.AboutCasino == other.AboutCasino ||
                    this.AboutCasino != null &&
                    this.AboutCasino.Equals(other.AboutCasino)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Facilities == other.Facilities ||
                    this.Facilities != null &&
                    this.Facilities.Equals(other.Facilities)
                ) && 
                (
                    this.OpeningTimes == other.OpeningTimes ||
                    this.OpeningTimes != null &&
                    this.OpeningTimes.Equals(other.OpeningTimes)
                ) && 
                (
                    this.Games == other.Games ||
                    this.Games != null &&
                    this.Games.Equals(other.Games)
                ) && 
                (
                    this.PanoramaUrl == other.PanoramaUrl ||
                    this.PanoramaUrl != null &&
                    this.PanoramaUrl.Equals(other.PanoramaUrl)
                ) && 
                (
                    this.BookATableConnectionDetails == other.BookATableConnectionDetails ||
                    this.BookATableConnectionDetails != null &&
                    this.BookATableConnectionDetails.Equals(other.BookATableConnectionDetails)
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
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Postcode != null)
                    hash = hash * 59 + this.Postcode.GetHashCode();
                if (this.Town != null)
                    hash = hash * 59 + this.Town.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.RegionName != null)
                    hash = hash * 59 + this.RegionName.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.CasinoManager != null)
                    hash = hash * 59 + this.CasinoManager.GetHashCode();
                if (this.SocialNetworkLinks != null)
                    hash = hash * 59 + this.SocialNetworkLinks.GetHashCode();
                if (this.AboutCasino != null)
                    hash = hash * 59 + this.AboutCasino.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Facilities != null)
                    hash = hash * 59 + this.Facilities.GetHashCode();
                if (this.OpeningTimes != null)
                    hash = hash * 59 + this.OpeningTimes.GetHashCode();
                if (this.Games != null)
                    hash = hash * 59 + this.Games.GetHashCode();
                if (this.PanoramaUrl != null)
                    hash = hash * 59 + this.PanoramaUrl.GetHashCode();
                if (this.BookATableConnectionDetails != null)
                    hash = hash * 59 + this.BookATableConnectionDetails.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CasinoDetailsResponse left, CasinoDetailsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CasinoDetailsResponse left, CasinoDetailsResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
