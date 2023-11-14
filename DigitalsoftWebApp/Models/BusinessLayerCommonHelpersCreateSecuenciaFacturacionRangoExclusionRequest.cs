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
    /// BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest :  IEquatable<BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest" /> class.
        /// </summary>
        /// <param name="rangoDesde">rangoDesde.</param>
        /// <param name="rangoHasta">rangoHasta.</param>
        /// <param name="rangoObservaciones">rangoObservaciones.</param>
        /// <param name="secuenciaId">secuenciaId.</param>
        public BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest(long? rangoDesde = default(long?), long? rangoHasta = default(long?), string rangoObservaciones = default(string), int? secuenciaId = default(int?))
        {
            this.rango_desde = rangoDesde;
            this.rango_hasta = rangoHasta;
            this.rango_observaciones = rangoObservaciones;
            this.secuencia_id = secuenciaId;
        }
        
        /// <summary>
        /// Gets or Sets rango_desde
        /// </summary>
        [DataMember(Name="rango_desde", EmitDefaultValue=false)]
        public long? rango_desde { get; set; }

        /// <summary>
        /// Gets or Sets rango_hasta
        /// </summary>
        [DataMember(Name="rango_hasta", EmitDefaultValue=false)]
        public long? rango_hasta { get; set; }

        /// <summary>
        /// Gets or Sets rango_observaciones
        /// </summary>
        [DataMember(Name="rango_observaciones", EmitDefaultValue=false)]
        public string rango_observaciones { get; set; }

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
            sb.Append("class BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest {\n");
            sb.Append("  rango_desde: ").Append(rango_desde).Append("\n");
            sb.Append("  rango_hasta: ").Append(rango_hasta).Append("\n");
            sb.Append("  rango_observaciones: ").Append(rango_observaciones).Append("\n");
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
            return this.Equals(input as BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCommonHelpersCreateSecuenciaFacturacionRangoExclusionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.rango_desde == input.rango_desde ||
                    (this.rango_desde != null &&
                    this.rango_desde.Equals(input.rango_desde))
                ) && 
                (
                    this.rango_hasta == input.rango_hasta ||
                    (this.rango_hasta != null &&
                    this.rango_hasta.Equals(input.rango_hasta))
                ) && 
                (
                    this.rango_observaciones == input.rango_observaciones ||
                    (this.rango_observaciones != null &&
                    this.rango_observaciones.Equals(input.rango_observaciones))
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
                if (this.rango_desde != null)
                    hashCode = hashCode * 59 + this.rango_desde.GetHashCode();
                if (this.rango_hasta != null)
                    hashCode = hashCode * 59 + this.rango_hasta.GetHashCode();
                if (this.rango_observaciones != null)
                    hashCode = hashCode * 59 + this.rango_observaciones.GetHashCode();
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