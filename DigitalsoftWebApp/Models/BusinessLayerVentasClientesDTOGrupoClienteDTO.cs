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
    /// BusinessLayerVentasClientesDTOGrupoClienteDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerVentasClientesDTOGrupoClienteDTO :  IEquatable<BusinessLayerVentasClientesDTOGrupoClienteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerVentasClientesDTOGrupoClienteDTO" /> class.
        /// </summary>
        /// <param name="grupoId">grupoId.</param>
        /// <param name="grupoNombre">grupoNombre.</param>
        /// <param name="grupoActivo">grupoActivo.</param>
        /// <param name="empresaId">empresaId.</param>
        /// <param name="empresaPertenece">empresaPertenece.</param>
        public BusinessLayerVentasClientesDTOGrupoClienteDTO(int? grupoId = default(int?), string grupoNombre = default(string), bool? grupoActivo = default(bool?), int? empresaId = default(int?), BusinessLayerAdminEmpresasDTOEmpresaDTO empresaPertenece = default(BusinessLayerAdminEmpresasDTOEmpresaDTO))
        {
            this.grupo_id = grupoId;
            this.grupo_nombre = grupoNombre;
            this.grupo_activo = grupoActivo;
            this.empresa_id = empresaId;
            this.empresa_pertenece = empresaPertenece;
        }
        
        /// <summary>
        /// Gets or Sets grupo_id
        /// </summary>
        [DataMember(Name="grupo_id", EmitDefaultValue=false)]
        public int? grupo_id { get; set; }

        /// <summary>
        /// Gets or Sets grupo_nombre
        /// </summary>
        [DataMember(Name="grupo_nombre", EmitDefaultValue=false)]
        public string grupo_nombre { get; set; }

        /// <summary>
        /// Gets or Sets grupo_activo
        /// </summary>
        [DataMember(Name="grupo_activo", EmitDefaultValue=false)]
        public bool? grupo_activo { get; set; }

        /// <summary>
        /// Gets or Sets empresa_id
        /// </summary>
        [DataMember(Name="empresa_id", EmitDefaultValue=false)]
        public int? empresa_id { get; set; }

        /// <summary>
        /// Gets or Sets empresa_pertenece
        /// </summary>
        [DataMember(Name="empresa_pertenece", EmitDefaultValue=false)]
        public BusinessLayerAdminEmpresasDTOEmpresaDTO empresa_pertenece { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerVentasClientesDTOGrupoClienteDTO {\n");
            sb.Append("  grupo_id: ").Append(grupo_id).Append("\n");
            sb.Append("  grupo_nombre: ").Append(grupo_nombre).Append("\n");
            sb.Append("  grupo_activo: ").Append(grupo_activo).Append("\n");
            sb.Append("  empresa_id: ").Append(empresa_id).Append("\n");
            sb.Append("  empresa_pertenece: ").Append(empresa_pertenece).Append("\n");
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
            return this.Equals(input as BusinessLayerVentasClientesDTOGrupoClienteDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerVentasClientesDTOGrupoClienteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerVentasClientesDTOGrupoClienteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerVentasClientesDTOGrupoClienteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.grupo_id == input.grupo_id ||
                    (this.grupo_id != null &&
                    this.grupo_id.Equals(input.grupo_id))
                ) && 
                (
                    this.grupo_nombre == input.grupo_nombre ||
                    (this.grupo_nombre != null &&
                    this.grupo_nombre.Equals(input.grupo_nombre))
                ) && 
                (
                    this.grupo_activo == input.grupo_activo ||
                    (this.grupo_activo != null &&
                    this.grupo_activo.Equals(input.grupo_activo))
                ) && 
                (
                    this.empresa_id == input.empresa_id ||
                    (this.empresa_id != null &&
                    this.empresa_id.Equals(input.empresa_id))
                ) && 
                (
                    this.empresa_pertenece == input.empresa_pertenece ||
                    (this.empresa_pertenece != null &&
                    this.empresa_pertenece.Equals(input.empresa_pertenece))
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
                if (this.grupo_id != null)
                    hashCode = hashCode * 59 + this.grupo_id.GetHashCode();
                if (this.grupo_nombre != null)
                    hashCode = hashCode * 59 + this.grupo_nombre.GetHashCode();
                if (this.grupo_activo != null)
                    hashCode = hashCode * 59 + this.grupo_activo.GetHashCode();
                if (this.empresa_id != null)
                    hashCode = hashCode * 59 + this.empresa_id.GetHashCode();
                if (this.empresa_pertenece != null)
                    hashCode = hashCode * 59 + this.empresa_pertenece.GetHashCode();
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