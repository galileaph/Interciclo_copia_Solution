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
    /// BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest :  IEquatable<BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest" /> class.
        /// </summary>
        /// <param name="nroGuia">nroGuia.</param>
        public BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest(string nroGuia = default(string))
        {
            this.nro_guia = nroGuia;
        }
        
        /// <summary>
        /// Gets or Sets nro_guia
        /// </summary>
        [DataMember(Name="nro_guia", EmitDefaultValue=false)]
        public string nro_guia { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest {\n");
            sb.Append("  nro_guia: ").Append(nro_guia).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierHelpersEnvioExteriorFindNroGuiaRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.nro_guia == input.nro_guia ||
                    (this.nro_guia != null &&
                    this.nro_guia.Equals(input.nro_guia))
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
                if (this.nro_guia != null)
                    hashCode = hashCode * 59 + this.nro_guia.GetHashCode();
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
