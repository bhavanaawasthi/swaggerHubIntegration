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
  public class RetrievePointsBalanceResponse17 {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="pointsBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pointsBalance")]
    public int? PointsBalance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="grade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grade")]
    public string Grade { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RetrievePointsBalanceResponse17 {\n");
      sb.Append("  PointsBalance: ").Append(PointsBalance).Append("\n");
      sb.Append("  Grade: ").Append(Grade).Append("\n");
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
