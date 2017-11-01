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
  public class CasinoEventsResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CasinoNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CasinoNumber")]
    public int? CasinoNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="CategoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CategoryId")]
    public int? CategoryId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public string Category { get; set; }

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
    [DataMember(Name="ValidFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValidFrom")]
    public string ValidFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ValidTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValidTo")]
    public string ValidTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ImageUrl")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EventSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventSchedule")]
    public Object EventSchedule { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EventStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventStartTime")]
    public string EventStartTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="EventFacebookUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventFacebookUrl")]
    public string EventFacebookUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CasinoEventsResponse {\n");
      sb.Append("  CasinoNumber: ").Append(CasinoNumber).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
      sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EventSchedule: ").Append(EventSchedule).Append("\n");
      sb.Append("  EventStartTime: ").Append(EventStartTime).Append("\n");
      sb.Append("  EventFacebookUrl: ").Append(EventFacebookUrl).Append("\n");
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
