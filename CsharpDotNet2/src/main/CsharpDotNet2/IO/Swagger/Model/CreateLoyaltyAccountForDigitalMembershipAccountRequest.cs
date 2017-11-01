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
  public class CreateLoyaltyAccountForDigitalMembershipAccountRequest {
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
    [DataMember(Name="Forename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Forename")]
    public string Forename { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Surname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Surname")]
    public string Surname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateOfBirth")]
    public string DateOfBirth { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateLoyaltyAccountForDigitalMembershipAccountRequest {\n");
      sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
      sb.Append("  Forename: ").Append(Forename).Append("\n");
      sb.Append("  Surname: ").Append(Surname).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
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
