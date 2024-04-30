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
    /// UserProfile
    /// </summary>
    [DataContract(Name = "user_profile")]
    public partial class UserProfile : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfile" /> class.
        /// </summary>
        /// <param name="id">Unique id of the user in Kinde..</param>
        /// <param name="preferredEmail">Default email address of the user in Kinde..</param>
        /// <param name="username">Primary username of the user in Kinde..</param>
        /// <param name="providedId">Value of the user&#39;s id in a third-party system when the user is imported into Kinde..</param>
        /// <param name="lastName">User&#39;s last name..</param>
        /// <param name="firstName">User&#39;s first name..</param>
        /// <param name="picture">URL that point&#39;s to the user&#39;s picture or avatar.</param>
        public UserProfile(string id = default(string), string preferredEmail = default(string), string username = default(string), string providedId = default(string), string lastName = default(string), string firstName = default(string), string picture = default(string))
        {
            this.Id = id;
            this.PreferredEmail = preferredEmail;
            this.Username = username;
            this.ProvidedId = providedId;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Picture = picture;
        }

        /// <summary>
        /// Unique id of the user in Kinde.
        /// </summary>
        /// <value>Unique id of the user in Kinde.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Default email address of the user in Kinde.
        /// </summary>
        /// <value>Default email address of the user in Kinde.</value>
        [DataMember(Name = "preferred_email", EmitDefaultValue = false)]
        public string PreferredEmail { get; set; }

        /// <summary>
        /// Primary username of the user in Kinde.
        /// </summary>
        /// <value>Primary username of the user in Kinde.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Value of the user&#39;s id in a third-party system when the user is imported into Kinde.
        /// </summary>
        /// <value>Value of the user&#39;s id in a third-party system when the user is imported into Kinde.</value>
        [DataMember(Name = "provided_id", EmitDefaultValue = true)]
        public string ProvidedId { get; set; }

        /// <summary>
        /// User&#39;s last name.
        /// </summary>
        /// <value>User&#39;s last name.</value>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// User&#39;s first name.
        /// </summary>
        /// <value>User&#39;s first name.</value>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// URL that point&#39;s to the user&#39;s picture or avatar
        /// </summary>
        /// <value>URL that point&#39;s to the user&#39;s picture or avatar</value>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PreferredEmail: ").Append(PreferredEmail).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  ProvidedId: ").Append(ProvidedId).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
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
