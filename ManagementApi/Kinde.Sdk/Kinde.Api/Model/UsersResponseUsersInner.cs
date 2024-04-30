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
    /// UsersResponseUsersInner
    /// </summary>
    [DataContract(Name = "users_response_users_inner")]
    public partial class UsersResponseUsersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersResponseUsersInner" /> class.
        /// </summary>
        /// <param name="id">Unique id of the user in Kinde..</param>
        /// <param name="providedId">External id for user..</param>
        /// <param name="email">Default email address of the user in Kinde..</param>
        /// <param name="username">Primary username of the user in Kinde..</param>
        /// <param name="lastName">User&#39;s last name..</param>
        /// <param name="firstName">User&#39;s first name..</param>
        /// <param name="isSuspended">Whether the user is currently suspended or not..</param>
        /// <param name="picture">User&#39;s profile picture URL..</param>
        /// <param name="totalSignIns">Total number of user sign ins..</param>
        /// <param name="failedSignIns">Number of consecutive failed user sign ins..</param>
        /// <param name="lastSignedIn">Last sign in date in ISO 8601 format..</param>
        /// <param name="createdOn">Date of user creation in ISO 8601 format..</param>
        /// <param name="organizations">Array of organizations a user belongs to..</param>
        /// <param name="identities">Array of identities belonging to the user..</param>
        public UsersResponseUsersInner(string id = default(string), string providedId = default(string), string email = default(string), string username = default(string), string lastName = default(string), string firstName = default(string), bool isSuspended = default(bool), string picture = default(string), int? totalSignIns = default(int?), int? failedSignIns = default(int?), string lastSignedIn = default(string), string createdOn = default(string), List<string> organizations = default(List<string>), List<UserIdentitiesInner> identities = default(List<UserIdentitiesInner>))
        {
            this.Id = id;
            this.ProvidedId = providedId;
            this.Email = email;
            this.Username = username;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.IsSuspended = isSuspended;
            this.Picture = picture;
            this.TotalSignIns = totalSignIns;
            this.FailedSignIns = failedSignIns;
            this.LastSignedIn = lastSignedIn;
            this.CreatedOn = createdOn;
            this.Organizations = organizations;
            this.Identities = identities;
        }

        /// <summary>
        /// Unique id of the user in Kinde.
        /// </summary>
        /// <value>Unique id of the user in Kinde.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// External id for user.
        /// </summary>
        /// <value>External id for user.</value>
        [DataMember(Name = "provided_id", EmitDefaultValue = false)]
        public string ProvidedId { get; set; }

        /// <summary>
        /// Default email address of the user in Kinde.
        /// </summary>
        /// <value>Default email address of the user in Kinde.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Primary username of the user in Kinde.
        /// </summary>
        /// <value>Primary username of the user in Kinde.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

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
        /// Whether the user is currently suspended or not.
        /// </summary>
        /// <value>Whether the user is currently suspended or not.</value>
        [DataMember(Name = "is_suspended", EmitDefaultValue = true)]
        public bool IsSuspended { get; set; }

        /// <summary>
        /// User&#39;s profile picture URL.
        /// </summary>
        /// <value>User&#39;s profile picture URL.</value>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Total number of user sign ins.
        /// </summary>
        /// <value>Total number of user sign ins.</value>
        [DataMember(Name = "total_sign_ins", EmitDefaultValue = true)]
        public int? TotalSignIns { get; set; }

        /// <summary>
        /// Number of consecutive failed user sign ins.
        /// </summary>
        /// <value>Number of consecutive failed user sign ins.</value>
        [DataMember(Name = "failed_sign_ins", EmitDefaultValue = true)]
        public int? FailedSignIns { get; set; }

        /// <summary>
        /// Last sign in date in ISO 8601 format.
        /// </summary>
        /// <value>Last sign in date in ISO 8601 format.</value>
        [DataMember(Name = "last_signed_in", EmitDefaultValue = true)]
        public string LastSignedIn { get; set; }

        /// <summary>
        /// Date of user creation in ISO 8601 format.
        /// </summary>
        /// <value>Date of user creation in ISO 8601 format.</value>
        [DataMember(Name = "created_on", EmitDefaultValue = true)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// Array of organizations a user belongs to.
        /// </summary>
        /// <value>Array of organizations a user belongs to.</value>
        [DataMember(Name = "organizations", EmitDefaultValue = false)]
        public List<string> Organizations { get; set; }

        /// <summary>
        /// Array of identities belonging to the user.
        /// </summary>
        /// <value>Array of identities belonging to the user.</value>
        [DataMember(Name = "identities", EmitDefaultValue = false)]
        public List<UserIdentitiesInner> Identities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsersResponseUsersInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProvidedId: ").Append(ProvidedId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  IsSuspended: ").Append(IsSuspended).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  TotalSignIns: ").Append(TotalSignIns).Append("\n");
            sb.Append("  FailedSignIns: ").Append(FailedSignIns).Append("\n");
            sb.Append("  LastSignedIn: ").Append(LastSignedIn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
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
