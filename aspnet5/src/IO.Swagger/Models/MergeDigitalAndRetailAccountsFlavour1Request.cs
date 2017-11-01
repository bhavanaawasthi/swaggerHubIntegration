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
    public partial class MergeDigitalAndRetailAccountsFlavour1Request :  IEquatable<MergeDigitalAndRetailAccountsFlavour1Request>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeDigitalAndRetailAccountsFlavour1Request" /> class.
        /// </summary>
        /// <param name="PlayerId"> (required).</param>
        /// <param name="MembershipNo"> (required).</param>
        public MergeDigitalAndRetailAccountsFlavour1Request(int? PlayerId = null, string MembershipNo = null)
        {
            // to ensure "PlayerId" is required (not null)
            if (PlayerId == null)
            {
                throw new InvalidDataException("PlayerId is a required property for MergeDigitalAndRetailAccountsFlavour1Request and cannot be null");
            }
            else
            {
                this.PlayerId = PlayerId;
            }
            // to ensure "MembershipNo" is required (not null)
            if (MembershipNo == null)
            {
                throw new InvalidDataException("MembershipNo is a required property for MergeDigitalAndRetailAccountsFlavour1Request and cannot be null");
            }
            else
            {
                this.MembershipNo = MembershipNo;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PlayerId")]
        public int? PlayerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MembershipNo")]
        public string MembershipNo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeDigitalAndRetailAccountsFlavour1Request {\n");
            sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
            sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
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
            return Equals((MergeDigitalAndRetailAccountsFlavour1Request)obj);
        }

        /// <summary>
        /// Returns true if MergeDigitalAndRetailAccountsFlavour1Request instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeDigitalAndRetailAccountsFlavour1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeDigitalAndRetailAccountsFlavour1Request other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.PlayerId == other.PlayerId ||
                    this.PlayerId != null &&
                    this.PlayerId.Equals(other.PlayerId)
                ) && 
                (
                    this.MembershipNo == other.MembershipNo ||
                    this.MembershipNo != null &&
                    this.MembershipNo.Equals(other.MembershipNo)
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
                if (this.PlayerId != null)
                    hash = hash * 59 + this.PlayerId.GetHashCode();
                if (this.MembershipNo != null)
                    hash = hash * 59 + this.MembershipNo.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(MergeDigitalAndRetailAccountsFlavour1Request left, MergeDigitalAndRetailAccountsFlavour1Request right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MergeDigitalAndRetailAccountsFlavour1Request left, MergeDigitalAndRetailAccountsFlavour1Request right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
