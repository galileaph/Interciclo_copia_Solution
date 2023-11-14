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
    /// BusinessLayerCourierDTOClienteDireccionDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOClienteDireccionDTO :  IEquatable<BusinessLayerCourierDTOClienteDireccionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOClienteDireccionDTO" /> class.
        /// </summary>
        /// <param name="idcliente">idcliente.</param>
        /// <param name="iddireccion">iddireccion.</param>
        /// <param name="direccionActiva">direccionActiva.</param>
        /// <param name="idagenciaDefault">idagenciaDefault.</param>
        /// <param name="referencia">referencia.</param>
        /// <param name="agencia">agencia.</param>
        /// <param name="cliente">cliente.</param>
        /// <param name="direccion">direccion.</param>
        public BusinessLayerCourierDTOClienteDireccionDTO(long? idcliente = default(long?), long? iddireccion = default(long?), bool? direccionActiva = default(bool?), string idagenciaDefault = default(string), string referencia = default(string), BusinessLayerCourierDTOAgenciaDTO agencia = default(BusinessLayerCourierDTOAgenciaDTO), BusinessLayerCourierDTOClienteDTO cliente = default(BusinessLayerCourierDTOClienteDTO), BusinessLayerCourierDTODireccionDTO direccion = default(BusinessLayerCourierDTODireccionDTO))
        {
            this.idcliente = idcliente;
            this.iddireccion = iddireccion;
            this.direccion_activa = direccionActiva;
            this.idagencia_default = idagenciaDefault;
            this.referencia = referencia;
            this.agencia = agencia;
            this.cliente = cliente;
            this.direccion = direccion;
        }
        
        /// <summary>
        /// Gets or Sets idcliente
        /// </summary>
        [DataMember(Name="idcliente", EmitDefaultValue=false)]
        public long? idcliente { get; set; }

        /// <summary>
        /// Gets or Sets iddireccion
        /// </summary>
        [DataMember(Name="iddireccion", EmitDefaultValue=false)]
        public long? iddireccion { get; set; }

        /// <summary>
        /// Gets or Sets direccion_activa
        /// </summary>
        [DataMember(Name="direccionActiva", EmitDefaultValue=false)]
        public bool? direccion_activa { get; set; }

        /// <summary>
        /// Gets or Sets idagencia_default
        /// </summary>
        [DataMember(Name="idagenciaDefault", EmitDefaultValue=false)]
        public string idagencia_default { get; set; }

        /// <summary>
        /// Gets or Sets referencia
        /// </summary>
        [DataMember(Name="referencia", EmitDefaultValue=false)]
        public string referencia { get; set; }

        /// <summary>
        /// Gets or Sets agencia
        /// </summary>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOAgenciaDTO agencia { get; set; }

        /// <summary>
        /// Gets or Sets cliente
        /// </summary>
        [DataMember(Name="cliente", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOClienteDTO cliente { get; set; }

        /// <summary>
        /// Gets or Sets direccion
        /// </summary>
        [DataMember(Name="direccion", EmitDefaultValue=false)]
        public BusinessLayerCourierDTODireccionDTO direccion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOClienteDireccionDTO {\n");
            sb.Append("  idcliente: ").Append(idcliente).Append("\n");
            sb.Append("  iddireccion: ").Append(iddireccion).Append("\n");
            sb.Append("  direccion_activa: ").Append(direccion_activa).Append("\n");
            sb.Append("  idagencia_default: ").Append(idagencia_default).Append("\n");
            sb.Append("  referencia: ").Append(referencia).Append("\n");
            sb.Append("  agencia: ").Append(agencia).Append("\n");
            sb.Append("  cliente: ").Append(cliente).Append("\n");
            sb.Append("  direccion: ").Append(direccion).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOClienteDireccionDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOClienteDireccionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOClienteDireccionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOClienteDireccionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.idcliente == input.idcliente ||
                    (this.idcliente != null &&
                    this.idcliente.Equals(input.idcliente))
                ) && 
                (
                    this.iddireccion == input.iddireccion ||
                    (this.iddireccion != null &&
                    this.iddireccion.Equals(input.iddireccion))
                ) && 
                (
                    this.direccion_activa == input.direccion_activa ||
                    (this.direccion_activa != null &&
                    this.direccion_activa.Equals(input.direccion_activa))
                ) && 
                (
                    this.idagencia_default == input.idagencia_default ||
                    (this.idagencia_default != null &&
                    this.idagencia_default.Equals(input.idagencia_default))
                ) && 
                (
                    this.referencia == input.referencia ||
                    (this.referencia != null &&
                    this.referencia.Equals(input.referencia))
                ) && 
                (
                    this.agencia == input.agencia ||
                    (this.agencia != null &&
                    this.agencia.Equals(input.agencia))
                ) && 
                (
                    this.cliente == input.cliente ||
                    (this.cliente != null &&
                    this.cliente.Equals(input.cliente))
                ) && 
                (
                    this.direccion == input.direccion ||
                    (this.direccion != null &&
                    this.direccion.Equals(input.direccion))
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
                if (this.idcliente != null)
                    hashCode = hashCode * 59 + this.idcliente.GetHashCode();
                if (this.iddireccion != null)
                    hashCode = hashCode * 59 + this.iddireccion.GetHashCode();
                if (this.direccion_activa != null)
                    hashCode = hashCode * 59 + this.direccion_activa.GetHashCode();
                if (this.idagencia_default != null)
                    hashCode = hashCode * 59 + this.idagencia_default.GetHashCode();
                if (this.referencia != null)
                    hashCode = hashCode * 59 + this.referencia.GetHashCode();
                if (this.agencia != null)
                    hashCode = hashCode * 59 + this.agencia.GetHashCode();
                if (this.cliente != null)
                    hashCode = hashCode * 59 + this.cliente.GetHashCode();
                if (this.direccion != null)
                    hashCode = hashCode * 59 + this.direccion.GetHashCode();
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
