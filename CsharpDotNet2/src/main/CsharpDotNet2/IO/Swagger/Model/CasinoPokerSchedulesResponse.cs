using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CasinoPokerSchedulesResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CasinoNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CasinoNumber")]
    public int? CasinoNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Day")]
    public string Day { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartDate")]
    public string StartDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndDate")]
    public string EndDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Game", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Game")]
    public string Game { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="GameType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GameType")]
    public string GameType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Stake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Stake")]
    public int? Stake { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StartingStake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartingStake")]
    public string StartingStake { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RegFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegFee")]
    public int? RegFee { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartTime")]
    public string StartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
