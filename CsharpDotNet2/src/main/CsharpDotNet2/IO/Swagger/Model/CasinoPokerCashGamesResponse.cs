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
  public class CasinoPokerCashGamesResponse {
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
    [DataMember(Name="Start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Start")]
    public string Start { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="End", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "End")]
    public string End { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="NumberOfGames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfGames")]
    public int? NumberOfGames { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StakeFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StakeFrom")]
    public string StakeFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="StakeTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StakeTo")]
    public string StakeTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BlindsFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BlindsFrom")]
    public string BlindsFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BlindsTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BlindsTo")]
    public string BlindsTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SessionOrRake", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionOrRake")]
    public string SessionOrRake { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CasinoPokerCashGamesResponse {\n");
      sb.Append("  CasinoNumber: ").Append(CasinoNumber).Append("\n");
      sb.Append("  Day: ").Append(Day).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  End: ").Append(End).Append("\n");
      sb.Append("  NumberOfGames: ").Append(NumberOfGames).Append("\n");
      sb.Append("  StakeFrom: ").Append(StakeFrom).Append("\n");
      sb.Append("  StakeTo: ").Append(StakeTo).Append("\n");
      sb.Append("  BlindsFrom: ").Append(BlindsFrom).Append("\n");
      sb.Append("  BlindsTo: ").Append(BlindsTo).Append("\n");
      sb.Append("  SessionOrRake: ").Append(SessionOrRake).Append("\n");
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
