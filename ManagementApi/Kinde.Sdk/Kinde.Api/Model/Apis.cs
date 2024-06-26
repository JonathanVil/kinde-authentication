/*
 * Kinde Management API
 *
 * Provides endpoints to manage your Kinde Businesses
 *
 * The version of the OpenAPI document: 1
 * Contact: support@kinde.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Kinde.Api.Client.FileParameter;
using OpenAPIDateConverter = Kinde.Api.Client.OpenAPIDateConverter;

namespace Kinde.Api.Model
{
    /// <summary>
    /// Apis
    /// </summary>
    [DataContract(Name = "apis")]
    public partial class Apis : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apis" /> class.
        /// </summary>
        /// <param name="id">Unique id of the API..</param>
        /// <param name="name">The API&#39;s name..</param>
        /// <param name="audience">The logical identifier for the API..</param>
        /// <param name="isManagementApi">Whether it is the management API or not..</param>
        public Apis(string id = default(string), string name = default(string), string audience = default(string), bool isManagementApi = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.Audience = audience;
            this.IsManagementApi = isManagementApi;
        }

        /// <summary>
        /// Unique id of the API.
        /// </summary>
        /// <value>Unique id of the API.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The API&#39;s name.
        /// </summary>
        /// <value>The API&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The logical identifier for the API.
        /// </summary>
        /// <value>The logical identifier for the API.</value>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Whether it is the management API or not.
        /// </summary>
        /// <value>Whether it is the management API or not.</value>
        [DataMember(Name = "is_management_api", EmitDefaultValue = true)]
        public bool IsManagementApi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Apis {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  IsManagementApi: ").Append(IsManagementApi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
