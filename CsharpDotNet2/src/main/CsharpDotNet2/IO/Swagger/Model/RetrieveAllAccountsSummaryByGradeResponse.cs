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
  public class RetrieveAllAccountsSummaryByGradeResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MembershipNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MembershipNo")]
    public string MembershipNo { get; set; }

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
    [DataMember(Name="GradeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GradeId")]
    public int? GradeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Grade", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Grade")]
    public string Grade { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PointsBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PointsBalance")]
    public int? PointsBalance { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
