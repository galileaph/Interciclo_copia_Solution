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
    /// BusinessLayerCourierDTODireccionDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTODireccionDTO :  IEquatable<BusinessLayerCourierDTODireccionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTODireccionDTO" /> class.
        /// </summary>
        /// <param name="iddireccion">iddireccion.</param>
        /// <param name="direccionLine1">direccionLine1.</param>
        /// <param name="direccionLine2">direccionLine2.</param>
        /// <param name="idciudad">idciudad.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="latitud">latitud.</param>
        /// <param name="longitud">longitud.</param>
        /// <param name="idciudadNavigation">idciudadNavigation.</param>
        public BusinessLayerCourierDTODireccionDTO(long? iddireccion = default(long?), string direccionLine1 = default(string), string direccionLine2 = default(string), string idciudad = default(string), string postalCode = default(string), double? latitud = default(double?), double? longitud = default(double?), BusinessLayerCourierDTOCiudadDTO idciudadNavigation = default(BusinessLayerCourierDTOCiudadDTO))
        {
            this.iddireccion = iddireccion;
            this.direccion_line1 = direccionLine1;
            this.direccion_line2 = direccionLine2;
            this.idciudad = idciudad;
            this.postal_code = postalCode;
            this.latitud = latitud;
            this.longitud = longitud;
            this.idciudad_navigation = idciudadNavigation;
        }
        
        /// <summary>
        /// Gets or Sets iddireccion
        /// </summary>
        [DataMember(Name="iddireccion", EmitDefaultValue=false)]
        public long? iddireccion { get; set; }

        /// <summary>
        /// Gets or Sets direccion_line1
        /// </summary>
        [DataMember(Name="direccionLine1", EmitDefaultValue=false)]
        public string direccion_line1 { get; set; }

        /// <summary>
        /// Gets or Sets direccion_line2
        /// </summary>
        [DataMember(Name="direccionLine2", EmitDefaultValue=false)]
        public string direccion_line2 { get; set; }

        /// <summary>
        /// Gets or Sets idciudad
        /// </summary>
        [DataMember(Name="idciudad", EmitDefaultValue=false)]
        public string idciudad { get; set; }

        /// <summary>
        /// Gets or Sets postal_code
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string postal_code { get; set; }

        /// <summary>
        /// Gets or Sets latitud
        /// </summary>
        [DataMember(Name="latitud", EmitDefaultValue=false)]
        public double? latitud { get; set; }

        /// <summary>
        /// Gets or Sets longitud
        /// </summary>
        [DataMember(Name="longitud", EmitDefaultValue=false)]
        public double? longitud { get; set; }

        /// <summary>
        /// Gets or Sets idciudad_navigation
        /// </summary>
        [DataMember(Name="idciudadNavigation", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOCiudadDTO idciudad_navigation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTODireccionDTO {\n");
            sb.Append("  iddireccion: ").Append(iddireccion).Append("\n");
            sb.Append("  direccion_line1: ").Append(direccion_line1).Append("\n");
            sb.Append("  direccion_line2: ").Append(direccion_line2).Append("\n");
            sb.Append("  idciudad: ").Append(idciudad).Append("\n");
            sb.Append("  postal_code: ").Append(postal_code).Append("\n");
            sb.Append("  latitud: ").Append(latitud).Append("\n");
            sb.Append("  longitud: ").Append(longitud).Append("\n");
            sb.Append("  idciudad_navigation: ").Append(idciudad_navigation).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTODireccionDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTODireccionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTODireccionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTODireccionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.iddireccion == input.iddireccion ||
                    (this.iddireccion != null &&
                    this.iddireccion.Equals(input.iddireccion))
                ) && 
                (
                    this.direccion_line1 == input.direccion_line1 ||
                    (this.direccion_line1 != null &&
                    this.direccion_line1.Equals(input.direccion_line1))
                ) && 
                (
                    this.direccion_line2 == input.direccion_line2 ||
                    (this.direccion_line2 != null &&
                    this.direccion_line2.Equals(input.direccion_line2))
                ) && 
                (
                    this.idciudad == input.idciudad ||
                    (this.idciudad != null &&
                    this.idciudad.Equals(input.idciudad))
                ) && 
                (
                    this.postal_code == input.postal_code ||
                    (this.postal_code != null &&
                    this.postal_code.Equals(input.postal_code))
                ) && 
                (
                    this.latitud == input.latitud ||
                    (this.latitud != null &&
                    this.latitud.Equals(input.latitud))
                ) && 
                (
                    this.longitud == input.longitud ||
                    (this.longitud != null &&
                    this.longitud.Equals(input.longitud))
                ) && 
                (
                    this.idciudad_navigation == input.idciudad_navigation ||
                    (this.idciudad_navigation != null &&
                    this.idciudad_navigation.Equals(input.idciudad_navigation))
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
                if (this.iddireccion != null)
                    hashCode = hashCode * 59 + this.iddireccion.GetHashCode();
                if (this.direccion_line1 != null)
                    hashCode = hashCode * 59 + this.direccion_line1.GetHashCode();
                if (this.direccion_line2 != null)
                    hashCode = hashCode * 59 + this.direccion_line2.GetHashCode();
                if (this.idciudad != null)
                    hashCode = hashCode * 59 + this.idciudad.GetHashCode();
                if (this.postal_code != null)
                    hashCode = hashCode * 59 + this.postal_code.GetHashCode();
                if (this.latitud != null)
                    hashCode = hashCode * 59 + this.latitud.GetHashCode();
                if (this.longitud != null)
                    hashCode = hashCode * 59 + this.longitud.GetHashCode();
                if (this.idciudad_navigation != null)
                    hashCode = hashCode * 59 + this.idciudad_navigation.GetHashCode();
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
