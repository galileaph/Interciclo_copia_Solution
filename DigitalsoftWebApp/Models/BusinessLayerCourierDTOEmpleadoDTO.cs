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
    /// BusinessLayerCourierDTOEmpleadoDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOEmpleadoDTO :  IEquatable<BusinessLayerCourierDTOEmpleadoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOEmpleadoDTO" /> class.
        /// </summary>
        /// <param name="strCedulaRuc">strCedulaRuc.</param>
        /// <param name="strNombres">strNombres.</param>
        /// <param name="strApellidos">strApellidos.</param>
        /// <param name="strDireccion">strDireccion.</param>
        /// <param name="strIdsexo">strIdsexo.</param>
        /// <param name="strTelefono">strTelefono.</param>
        /// <param name="strMovil">strMovil.</param>
        /// <param name="strEmail">strEmail.</param>
        /// <param name="imgFoto">imgFoto.</param>
        /// <param name="strCargo">strCargo.</param>
        /// <param name="dtFechaIngreso">dtFechaIngreso.</param>
        /// <param name="dtFechaEgreso">dtFechaEgreso.</param>
        /// <param name="strObservaciones">strObservaciones.</param>
        /// <param name="blnActivo">blnActivo.</param>
        /// <param name="strAgenciaPertenece">strAgenciaPertenece.</param>
        /// <param name="idestadoCivil">idestadoCivil.</param>
        /// <param name="empleadoEsAgente">empleadoEsAgente.</param>
        /// <param name="agenciaPertenece">agenciaPertenece.</param>
        public BusinessLayerCourierDTOEmpleadoDTO(string strCedulaRuc = default(string), string strNombres = default(string), string strApellidos = default(string), string strDireccion = default(string), string strIdsexo = default(string), string strTelefono = default(string), string strMovil = default(string), string strEmail = default(string), byte[] imgFoto = default(byte[]), string strCargo = default(string), DateTime? dtFechaIngreso = default(DateTime?), DateTime? dtFechaEgreso = default(DateTime?), string strObservaciones = default(string), bool? blnActivo = default(bool?), string strAgenciaPertenece = default(string), string idestadoCivil = default(string), bool? empleadoEsAgente = default(bool?), BusinessLayerCourierDTOAgenciaDTO agenciaPertenece = default(BusinessLayerCourierDTOAgenciaDTO))
        {
            this.str_cedula_ruc = strCedulaRuc;
            this.str_nombres = strNombres;
            this.str_apellidos = strApellidos;
            this.str_direccion = strDireccion;
            this.str_idsexo = strIdsexo;
            this.str_telefono = strTelefono;
            this.str_movil = strMovil;
            this.str_email = strEmail;
            this.img_foto = imgFoto;
            this.str_cargo = strCargo;
            this.dt_fecha_ingreso = dtFechaIngreso;
            this.dt_fecha_egreso = dtFechaEgreso;
            this.str_observaciones = strObservaciones;
            this.bln_activo = blnActivo;
            this.str_agencia_pertenece = strAgenciaPertenece;
            this.idestado_civil = idestadoCivil;
            this.empleado_es_agente = empleadoEsAgente;
            this.agencia_pertenece = agenciaPertenece;
        }
        
        /// <summary>
        /// Gets or Sets str_cedula_ruc
        /// </summary>
        [DataMember(Name="strCedulaRuc", EmitDefaultValue=false)]
        public string str_cedula_ruc { get; set; }

        /// <summary>
        /// Gets or Sets str_nombres
        /// </summary>
        [DataMember(Name="strNombres", EmitDefaultValue=false)]
        public string str_nombres { get; set; }

        /// <summary>
        /// Gets or Sets str_apellidos
        /// </summary>
        [DataMember(Name="strApellidos", EmitDefaultValue=false)]
        public string str_apellidos { get; set; }

        /// <summary>
        /// Gets or Sets str_direccion
        /// </summary>
        [DataMember(Name="strDireccion", EmitDefaultValue=false)]
        public string str_direccion { get; set; }

        /// <summary>
        /// Gets or Sets str_idsexo
        /// </summary>
        [DataMember(Name="strIdsexo", EmitDefaultValue=false)]
        public string str_idsexo { get; set; }

        /// <summary>
        /// Gets or Sets str_telefono
        /// </summary>
        [DataMember(Name="strTelefono", EmitDefaultValue=false)]
        public string str_telefono { get; set; }

        /// <summary>
        /// Gets or Sets str_movil
        /// </summary>
        [DataMember(Name="strMovil", EmitDefaultValue=false)]
        public string str_movil { get; set; }

        /// <summary>
        /// Gets or Sets str_email
        /// </summary>
        [DataMember(Name="strEmail", EmitDefaultValue=false)]
        public string str_email { get; set; }

        /// <summary>
        /// Gets or Sets img_foto
        /// </summary>
        [DataMember(Name="imgFoto", EmitDefaultValue=false)]
        public byte[] img_foto { get; set; }

        /// <summary>
        /// Gets or Sets str_cargo
        /// </summary>
        [DataMember(Name="strCargo", EmitDefaultValue=false)]
        public string str_cargo { get; set; }

        /// <summary>
        /// Gets or Sets dt_fecha_ingreso
        /// </summary>
        [DataMember(Name="dtFechaIngreso", EmitDefaultValue=false)]
        public DateTime? dt_fecha_ingreso { get; set; }

        /// <summary>
        /// Gets or Sets dt_fecha_egreso
        /// </summary>
        [DataMember(Name="dtFechaEgreso", EmitDefaultValue=false)]
        public DateTime? dt_fecha_egreso { get; set; }

        /// <summary>
        /// Gets or Sets str_observaciones
        /// </summary>
        [DataMember(Name="strObservaciones", EmitDefaultValue=false)]
        public string str_observaciones { get; set; }

        /// <summary>
        /// Gets or Sets bln_activo
        /// </summary>
        [DataMember(Name="blnActivo", EmitDefaultValue=false)]
        public bool? bln_activo { get; set; }

        /// <summary>
        /// Gets or Sets str_agencia_pertenece
        /// </summary>
        [DataMember(Name="strAgenciaPertenece", EmitDefaultValue=false)]
        public string str_agencia_pertenece { get; set; }

        /// <summary>
        /// Gets or Sets idestado_civil
        /// </summary>
        [DataMember(Name="idestadoCivil", EmitDefaultValue=false)]
        public string idestado_civil { get; set; }

        /// <summary>
        /// Gets or Sets empleado_es_agente
        /// </summary>
        [DataMember(Name="empleadoEsAgente", EmitDefaultValue=false)]
        public bool? empleado_es_agente { get; set; }

        /// <summary>
        /// Gets or Sets agencia_pertenece
        /// </summary>
        [DataMember(Name="agenciaPertenece", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOAgenciaDTO agencia_pertenece { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOEmpleadoDTO {\n");
            sb.Append("  str_cedula_ruc: ").Append(str_cedula_ruc).Append("\n");
            sb.Append("  str_nombres: ").Append(str_nombres).Append("\n");
            sb.Append("  str_apellidos: ").Append(str_apellidos).Append("\n");
            sb.Append("  str_direccion: ").Append(str_direccion).Append("\n");
            sb.Append("  str_idsexo: ").Append(str_idsexo).Append("\n");
            sb.Append("  str_telefono: ").Append(str_telefono).Append("\n");
            sb.Append("  str_movil: ").Append(str_movil).Append("\n");
            sb.Append("  str_email: ").Append(str_email).Append("\n");
            sb.Append("  img_foto: ").Append(img_foto).Append("\n");
            sb.Append("  str_cargo: ").Append(str_cargo).Append("\n");
            sb.Append("  dt_fecha_ingreso: ").Append(dt_fecha_ingreso).Append("\n");
            sb.Append("  dt_fecha_egreso: ").Append(dt_fecha_egreso).Append("\n");
            sb.Append("  str_observaciones: ").Append(str_observaciones).Append("\n");
            sb.Append("  bln_activo: ").Append(bln_activo).Append("\n");
            sb.Append("  str_agencia_pertenece: ").Append(str_agencia_pertenece).Append("\n");
            sb.Append("  idestado_civil: ").Append(idestado_civil).Append("\n");
            sb.Append("  empleado_es_agente: ").Append(empleado_es_agente).Append("\n");
            sb.Append("  agencia_pertenece: ").Append(agencia_pertenece).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOEmpleadoDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOEmpleadoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOEmpleadoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOEmpleadoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.str_cedula_ruc == input.str_cedula_ruc ||
                    (this.str_cedula_ruc != null &&
                    this.str_cedula_ruc.Equals(input.str_cedula_ruc))
                ) && 
                (
                    this.str_nombres == input.str_nombres ||
                    (this.str_nombres != null &&
                    this.str_nombres.Equals(input.str_nombres))
                ) && 
                (
                    this.str_apellidos == input.str_apellidos ||
                    (this.str_apellidos != null &&
                    this.str_apellidos.Equals(input.str_apellidos))
                ) && 
                (
                    this.str_direccion == input.str_direccion ||
                    (this.str_direccion != null &&
                    this.str_direccion.Equals(input.str_direccion))
                ) && 
                (
                    this.str_idsexo == input.str_idsexo ||
                    (this.str_idsexo != null &&
                    this.str_idsexo.Equals(input.str_idsexo))
                ) && 
                (
                    this.str_telefono == input.str_telefono ||
                    (this.str_telefono != null &&
                    this.str_telefono.Equals(input.str_telefono))
                ) && 
                (
                    this.str_movil == input.str_movil ||
                    (this.str_movil != null &&
                    this.str_movil.Equals(input.str_movil))
                ) && 
                (
                    this.str_email == input.str_email ||
                    (this.str_email != null &&
                    this.str_email.Equals(input.str_email))
                ) && 
                (
                    this.img_foto == input.img_foto ||
                    (this.img_foto != null &&
                    this.img_foto.Equals(input.img_foto))
                ) && 
                (
                    this.str_cargo == input.str_cargo ||
                    (this.str_cargo != null &&
                    this.str_cargo.Equals(input.str_cargo))
                ) && 
                (
                    this.dt_fecha_ingreso == input.dt_fecha_ingreso ||
                    (this.dt_fecha_ingreso != null &&
                    this.dt_fecha_ingreso.Equals(input.dt_fecha_ingreso))
                ) && 
                (
                    this.dt_fecha_egreso == input.dt_fecha_egreso ||
                    (this.dt_fecha_egreso != null &&
                    this.dt_fecha_egreso.Equals(input.dt_fecha_egreso))
                ) && 
                (
                    this.str_observaciones == input.str_observaciones ||
                    (this.str_observaciones != null &&
                    this.str_observaciones.Equals(input.str_observaciones))
                ) && 
                (
                    this.bln_activo == input.bln_activo ||
                    (this.bln_activo != null &&
                    this.bln_activo.Equals(input.bln_activo))
                ) && 
                (
                    this.str_agencia_pertenece == input.str_agencia_pertenece ||
                    (this.str_agencia_pertenece != null &&
                    this.str_agencia_pertenece.Equals(input.str_agencia_pertenece))
                ) && 
                (
                    this.idestado_civil == input.idestado_civil ||
                    (this.idestado_civil != null &&
                    this.idestado_civil.Equals(input.idestado_civil))
                ) && 
                (
                    this.empleado_es_agente == input.empleado_es_agente ||
                    (this.empleado_es_agente != null &&
                    this.empleado_es_agente.Equals(input.empleado_es_agente))
                ) && 
                (
                    this.agencia_pertenece == input.agencia_pertenece ||
                    (this.agencia_pertenece != null &&
                    this.agencia_pertenece.Equals(input.agencia_pertenece))
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
                if (this.str_cedula_ruc != null)
                    hashCode = hashCode * 59 + this.str_cedula_ruc.GetHashCode();
                if (this.str_nombres != null)
                    hashCode = hashCode * 59 + this.str_nombres.GetHashCode();
                if (this.str_apellidos != null)
                    hashCode = hashCode * 59 + this.str_apellidos.GetHashCode();
                if (this.str_direccion != null)
                    hashCode = hashCode * 59 + this.str_direccion.GetHashCode();
                if (this.str_idsexo != null)
                    hashCode = hashCode * 59 + this.str_idsexo.GetHashCode();
                if (this.str_telefono != null)
                    hashCode = hashCode * 59 + this.str_telefono.GetHashCode();
                if (this.str_movil != null)
                    hashCode = hashCode * 59 + this.str_movil.GetHashCode();
                if (this.str_email != null)
                    hashCode = hashCode * 59 + this.str_email.GetHashCode();
                if (this.img_foto != null)
                    hashCode = hashCode * 59 + this.img_foto.GetHashCode();
                if (this.str_cargo != null)
                    hashCode = hashCode * 59 + this.str_cargo.GetHashCode();
                if (this.dt_fecha_ingreso != null)
                    hashCode = hashCode * 59 + this.dt_fecha_ingreso.GetHashCode();
                if (this.dt_fecha_egreso != null)
                    hashCode = hashCode * 59 + this.dt_fecha_egreso.GetHashCode();
                if (this.str_observaciones != null)
                    hashCode = hashCode * 59 + this.str_observaciones.GetHashCode();
                if (this.bln_activo != null)
                    hashCode = hashCode * 59 + this.bln_activo.GetHashCode();
                if (this.str_agencia_pertenece != null)
                    hashCode = hashCode * 59 + this.str_agencia_pertenece.GetHashCode();
                if (this.idestado_civil != null)
                    hashCode = hashCode * 59 + this.idestado_civil.GetHashCode();
                if (this.empleado_es_agente != null)
                    hashCode = hashCode * 59 + this.empleado_es_agente.GetHashCode();
                if (this.agencia_pertenece != null)
                    hashCode = hashCode * 59 + this.agencia_pertenece.GetHashCode();
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