/* 
 * API Servicios Integrados InventPro ERP - DigitalsoftEC
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = api.digitalsoftec.net.Client.SwaggerDateConverter;
namespace api.digitalsoftec.net.Model
{
    /// <summary>
    /// BusinessLayerSecurityRoleDeleteRoleRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerSecurityRoleDeleteRoleRequest :  IEquatable<BusinessLayerSecurityRoleDeleteRoleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerSecurityRoleDeleteRoleRequest" /> class.
        /// </summary>
        /// <param name="rolName">rolName.</param>
        public BusinessLayerSecurityRoleDeleteRoleRequest(string rolName = default(string))
        {
            this.rol_name = rolName;
        }
        
        /// <summary>
        /// Gets or Sets rol_name
        /// </summary>
        [DataMember(Name="rolName", EmitDefaultValue=false)]
        public string rol_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerSecurityRoleDeleteRoleRequest {\n");
            sb.Append("  rol_name: ").Append(rol_name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessLayerSecurityRoleDeleteRoleRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerSecurityRoleDeleteRoleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerSecurityRoleDeleteRoleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerSecurityRoleDeleteRoleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.rol_name == input.rol_name ||
                    (this.rol_name != null &&
                    this.rol_name.Equals(input.rol_name))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.rol_name != null)
                    hashCode = hashCode * 59 + this.rol_name.GetHashCode();
                return hashCode;
            }
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