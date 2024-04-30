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
    /// The result of the user creation operation.
    /// </summary>
    [DataContract(Name = "createUser_request_identities_inner")]
    public partial class CreateUserRequestIdentitiesInner : IValidatableObject
    {
        /// <summary>
        /// The type of identity to create, for e.g. email.
        /// </summary>
        /// <value>The type of identity to create, for e.g. email.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Username for value: username
            /// </summary>
            [EnumMember(Value = "username")]
            Username = 2
        }


        /// <summary>
        /// The type of identity to create, for e.g. email.
        /// </summary>
        /// <value>The type of identity to create, for e.g. email.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestIdentitiesInner" /> class.
        /// </summary>
        /// <param name="type">The type of identity to create, for e.g. email..</param>
        /// <param name="details">details.</param>
        public CreateUserRequestIdentitiesInner(TypeEnum? type = default(TypeEnum?), CreateUserRequestIdentitiesInnerDetails details = default(CreateUserRequestIdentitiesInnerDetails))
        {
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public CreateUserRequestIdentitiesInnerDetails Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserRequestIdentitiesInner {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
