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
    /// BusinessLayerCommonDTORegimenTributarioDTO
    /// </summary>
    [DataContract]
    public partial class BusinessLayerCommonDTORegimenTributarioDTO : IEquatable<BusinessLayerCommonDTORegimenTributarioDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCommonDTORegimenTributarioDTO" /> class.
        /// </summary>
        /// <param name="regimenId">regimenId.</param>
        /// <param name="regimenNombre">regimenNombre.</param>
        /// <param name="regimenCodigoInterno">regimenCodigoInterno.</param>
        /// <param name="regimenActivo">regimenActivo.</param>
        public BusinessLayerCommonDTORegimenTributarioDTO(int? regimenId = default(int?), string regimenNombre = default(string), string regimenCodigoInterno = default(string), bool? regimenActivo = default(bool?))
        {
            this.regimen_id = regimenId;
            this.regimen_nombre = regimenNombre;
            this.regimen_codigo_interno = regimenCodigoInterno;
            this.regimen_activo = regimenActivo;
        }
        public BusinessLayerCommonDTORegimenTributarioDTO()
        {
        }

        /// <summary>
        /// Gets or Sets regimen_id
        /// </summary>
        [DataMember(Name="regimen_id", EmitDefaultValue=false)]
        public int? regimen_id { get; set; }

        /// <summary>
        /// Gets or Sets regimen_nombre
        /// </summary>
        [DataMember(Name="regimen_nombre", EmitDefaultValue=false)]
        public string regimen_nombre { get; set; }

        /// <summary>
        /// Gets or Sets regimen_codigo_interno
        /// </summary>
        [DataMember(Name="regimen_codigo_interno", EmitDefaultValue=false)]
        public string regimen_codigo_interno { get; set; }

        /// <summary>
        /// Gets or Sets regimen_activo
        /// </summary>
        [DataMember(Name="regimen_activo", EmitDefaultValue=false)]
        public bool? regimen_activo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCommonDTORegimenTributarioDTO {\n");
            sb.Append("  regimen_id: ").Append(regimen_id).Append("\n");
            sb.Append("  regimen_nombre: ").Append(regimen_nombre).Append("\n");
            sb.Append("  regimen_codigo_interno: ").Append(regimen_codigo_interno).Append("\n");
            sb.Append("  regimen_activo: ").Append(regimen_activo).Append("\n");
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
            return this.Equals(input as BusinessLayerCommonDTORegimenTributarioDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCommonDTORegimenTributarioDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCommonDTORegimenTributarioDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCommonDTORegimenTributarioDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.regimen_id == input.regimen_id ||
                    (this.regimen_id != null &&
                    this.regimen_id.Equals(input.regimen_id))
                ) && 
                (
                    this.regimen_nombre == input.regimen_nombre ||
                    (this.regimen_nombre != null &&
                    this.regimen_nombre.Equals(input.regimen_nombre))
                ) && 
                (
                    this.regimen_codigo_interno == input.regimen_codigo_interno ||
                    (this.regimen_codigo_interno != null &&
                    this.regimen_codigo_interno.Equals(input.regimen_codigo_interno))
                ) && 
                (
                    this.regimen_activo == input.regimen_activo ||
                    (this.regimen_activo != null &&
                    this.regimen_activo.Equals(input.regimen_activo))
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
                if (this.regimen_id != null)
                    hashCode = hashCode * 59 + this.regimen_id.GetHashCode();
                if (this.regimen_nombre != null)
                    hashCode = hashCode * 59 + this.regimen_nombre.GetHashCode();
                if (this.regimen_codigo_interno != null)
                    hashCode = hashCode * 59 + this.regimen_codigo_interno.GetHashCode();
                if (this.regimen_activo != null)
                    hashCode = hashCode * 59 + this.regimen_activo.GetHashCode();
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