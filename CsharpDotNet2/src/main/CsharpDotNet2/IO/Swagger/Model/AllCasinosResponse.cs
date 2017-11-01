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
  public class AllCasinosResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public int? Number { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address")]
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Postcode")]
    public string Postcode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Town", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Town")]
    public string Town { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public string Location { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="RegionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegionName")]
    public string RegionName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Position")]
    public Object Position { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AllCasinosResponse {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Postcode: ").Append(Postcode).Append("\n");
      sb.Append("  Town: ").Append(Town).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  RegionName: ").Append(RegionName).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
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
