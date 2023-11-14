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
    /// BusinessLayerAdminEmpresasHelpersListSucursalesRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasHelpersListSucursalesRequest :  IEquatable<BusinessLayerAdminEmpresasHelpersListSucursalesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasHelpersListSucursalesRequest" /> class.
        /// </summary>
        /// <param name="empresaId">empresaId.</param>
        /// <param name="activa">activa.</param>
        public BusinessLayerAdminEmpresasHelpersListSucursalesRequest(int? empresaId = default(int?), bool? activa = default(bool?))
        {
            this.empresa_id = empresaId;
            this.activa = activa;
        }
        
        /// <summary>
        /// Gets or Sets empresa_id
        /// </summary>
        [DataMember(Name="empresa_id", EmitDefaultValue=false)]
        public int? empresa_id { get; set; }

        /// <summary>
        /// Gets or Sets activa
        /// </summary>
        [DataMember(Name="activa", EmitDefaultValue=false)]
        public bool? activa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerAdminEmpresasHelpersListSucursalesRequest {\n");
            sb.Append("  empresa_id: ").Append(empresa_id).Append("\n");
            sb.Append("  activa: ").Append(activa).Append("\n");
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
            return this.Equals(input as BusinessLayerAdminEmpresasHelpersListSucursalesRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasHelpersListSucursalesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasHelpersListSucursalesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasHelpersListSucursalesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.empresa_id == input.empresa_id ||
                    (this.empresa_id != null &&
                    this.empresa_id.Equals(input.empresa_id))
                ) && 
                (
                    this.activa == input.activa ||
                    (this.activa != null &&
                    this.activa.Equals(input.activa))
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
                if (this.empresa_id != null)
                    hashCode = hashCode * 59 + this.empresa_id.GetHashCode();
                if (this.activa != null)
                    hashCode = hashCode * 59 + this.activa.GetHashCode();
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
