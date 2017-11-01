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
    public partial class RetrieveAllAccountsSummaryByGradeResponse :  IEquatable<RetrieveAllAccountsSummaryByGradeResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveAllAccountsSummaryByGradeResponse" /> class.
        /// </summary>
        /// <param name="MembershipNo"> (required).</param>
        /// <param name="CardNo"> (required).</param>
        /// <param name="GradeId"> (required).</param>
        /// <param name="Grade"> (required).</param>
        /// <param name="PointsBalance"> (required).</param>
        public RetrieveAllAccountsSummaryByGradeResponse(string MembershipNo = null, int? CardNo = null, int? GradeId = null, string Grade = null, int? PointsBalance = null)
        {
            // to ensure "MembershipNo" is required (not null)
            if (MembershipNo == null)
            {
                throw new InvalidDataException("MembershipNo is a required property for RetrieveAllAccountsSummaryByGradeResponse and cannot be null");
            }
            else
            {
                this.MembershipNo = MembershipNo;
            }
            // to ensure "CardNo" is required (not null)
            if (CardNo == null)
            {
                throw new InvalidDataException("CardNo is a required property for RetrieveAllAccountsSummaryByGradeResponse and cannot be null");
            }
            else
            {
                this.CardNo = CardNo;
            }
            // to ensure "GradeId" is required (not null)
            if (GradeId == null)
            {
                throw new InvalidDataException("GradeId is a required property for RetrieveAllAccountsSummaryByGradeResponse and cannot be null");
            }
            else
            {
                this.GradeId = GradeId;
            }
            // to ensure "Grade" is required (not null)
            if (Grade == null)
            {
                throw new InvalidDataException("Grade is a required property for RetrieveAllAccountsSummaryByGradeResponse and cannot be null");
            }
            else
            {
                this.Grade = Grade;
            }
            // to ensure "PointsBalance" is required (not null)
            if (PointsBalance == null)
            {
                throw new InvalidDataException("PointsBalance is a required property for RetrieveAllAccountsSummaryByGradeResponse and cannot be null");
            }
            else
            {
                this.PointsBalance = PointsBalance;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="MembershipNo")]
        public string MembershipNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CardNo")]
        public int? CardNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="GradeId")]
        public int? GradeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="PointsBalance")]
        public int? PointsBalance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveAllAccountsSummaryByGradeResponse {\n");
            sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
            sb.Append("  CardNo: ").Append(CardNo).Append("\n");
            sb.Append("  GradeId: ").Append(GradeId).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  PointsBalance: ").Append(PointsBalance).Append("\n");
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
            return Equals((RetrieveAllAccountsSummaryByGradeResponse)obj);
        }

        /// <summary>
        /// Returns true if RetrieveAllAccountsSummaryByGradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RetrieveAllAccountsSummaryByGradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveAllAccountsSummaryByGradeResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    this.GradeId == other.GradeId ||
                    this.GradeId != null &&
                    this.GradeId.Equals(other.GradeId)
                ) && 
                (
                    this.Grade == other.Grade ||
                    this.Grade != null &&
                    this.Grade.Equals(other.Grade)
                ) && 
                (
                    this.PointsBalance == other.PointsBalance ||
                    this.PointsBalance != null &&
                    this.PointsBalance.Equals(other.PointsBalance)
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
                if (this.MembershipNo != null)
                    hash = hash * 59 + this.MembershipNo.GetHashCode();
                if (this.CardNo != null)
                    hash = hash * 59 + this.CardNo.GetHashCode();
                if (this.GradeId != null)
                    hash = hash * 59 + this.GradeId.GetHashCode();
                if (this.Grade != null)
                    hash = hash * 59 + this.Grade.GetHashCode();
                if (this.PointsBalance != null)
                    hash = hash * 59 + this.PointsBalance.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(RetrieveAllAccountsSummaryByGradeResponse left, RetrieveAllAccountsSummaryByGradeResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RetrieveAllAccountsSummaryByGradeResponse left, RetrieveAllAccountsSummaryByGradeResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
