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
  public class AccrueLoyaltyPointsRequest {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CardNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CardNo")]
    public int? CardNo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="LocationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocationId")]
    public string LocationId { get; set; }

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
    [DataMember(Name="TransDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransDateTime")]
    public string TransDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccrueLoyaltyPointsRequest {\n");
      sb.Append("  CardNo: ").Append(CardNo).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  Points: ").Append(Points).Append("\n");
      sb.Append("  TransDateTime: ").Append(TransDateTime).Append("\n");
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
