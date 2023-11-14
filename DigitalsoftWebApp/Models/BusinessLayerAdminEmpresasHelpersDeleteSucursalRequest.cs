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
    /// BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest :  IEquatable<BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest" /> class.
        /// </summary>
        /// <param name="sucursalId">sucursalId.</param>
        public BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest(int? sucursalId = default(int?))
        {
            this.sucursal_id = sucursalId;
        }
        
        /// <summary>
        /// Gets or Sets sucursal_id
        /// </summary>
        [DataMember(Name="sucursal_id", EmitDefaultValue=false)]
        public int? sucursal_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest {\n");
            sb.Append("  sucursal_id: ").Append(sucursal_id).Append("\n");
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
            return this.Equals(input as BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasHelpersDeleteSucursalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sucursal_id == input.sucursal_id ||
                    (this.sucursal_id != null &&
                    this.sucursal_id.Equals(input.sucursal_id))
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
                if (this.sucursal_id != null)
                    hashCode = hashCode * 59 + this.sucursal_id.GetHashCode();
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