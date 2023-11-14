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
    /// BusinessLayerAdminEmpresasHelpersListEmpresasRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasHelpersListEmpresasRequest :  IEquatable<BusinessLayerAdminEmpresasHelpersListEmpresasRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasHelpersListEmpresasRequest" /> class.
        /// </summary>
        /// <param name="filtro">filtro.</param>
        /// <param name="activa">activa.</param>
        public BusinessLayerAdminEmpresasHelpersListEmpresasRequest(string filtro = default(string), bool? activa = default(bool?))
        {
            this.filtro = filtro;
            this.activa = activa;
        }
        
        /// <summary>
        /// Gets or Sets filtro
        /// </summary>
        [DataMember(Name="filtro", EmitDefaultValue=false)]
        public string filtro { get; set; }

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
            sb.Append("class BusinessLayerAdminEmpresasHelpersListEmpresasRequest {\n");
            sb.Append("  filtro: ").Append(filtro).Append("\n");
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
            return this.Equals(input as BusinessLayerAdminEmpresasHelpersListEmpresasRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasHelpersListEmpresasRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasHelpersListEmpresasRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasHelpersListEmpresasRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.filtro == input.filtro ||
                    (this.filtro != null &&
                    this.filtro.Equals(input.filtro))
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
                if (this.filtro != null)
                    hashCode = hashCode * 59 + this.filtro.GetHashCode();
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