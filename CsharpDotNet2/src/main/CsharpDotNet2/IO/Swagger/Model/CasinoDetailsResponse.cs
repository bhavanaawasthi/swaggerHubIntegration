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
  public class CasinoDetailsResponse {
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
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

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
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public string Location { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneNumber")]
    public string PhoneNumber { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CasinoManager", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CasinoManager")]
    public Object CasinoManager { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="SocialNetworkLinks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SocialNetworkLinks")]
    public Object SocialNetworkLinks { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AboutCasino", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AboutCasino")]
    public string AboutCasino { get; set; }

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
    [DataMember(Name="Facilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Facilities")]
    public Object Facilities { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="OpeningTimes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpeningTimes")]
    public Object OpeningTimes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Games", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Games")]
    public Object Games { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="PanoramaUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PanoramaUrl")]
    public string PanoramaUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="BookATableConnectionDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BookATableConnectionDetails")]
    public Object BookATableConnectionDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CasinoDetailsResponse {\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Postcode: ").Append(Postcode).Append("\n");
      sb.Append("  Town: ").Append(Town).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  RegionName: ").Append(RegionName).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  CasinoManager: ").Append(CasinoManager).Append("\n");
      sb.Append("  SocialNetworkLinks: ").Append(SocialNetworkLinks).Append("\n");
      sb.Append("  AboutCasino: ").Append(AboutCasino).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Facilities: ").Append(Facilities).Append("\n");
      sb.Append("  OpeningTimes: ").Append(OpeningTimes).Append("\n");
      sb.Append("  Games: ").Append(Games).Append("\n");
      sb.Append("  PanoramaUrl: ").Append(PanoramaUrl).Append("\n");
      sb.Append("  BookATableConnectionDetails: ").Append(BookATableConnectionDetails).Append("\n");
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
