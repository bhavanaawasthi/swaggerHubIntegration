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
  public class RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MiddleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MiddleName")]
    public string MiddleName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateOfBirth")]
    public string DateOfBirth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="IsVip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVip")]
    public bool? IsVip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rank")]
    public int? Rank { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RetrievesCustomerDetailsByTheSpecifiedCardNumberResponse {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  IsVip: ").Append(IsVip).Append("\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
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
