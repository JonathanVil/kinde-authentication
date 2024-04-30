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
    /// CreateApplicationRequest
    /// </summary>
    [DataContract(Name = "createApplication_request")]
    public partial class CreateApplicationRequest : IValidatableObject
    {
        /// <summary>
        /// The application&#39;s type.
        /// </summary>
        /// <value>The application&#39;s type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Reg for value: reg
            /// </summary>
            [EnumMember(Value = "reg")]
            Reg = 1,

            /// <summary>
            /// Enum Spa for value: spa
            /// </summary>
            [EnumMember(Value = "spa")]
            Spa = 2,

            /// <summary>
            /// Enum M2m for value: m2m
            /// </summary>
            [EnumMember(Value = "m2m")]
            M2m = 3
        }


        /// <summary>
        /// The application&#39;s type.
        /// </summary>
        /// <value>The application&#39;s type.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationRequest" /> class.
        /// </summary>
        /// <param name="name">The application&#39;s name..</param>
        /// <param name="type">The application&#39;s type..</param>
        public CreateApplicationRequest(string name = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// The application&#39;s name.
        /// </summary>
        /// <value>The application&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateApplicationRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
