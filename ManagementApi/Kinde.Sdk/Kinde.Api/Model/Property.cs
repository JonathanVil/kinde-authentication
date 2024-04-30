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
    /// Property
    /// </summary>
    [DataContract(Name = "property")]
    public partial class Property : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key.</param>
        /// <param name="name">name.</param>
        /// <param name="isPrivate">isPrivate.</param>
        /// <param name="description">description.</param>
        /// <param name="isKindeProperty">isKindeProperty.</param>
        public Property(string id = default(string), string key = default(string), string name = default(string), bool isPrivate = default(bool), string description = default(string), bool isKindeProperty = default(bool))
        {
            this.Id = id;
            this.Key = key;
            this.Name = name;
            this.IsPrivate = isPrivate;
            this.Description = description;
            this.IsKindeProperty = isKindeProperty;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name = "is_private", EmitDefaultValue = true)]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IsKindeProperty
        /// </summary>
        [DataMember(Name = "is_kinde_property", EmitDefaultValue = true)]
        public bool IsKindeProperty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Property {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsKindeProperty: ").Append(IsKindeProperty).Append("\n");
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
