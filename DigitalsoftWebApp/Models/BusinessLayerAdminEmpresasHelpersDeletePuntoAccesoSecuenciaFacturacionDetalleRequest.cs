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
    /// BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest :  IEquatable<BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest" /> class.
        /// </summary>
        /// <param name="puntoId">puntoId.</param>
        /// <param name="puntoSucursalId">puntoSucursalId.</param>
        /// <param name="secuenciaId">secuenciaId.</param>
        public BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest(int? puntoId = default(int?), int? puntoSucursalId = default(int?), int? secuenciaId = default(int?))
        {
            this.punto_id = puntoId;
            this.punto_sucursal_id = puntoSucursalId;
            this.secuencia_id = secuenciaId;
        }
        
        /// <summary>
        /// Gets or Sets punto_id
        /// </summary>
        [DataMember(Name="punto_id", EmitDefaultValue=false)]
        public int? punto_id { get; set; }

        /// <summary>
        /// Gets or Sets punto_sucursal_id
        /// </summary>
        [DataMember(Name="punto_sucursal_id", EmitDefaultValue=false)]
        public int? punto_sucursal_id { get; set; }

        /// <summary>
        /// Gets or Sets secuencia_id
        /// </summary>
        [DataMember(Name="secuencia_id", EmitDefaultValue=false)]
        public int? secuencia_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest {\n");
            sb.Append("  punto_id: ").Append(punto_id).Append("\n");
            sb.Append("  punto_sucursal_id: ").Append(punto_sucursal_id).Append("\n");
            sb.Append("  secuencia_id: ").Append(secuencia_id).Append("\n");
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
            return this.Equals(input as BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasHelpersDeletePuntoAccesoSecuenciaFacturacionDetalleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.punto_id == input.punto_id ||
                    (this.punto_id != null &&
                    this.punto_id.Equals(input.punto_id))
                ) && 
                (
                    this.punto_sucursal_id == input.punto_sucursal_id ||
                    (this.punto_sucursal_id != null &&
                    this.punto_sucursal_id.Equals(input.punto_sucursal_id))
                ) && 
                (
                    this.secuencia_id == input.secuencia_id ||
                    (this.secuencia_id != null &&
                    this.secuencia_id.Equals(input.secuencia_id))
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
                if (this.punto_id != null)
                    hashCode = hashCode * 59 + this.punto_id.GetHashCode();
                if (this.punto_sucursal_id != null)
                    hashCode = hashCode * 59 + this.punto_sucursal_id.GetHashCode();
                if (this.secuencia_id != null)
                    hashCode = hashCode * 59 + this.secuencia_id.GetHashCode();
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
