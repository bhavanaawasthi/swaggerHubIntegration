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
  public class GetLookupValuesResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Nationalities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Nationalities")]
    public List<Object> Nationalities { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Countries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Countries")]
    public List<Object> Countries { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Casinos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Casinos")]
    public List<Object> Casinos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Titles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Titles")]
    public List<Object> Titles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetLookupValuesResponse {\n");
      sb.Append("  Nationalities: ").Append(Nationalities).Append("\n");
      sb.Append("  Countries: ").Append(Countries).Append("\n");
      sb.Append("  Casinos: ").Append(Casinos).Append("\n");
      sb.Append("  Titles: ").Append(Titles).Append("\n");
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
