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
  public class LookupResponse2 {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public Object Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address")]
    public Object Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="TelephoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TelephoneNumber")]
    public string TelephoneNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="MobileNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MobileNumber")]
    public string MobileNumber { get; set; }

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
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Club", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Club")]
    public Object Club { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="AffId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AffId")]
    public string AffId { get; set; }

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
    [DataMember(Name="IsAlreadyUsedOnDigital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAlreadyUsedOnDigital")]
    public bool? IsAlreadyUsedOnDigital { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LookupResponse2 {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
      sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  Club: ").Append(Club).Append("\n");
      sb.Append("  AffId: ").Append(AffId).Append("\n");
      sb.Append("  MembershipNo: ").Append(MembershipNo).Append("\n");
      sb.Append("  CardNo: ").Append(CardNo).Append("\n");
      sb.Append("  IsAlreadyUsedOnDigital: ").Append(IsAlreadyUsedOnDigital).Append("\n");
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
