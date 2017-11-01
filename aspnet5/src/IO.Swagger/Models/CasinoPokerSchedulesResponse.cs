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
    public partial class CasinoPokerSchedulesResponse :  IEquatable<CasinoPokerSchedulesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CasinoPokerSchedulesResponse" /> class.
        /// </summary>
        /// <param name="CasinoNumber"> (required).</param>
        /// <param name="Day"> (required).</param>
        /// <param name="StartDate"> (required).</param>
        /// <param name="EndDate"> (required).</param>
        /// <param name="Game"> (required).</param>
        /// <param name="GameType"> (required).</param>
        /// <param name="Stake"> (required).</param>
        /// <param name="StartingStake"> (required).</param>
        /// <param name="RegFee">.</param>
        /// <param name="StartTime">.</param>
        public CasinoPokerSchedulesResponse(int? CasinoNumber = null, string Day = null, string StartDate = null, string EndDate = null, string Game = null, string GameType = null, int? Stake = null, string StartingStake = null, int? RegFee = null, string StartTime = null)
        {
            // to ensure "CasinoNumber" is required (not null)
            if (CasinoNumber == null)
            {
                throw new InvalidDataException("CasinoNumber is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.CasinoNumber = CasinoNumber;
            }
            // to ensure "Day" is required (not null)
            if (Day == null)
            {
                throw new InvalidDataException("Day is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.Day = Day;
            }
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            // to ensure "EndDate" is required (not null)
            if (EndDate == null)
            {
                throw new InvalidDataException("EndDate is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.EndDate = EndDate;
            }
            // to ensure "Game" is required (not null)
            if (Game == null)
            {
                throw new InvalidDataException("Game is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.Game = Game;
            }
            // to ensure "GameType" is required (not null)
            if (GameType == null)
            {
                throw new InvalidDataException("GameType is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.GameType = GameType;
            }
            // to ensure "Stake" is required (not null)
            if (Stake == null)
            {
                throw new InvalidDataException("Stake is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.Stake = Stake;
            }
            // to ensure "StartingStake" is required (not null)
            if (StartingStake == null)
            {
                throw new InvalidDataException("StartingStake is a required property for CasinoPokerSchedulesResponse and cannot be null");
            }
            else
            {
                this.StartingStake = StartingStake;
            }
            this.RegFee = RegFee;
            this.StartTime = StartTime;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="CasinoNumber")]
        public int? CasinoNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Day")]
        public string Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="StartDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="EndDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Game")]
        public string Game { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="GameType")]
        public string GameType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="Stake")]
        public int? Stake { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="StartingStake")]
        public string StartingStake { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="RegFee")]
        public int? RegFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="StartTime")]
        public string StartTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CasinoPokerSchedulesResponse {\n");
            sb.Append("  CasinoNumber: ").Append(CasinoNumber).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Game: ").Append(Game).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  Stake: ").Append(Stake).Append("\n");
            sb.Append("  StartingStake: ").Append(StartingStake).Append("\n");
            sb.Append("  RegFee: ").Append(RegFee).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return Equals((CasinoPokerSchedulesResponse)obj);
        }

        /// <summary>
        /// Returns true if CasinoPokerSchedulesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CasinoPokerSchedulesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CasinoPokerSchedulesResponse other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CasinoNumber == other.CasinoNumber ||
                    this.CasinoNumber != null &&
                    this.CasinoNumber.Equals(other.CasinoNumber)
                ) && 
                (
                    this.Day == other.Day ||
                    this.Day != null &&
                    this.Day.Equals(other.Day)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Game == other.Game ||
                    this.Game != null &&
                    this.Game.Equals(other.Game)
                ) && 
                (
                    this.GameType == other.GameType ||
                    this.GameType != null &&
                    this.GameType.Equals(other.GameType)
                ) && 
                (
                    this.Stake == other.Stake ||
                    this.Stake != null &&
                    this.Stake.Equals(other.Stake)
                ) && 
                (
                    this.StartingStake == other.StartingStake ||
                    this.StartingStake != null &&
                    this.StartingStake.Equals(other.StartingStake)
                ) && 
                (
                    this.RegFee == other.RegFee ||
                    this.RegFee != null &&
                    this.RegFee.Equals(other.RegFee)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
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
                if (this.CasinoNumber != null)
                    hash = hash * 59 + this.CasinoNumber.GetHashCode();
                if (this.Day != null)
                    hash = hash * 59 + this.Day.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Game != null)
                    hash = hash * 59 + this.Game.GetHashCode();
                if (this.GameType != null)
                    hash = hash * 59 + this.GameType.GetHashCode();
                if (this.Stake != null)
                    hash = hash * 59 + this.Stake.GetHashCode();
                if (this.StartingStake != null)
                    hash = hash * 59 + this.StartingStake.GetHashCode();
                if (this.RegFee != null)
                    hash = hash * 59 + this.RegFee.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(CasinoPokerSchedulesResponse left, CasinoPokerSchedulesResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CasinoPokerSchedulesResponse left, CasinoPokerSchedulesResponse right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
