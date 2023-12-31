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
    /// BusinessLayerCourierDTOClienteExteriorDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOClienteExteriorDTO :  IEquatable<BusinessLayerCourierDTOClienteExteriorDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOClienteExteriorDTO" /> class.
        /// </summary>
        /// <param name="idcliente">idcliente.</param>
        /// <param name="cedulaRucpassport">cedulaRucpassport.</param>
        /// <param name="idconsular">idconsular.</param>
        /// <param name="apellidosNombresCliente">apellidosNombresCliente.</param>
        /// <param name="direccionCliente">direccionCliente.</param>
        /// <param name="telefonoCliente">telefonoCliente.</param>
        /// <param name="idciudad">idciudad.</param>
        /// <param name="idzipCode">idzipCode.</param>
        /// <param name="email">email.</param>
        public BusinessLayerCourierDTOClienteExteriorDTO(long? idcliente = default(long?), string cedulaRucpassport = default(string), string idconsular = default(string), string apellidosNombresCliente = default(string), string direccionCliente = default(string), string telefonoCliente = default(string), string idciudad = default(string), long? idzipCode = default(long?), string email = default(string))
        {
            this.idcliente = idcliente;
            this.cedula_rucpassport = cedulaRucpassport;
            this.idconsular = idconsular;
            this.apellidos_nombres_cliente = apellidosNombresCliente;
            this.direccion_cliente = direccionCliente;
            this.telefono_cliente = telefonoCliente;
            this.idciudad = idciudad;
            this.idzip_code = idzipCode;
            this.email = email;
        }
        
        /// <summary>
        /// Gets or Sets idcliente
        /// </summary>
        [DataMember(Name="idcliente", EmitDefaultValue=false)]
        public long? idcliente { get; set; }

        /// <summary>
        /// Gets or Sets cedula_rucpassport
        /// </summary>
        [DataMember(Name="cedulaRucpassport", EmitDefaultValue=false)]
        public string cedula_rucpassport { get; set; }

        /// <summary>
        /// Gets or Sets idconsular
        /// </summary>
        [DataMember(Name="idconsular", EmitDefaultValue=false)]
        public string idconsular { get; set; }

        /// <summary>
        /// Gets or Sets apellidos_nombres_cliente
        /// </summary>
        [DataMember(Name="apellidosNombresCliente", EmitDefaultValue=false)]
        public string apellidos_nombres_cliente { get; set; }

        /// <summary>
        /// Gets or Sets direccion_cliente
        /// </summary>
        [DataMember(Name="direccionCliente", EmitDefaultValue=false)]
        public string direccion_cliente { get; set; }

        /// <summary>
        /// Gets or Sets telefono_cliente
        /// </summary>
        [DataMember(Name="telefonoCliente", EmitDefaultValue=false)]
        public string telefono_cliente { get; set; }

        /// <summary>
        /// Gets or Sets idciudad
        /// </summary>
        [DataMember(Name="idciudad", EmitDefaultValue=false)]
        public string idciudad { get; set; }

        /// <summary>
        /// Gets or Sets idzip_code
        /// </summary>
        [DataMember(Name="idzipCode", EmitDefaultValue=false)]
        public long? idzip_code { get; set; }

        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOClienteExteriorDTO {\n");
            sb.Append("  idcliente: ").Append(idcliente).Append("\n");
            sb.Append("  cedula_rucpassport: ").Append(cedula_rucpassport).Append("\n");
            sb.Append("  idconsular: ").Append(idconsular).Append("\n");
            sb.Append("  apellidos_nombres_cliente: ").Append(apellidos_nombres_cliente).Append("\n");
            sb.Append("  direccion_cliente: ").Append(direccion_cliente).Append("\n");
            sb.Append("  telefono_cliente: ").Append(telefono_cliente).Append("\n");
            sb.Append("  idciudad: ").Append(idciudad).Append("\n");
            sb.Append("  idzip_code: ").Append(idzip_code).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOClienteExteriorDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOClienteExteriorDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOClienteExteriorDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOClienteExteriorDTO input)
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
                    this.cedula_rucpassport == input.cedula_rucpassport ||
                    (this.cedula_rucpassport != null &&
                    this.cedula_rucpassport.Equals(input.cedula_rucpassport))
                ) && 
                (
                    this.idconsular == input.idconsular ||
                    (this.idconsular != null &&
                    this.idconsular.Equals(input.idconsular))
                ) && 
                (
                    this.apellidos_nombres_cliente == input.apellidos_nombres_cliente ||
                    (this.apellidos_nombres_cliente != null &&
                    this.apellidos_nombres_cliente.Equals(input.apellidos_nombres_cliente))
                ) && 
                (
                    this.direccion_cliente == input.direccion_cliente ||
                    (this.direccion_cliente != null &&
                    this.direccion_cliente.Equals(input.direccion_cliente))
                ) && 
                (
                    this.telefono_cliente == input.telefono_cliente ||
                    (this.telefono_cliente != null &&
                    this.telefono_cliente.Equals(input.telefono_cliente))
                ) && 
                (
                    this.idciudad == input.idciudad ||
                    (this.idciudad != null &&
                    this.idciudad.Equals(input.idciudad))
                ) && 
                (
                    this.idzip_code == input.idzip_code ||
                    (this.idzip_code != null &&
                    this.idzip_code.Equals(input.idzip_code))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
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
                if (this.cedula_rucpassport != null)
                    hashCode = hashCode * 59 + this.cedula_rucpassport.GetHashCode();
                if (this.idconsular != null)
                    hashCode = hashCode * 59 + this.idconsular.GetHashCode();
                if (this.apellidos_nombres_cliente != null)
                    hashCode = hashCode * 59 + this.apellidos_nombres_cliente.GetHashCode();
                if (this.direccion_cliente != null)
                    hashCode = hashCode * 59 + this.direccion_cliente.GetHashCode();
                if (this.telefono_cliente != null)
                    hashCode = hashCode * 59 + this.telefono_cliente.GetHashCode();
                if (this.idciudad != null)
                    hashCode = hashCode * 59 + this.idciudad.GetHashCode();
                if (this.idzip_code != null)
                    hashCode = hashCode * 59 + this.idzip_code.GetHashCode();
                if (this.email != null)
                    hashCode = hashCode * 59 + this.email.GetHashCode();
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
