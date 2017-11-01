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
  public class RedeemLoyaltyPointsRequest38 {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PlayerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlayerId")]
    public int? PlayerId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Points")]
    public int? Points { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RedeemDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RedeemDateTime")]
    public string RedeemDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RedeemLoyaltyPointsRequest38 {\n");
      sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  RedeemDateTime: ").Append(RedeemDateTime).Append("\n");
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
