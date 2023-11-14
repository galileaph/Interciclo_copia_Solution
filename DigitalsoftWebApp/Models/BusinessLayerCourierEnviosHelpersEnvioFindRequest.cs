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
    /// BusinessLayerCourierEnviosHelpersEnvioFindRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierEnviosHelpersEnvioFindRequest :  IEquatable<BusinessLayerCourierEnviosHelpersEnvioFindRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierEnviosHelpersEnvioFindRequest" /> class.
        /// </summary>
        /// <param name="envioId">envioId.</param>
        /// <param name="sucursalId">sucursalId.</param>
        /// <param name="puntoAccesoId">puntoAccesoId.</param>
        public BusinessLayerCourierEnviosHelpersEnvioFindRequest(long? envioId = default(long?), string sucursalId = default(string), int? puntoAccesoId = default(int?))
        {
            this.envio_id = envioId;
            this.sucursal_id = sucursalId;
            this.punto_acceso_id = puntoAccesoId;
        }
        
        /// <summary>
        /// Gets or Sets envio_id
        /// </summary>
        [DataMember(Name="envio_id", EmitDefaultValue=false)]
        public long? envio_id { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_id
        /// </summary>
        [DataMember(Name="sucursal_id", EmitDefaultValue=false)]
        public string sucursal_id { get; set; }

        /// <summary>
        /// Gets or Sets punto_acceso_id
        /// </summary>
        [DataMember(Name="punto_acceso_id", EmitDefaultValue=false)]
        public int? punto_acceso_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierEnviosHelpersEnvioFindRequest {\n");
            sb.Append("  envio_id: ").Append(envio_id).Append("\n");
            sb.Append("  sucursal_id: ").Append(sucursal_id).Append("\n");
            sb.Append("  punto_acceso_id: ").Append(punto_acceso_id).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierEnviosHelpersEnvioFindRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierEnviosHelpersEnvioFindRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierEnviosHelpersEnvioFindRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierEnviosHelpersEnvioFindRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.envio_id == input.envio_id ||
                    (this.envio_id != null &&
                    this.envio_id.Equals(input.envio_id))
                ) && 
                (
                    this.sucursal_id == input.sucursal_id ||
                    (this.sucursal_id != null &&
                    this.sucursal_id.Equals(input.sucursal_id))
                ) && 
                (
                    this.punto_acceso_id == input.punto_acceso_id ||
                    (this.punto_acceso_id != null &&
                    this.punto_acceso_id.Equals(input.punto_acceso_id))
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
                if (this.envio_id != null)
                    hashCode = hashCode * 59 + this.envio_id.GetHashCode();
                if (this.sucursal_id != null)
                    hashCode = hashCode * 59 + this.sucursal_id.GetHashCode();
                if (this.punto_acceso_id != null)
                    hashCode = hashCode * 59 + this.punto_acceso_id.GetHashCode();
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