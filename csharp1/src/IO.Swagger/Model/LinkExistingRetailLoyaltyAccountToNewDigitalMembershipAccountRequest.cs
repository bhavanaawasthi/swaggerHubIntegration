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
    /// LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest
    /// </summary>
    [DataContract]
    public partial class LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest :  IEquatable<LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest" /> class.
        /// </summary>
        /// <param name="PlayerId"> (required).</param>
        /// <param name="MembershipNo"> (required).</param>
        public LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest(int? PlayerId = null, string MembershipNo = null)
        {
            // to ensure "PlayerId" is required (not null)
            if (PlayerId == null)
            {
                throw new InvalidDataException("PlayerId is a required property for LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest and cannot be null");
            }
            else
            {
                this.PlayerId = PlayerId;
            }
            // to ensure "MembershipNo" is required (not null)
            if (MembershipNo == null)
            {
                throw new InvalidDataException("MembershipNo is a required property for LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest and cannot be null");
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
        [DataMember(Name="PlayerId", EmitDefaultValue=false)]
        public int? PlayerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MembershipNo", EmitDefaultValue=false)]
        public string MembershipNo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest {\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest);
        }

        /// <summary>
        /// Returns true if LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkExistingRetailLoyaltyAccountToNewDigitalMembershipAccountRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
