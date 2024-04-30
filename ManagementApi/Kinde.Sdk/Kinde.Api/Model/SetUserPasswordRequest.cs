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
    /// SetUserPasswordRequest
    /// </summary>
    [DataContract(Name = "SetUserPassword_request")]
    public partial class SetUserPasswordRequest : IValidatableObject
    {
        /// <summary>
        /// The hashing method or algorithm used to encrypt the user’s password. Default is bcrypt.
        /// </summary>
        /// <value>The hashing method or algorithm used to encrypt the user’s password. Default is bcrypt.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HashingMethodEnum
        {
            /// <summary>
            /// Enum Bcrypt for value: bcrypt
            /// </summary>
            [EnumMember(Value = "bcrypt")]
            Bcrypt = 1,

            /// <summary>
            /// Enum Crypt for value: crypt
            /// </summary>
            [EnumMember(Value = "crypt")]
            Crypt = 2,

            /// <summary>
            /// Enum Md5 for value: md5
            /// </summary>
            [EnumMember(Value = "md5")]
            Md5 = 3,

            /// <summary>
            /// Enum Wordpress for value: wordpress
            /// </summary>
            [EnumMember(Value = "wordpress")]
            Wordpress = 4
        }


        /// <summary>
        /// The hashing method or algorithm used to encrypt the user’s password. Default is bcrypt.
        /// </summary>
        /// <value>The hashing method or algorithm used to encrypt the user’s password. Default is bcrypt.</value>
        [DataMember(Name = "hashing_method", EmitDefaultValue = false)]
        public HashingMethodEnum? HashingMethod { get; set; }
        /// <summary>
        /// Position of salt in password string. Not required for bcrypt.
        /// </summary>
        /// <value>Position of salt in password string. Not required for bcrypt.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SaltPositionEnum
        {
            /// <summary>
            /// Enum Prefix for value: prefix
            /// </summary>
            [EnumMember(Value = "prefix")]
            Prefix = 1,

            /// <summary>
            /// Enum Suffix for value: suffix
            /// </summary>
            [EnumMember(Value = "suffix")]
            Suffix = 2
        }


        /// <summary>
        /// Position of salt in password string. Not required for bcrypt.
        /// </summary>
        /// <value>Position of salt in password string. Not required for bcrypt.</value>
        [DataMember(Name = "salt_position", EmitDefaultValue = false)]
        public SaltPositionEnum? SaltPosition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetUserPasswordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        /// <param name="hashedPassword">The hashed password. (required).</param>
        /// <param name="hashingMethod">The hashing method or algorithm used to encrypt the user’s password. Default is bcrypt..</param>
        /// <param name="salt">Extra characters added to passwords to make them stronger. Not required for bcrypt..</param>
        /// <param name="saltPosition">Position of salt in password string. Not required for bcrypt..</param>
        /// <param name="isTemporaryPassword">The user will be prompted to set a new password after entering this one..</param>
        public SetUserPasswordRequest(string hashedPassword = default(string), HashingMethodEnum? hashingMethod = default(HashingMethodEnum?), string salt = default(string), SaltPositionEnum? saltPosition = default(SaltPositionEnum?), bool isTemporaryPassword = default(bool))
        {
            // to ensure "hashedPassword" is required (not null)
            if (hashedPassword == null)
            {
                throw new ArgumentNullException("hashedPassword is a required property for SetUserPasswordRequest and cannot be null");
            }
            this.HashedPassword = hashedPassword;
            this.HashingMethod = hashingMethod;
            this.Salt = salt;
            this.SaltPosition = saltPosition;
            this.IsTemporaryPassword = isTemporaryPassword;
        }

        /// <summary>
        /// The hashed password.
        /// </summary>
        /// <value>The hashed password.</value>
        [DataMember(Name = "hashed_password", IsRequired = true, EmitDefaultValue = true)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// Extra characters added to passwords to make them stronger. Not required for bcrypt.
        /// </summary>
        /// <value>Extra characters added to passwords to make them stronger. Not required for bcrypt.</value>
        [DataMember(Name = "salt", EmitDefaultValue = false)]
        public string Salt { get; set; }

        /// <summary>
        /// The user will be prompted to set a new password after entering this one.
        /// </summary>
        /// <value>The user will be prompted to set a new password after entering this one.</value>
        [DataMember(Name = "is_temporary_password", EmitDefaultValue = true)]
        public bool IsTemporaryPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetUserPasswordRequest {\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
            sb.Append("  HashingMethod: ").Append(HashingMethod).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
            sb.Append("  SaltPosition: ").Append(SaltPosition).Append("\n");
            sb.Append("  IsTemporaryPassword: ").Append(IsTemporaryPassword).Append("\n");
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
