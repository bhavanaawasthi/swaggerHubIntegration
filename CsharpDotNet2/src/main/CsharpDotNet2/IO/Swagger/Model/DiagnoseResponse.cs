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
  public class DiagnoseResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Azure Table Storage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Azure Table Storage")]
    public string Azure Table Storage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Membership DB", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Membership DB")]
    public string Membership DB { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Spine REST API", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Spine REST API")]
    public string Spine REST API { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Bally XML API", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Bally XML API")]
    public string Bally XML API { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiagnoseResponse {\n");
      sb.Append("  Azure Table Storage: ").Append(Azure Table Storage).Append("\n");
      sb.Append("  Membership DB: ").Append(Membership DB).Append("\n");
      sb.Append("  Spine REST API: ").Append(Spine REST API).Append("\n");
      sb.Append("  Bally XML API: ").Append(Bally XML API).Append("\n");
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
