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
    /// BusinessLayerAdminEmpresasHelpersCreateSucursalRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasHelpersCreateSucursalRequest :  IEquatable<BusinessLayerAdminEmpresasHelpersCreateSucursalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasHelpersCreateSucursalRequest" /> class.
        /// </summary>
        /// <param name="sucursalNombre">sucursalNombre.</param>
        /// <param name="sucursalNombreComercial">sucursalNombreComercial.</param>
        /// <param name="sucursalDireccion">sucursalDireccion.</param>
        /// <param name="sucursalDireccionRef">sucursalDireccionRef.</param>
        /// <param name="sucursalTelefono">sucursalTelefono.</param>
        /// <param name="sucursalMovil">sucursalMovil.</param>
        /// <param name="sucursalEmail">sucursalEmail.</param>
        /// <param name="sucursalLogo">sucursalLogo.</param>
        /// <param name="sucursalParroquiaId">sucursalParroquiaId.</param>
        /// <param name="sucursalActiva">sucursalActiva.</param>
        /// <param name="sucursalMatriz">sucursalMatriz.</param>
        /// <param name="sucursalObservaciones">sucursalObservaciones.</param>
        /// <param name="sucursalEmpresaId">sucursalEmpresaId.</param>
        public BusinessLayerAdminEmpresasHelpersCreateSucursalRequest(string sucursalNombre = default(string), string sucursalNombreComercial = default(string), string sucursalDireccion = default(string), string sucursalDireccionRef = default(string), string sucursalTelefono = default(string), string sucursalMovil = default(string), string sucursalEmail = default(string), byte[] sucursalLogo = default(byte[]), string sucursalParroquiaId = default(string), bool? sucursalActiva = default(bool?), bool? sucursalMatriz = default(bool?), string sucursalObservaciones = default(string), int? sucursalEmpresaId = default(int?))
        {
            this.sucursal_nombre = sucursalNombre;
            this.sucursal_nombre_comercial = sucursalNombreComercial;
            this.sucursal_direccion = sucursalDireccion;
            this.sucursal_direccion_ref = sucursalDireccionRef;
            this.sucursal_telefono = sucursalTelefono;
            this.sucursal_movil = sucursalMovil;
            this.sucursal_email = sucursalEmail;
            this.sucursal_logo = sucursalLogo;
            this.sucursal_parroquia_id = sucursalParroquiaId;
            this.sucursal_activa = sucursalActiva;
            this.sucursal_matriz = sucursalMatriz;
            this.sucursal_observaciones = sucursalObservaciones;
            this.sucursal_empresa_id = sucursalEmpresaId;
        }
        
        /// <summary>
        /// Gets or Sets sucursal_nombre
        /// </summary>
        [DataMember(Name="sucursal_nombre", EmitDefaultValue=false)]
        public string sucursal_nombre { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_nombre_comercial
        /// </summary>
        [DataMember(Name="sucursal_nombre_comercial", EmitDefaultValue=false)]
        public string sucursal_nombre_comercial { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_direccion
        /// </summary>
        [DataMember(Name="sucursal_direccion", EmitDefaultValue=false)]
        public string sucursal_direccion { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_direccion_ref
        /// </summary>
        [DataMember(Name="sucursal_direccion_ref", EmitDefaultValue=false)]
        public string sucursal_direccion_ref { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_telefono
        /// </summary>
        [DataMember(Name="sucursal_telefono", EmitDefaultValue=false)]
        public string sucursal_telefono { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_movil
        /// </summary>
        [DataMember(Name="sucursal_movil", EmitDefaultValue=false)]
        public string sucursal_movil { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_email
        /// </summary>
        [DataMember(Name="sucursal_email", EmitDefaultValue=false)]
        public string sucursal_email { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_logo
        /// </summary>
        [DataMember(Name="sucursal_logo", EmitDefaultValue=false)]
        public byte[] sucursal_logo { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_parroquia_id
        /// </summary>
        [DataMember(Name="sucursal_parroquia_id", EmitDefaultValue=false)]
        public string sucursal_parroquia_id { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_activa
        /// </summary>
        [DataMember(Name="sucursal_activa", EmitDefaultValue=false)]
        public bool? sucursal_activa { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_matriz
        /// </summary>
        [DataMember(Name="sucursal_matriz", EmitDefaultValue=false)]
        public bool? sucursal_matriz { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_observaciones
        /// </summary>
        [DataMember(Name="sucursal_observaciones", EmitDefaultValue=false)]
        public string sucursal_observaciones { get; set; }

        /// <summary>
        /// Gets or Sets sucursal_empresa_id
        /// </summary>
        [DataMember(Name="sucursal_empresa_id", EmitDefaultValue=false)]
        public int? sucursal_empresa_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerAdminEmpresasHelpersCreateSucursalRequest {\n");
            sb.Append("  sucursal_nombre: ").Append(sucursal_nombre).Append("\n");
            sb.Append("  sucursal_nombre_comercial: ").Append(sucursal_nombre_comercial).Append("\n");
            sb.Append("  sucursal_direccion: ").Append(sucursal_direccion).Append("\n");
            sb.Append("  sucursal_direccion_ref: ").Append(sucursal_direccion_ref).Append("\n");
            sb.Append("  sucursal_telefono: ").Append(sucursal_telefono).Append("\n");
            sb.Append("  sucursal_movil: ").Append(sucursal_movil).Append("\n");
            sb.Append("  sucursal_email: ").Append(sucursal_email).Append("\n");
            sb.Append("  sucursal_logo: ").Append(sucursal_logo).Append("\n");
            sb.Append("  sucursal_parroquia_id: ").Append(sucursal_parroquia_id).Append("\n");
            sb.Append("  sucursal_activa: ").Append(sucursal_activa).Append("\n");
            sb.Append("  sucursal_matriz: ").Append(sucursal_matriz).Append("\n");
            sb.Append("  sucursal_observaciones: ").Append(sucursal_observaciones).Append("\n");
            sb.Append("  sucursal_empresa_id: ").Append(sucursal_empresa_id).Append("\n");
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
            return this.Equals(input as BusinessLayerAdminEmpresasHelpersCreateSucursalRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasHelpersCreateSucursalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasHelpersCreateSucursalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasHelpersCreateSucursalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sucursal_nombre == input.sucursal_nombre ||
                    (this.sucursal_nombre != null &&
                    this.sucursal_nombre.Equals(input.sucursal_nombre))
                ) && 
                (
                    this.sucursal_nombre_comercial == input.sucursal_nombre_comercial ||
                    (this.sucursal_nombre_comercial != null &&
                    this.sucursal_nombre_comercial.Equals(input.sucursal_nombre_comercial))
                ) && 
                (
                    this.sucursal_direccion == input.sucursal_direccion ||
                    (this.sucursal_direccion != null &&
                    this.sucursal_direccion.Equals(input.sucursal_direccion))
                ) && 
                (
                    this.sucursal_direccion_ref == input.sucursal_direccion_ref ||
                    (this.sucursal_direccion_ref != null &&
                    this.sucursal_direccion_ref.Equals(input.sucursal_direccion_ref))
                ) && 
                (
                    this.sucursal_telefono == input.sucursal_telefono ||
                    (this.sucursal_telefono != null &&
                    this.sucursal_telefono.Equals(input.sucursal_telefono))
                ) && 
                (
                    this.sucursal_movil == input.sucursal_movil ||
                    (this.sucursal_movil != null &&
                    this.sucursal_movil.Equals(input.sucursal_movil))
                ) && 
                (
                    this.sucursal_email == input.sucursal_email ||
                    (this.sucursal_email != null &&
                    this.sucursal_email.Equals(input.sucursal_email))
                ) && 
                (
                    this.sucursal_logo == input.sucursal_logo ||
                    (this.sucursal_logo != null &&
                    this.sucursal_logo.Equals(input.sucursal_logo))
                ) && 
                (
                    this.sucursal_parroquia_id == input.sucursal_parroquia_id ||
                    (this.sucursal_parroquia_id != null &&
                    this.sucursal_parroquia_id.Equals(input.sucursal_parroquia_id))
                ) && 
                (
                    this.sucursal_activa == input.sucursal_activa ||
                    (this.sucursal_activa != null &&
                    this.sucursal_activa.Equals(input.sucursal_activa))
                ) && 
                (
                    this.sucursal_matriz == input.sucursal_matriz ||
                    (this.sucursal_matriz != null &&
                    this.sucursal_matriz.Equals(input.sucursal_matriz))
                ) && 
                (
                    this.sucursal_observaciones == input.sucursal_observaciones ||
                    (this.sucursal_observaciones != null &&
                    this.sucursal_observaciones.Equals(input.sucursal_observaciones))
                ) && 
                (
                    this.sucursal_empresa_id == input.sucursal_empresa_id ||
                    (this.sucursal_empresa_id != null &&
                    this.sucursal_empresa_id.Equals(input.sucursal_empresa_id))
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
                if (this.sucursal_nombre != null)
                    hashCode = hashCode * 59 + this.sucursal_nombre.GetHashCode();
                if (this.sucursal_nombre_comercial != null)
                    hashCode = hashCode * 59 + this.sucursal_nombre_comercial.GetHashCode();
                if (this.sucursal_direccion != null)
                    hashCode = hashCode * 59 + this.sucursal_direccion.GetHashCode();
                if (this.sucursal_direccion_ref != null)
                    hashCode = hashCode * 59 + this.sucursal_direccion_ref.GetHashCode();
                if (this.sucursal_telefono != null)
                    hashCode = hashCode * 59 + this.sucursal_telefono.GetHashCode();
                if (this.sucursal_movil != null)
                    hashCode = hashCode * 59 + this.sucursal_movil.GetHashCode();
                if (this.sucursal_email != null)
                    hashCode = hashCode * 59 + this.sucursal_email.GetHashCode();
                if (this.sucursal_logo != null)
                    hashCode = hashCode * 59 + this.sucursal_logo.GetHashCode();
                if (this.sucursal_parroquia_id != null)
                    hashCode = hashCode * 59 + this.sucursal_parroquia_id.GetHashCode();
                if (this.sucursal_activa != null)
                    hashCode = hashCode * 59 + this.sucursal_activa.GetHashCode();
                if (this.sucursal_matriz != null)
                    hashCode = hashCode * 59 + this.sucursal_matriz.GetHashCode();
                if (this.sucursal_observaciones != null)
                    hashCode = hashCode * 59 + this.sucursal_observaciones.GetHashCode();
                if (this.sucursal_empresa_id != null)
                    hashCode = hashCode * 59 + this.sucursal_empresa_id.GetHashCode();
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
