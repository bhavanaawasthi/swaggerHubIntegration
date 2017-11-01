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
  public class MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Request {
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
    [DataMember(Name="MembershipNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MembershipNo")]
    public string MembershipNo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MergeExistingDigitalAndRetailLoyaltyAccountsFlavour1Request {\n");
      sb.Append("  PlayerId: ").Append(PlayerId).Append("\n");
      sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
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
