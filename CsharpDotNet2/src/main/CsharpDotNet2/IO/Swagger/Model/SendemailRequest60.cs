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
  public class SendemailRequest60 {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DynamicFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DynamicFields")]
    public Object DynamicFields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SendemailRequest60 {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DynamicFields: ").Append(DynamicFields).Append("\n");
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
