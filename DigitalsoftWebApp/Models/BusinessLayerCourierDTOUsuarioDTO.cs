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
    /// BusinessLayerCourierDTOUsuarioDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOUsuarioDTO :  IEquatable<BusinessLayerCourierDTOUsuarioDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOUsuarioDTO" /> class.
        /// </summary>
        /// <param name="idusuario">idusuario.</param>
        /// <param name="userId">userId.</param>
        /// <param name="password">password.</param>
        /// <param name="usuarioActivo">usuarioActivo.</param>
        /// <param name="campoBiometricoEmpleado">campoBiometricoEmpleado.</param>
        /// <param name="useAlternativeLocation">useAlternativeLocation.</param>
        /// <param name="idusuarioNavigation">idusuarioNavigation.</param>
        public BusinessLayerCourierDTOUsuarioDTO(string idusuario = default(string), string userId = default(string), string password = default(string), bool? usuarioActivo = default(bool?), string campoBiometricoEmpleado = default(string), int? useAlternativeLocation = default(int?), BusinessLayerCourierDTOEmpleadoDTO idusuarioNavigation = default(BusinessLayerCourierDTOEmpleadoDTO))
        {
            this.idusuario = idusuario;
            this.user_id = userId;
            this.password = password;
            this.usuario_activo = usuarioActivo;
            this.campo_biometrico_empleado = campoBiometricoEmpleado;
            this.use_alternative_location = useAlternativeLocation;
            this.idusuario_navigation = idusuarioNavigation;
        }
        
        /// <summary>
        /// Gets or Sets idusuario
        /// </summary>
        [DataMember(Name="idusuario", EmitDefaultValue=false)]
        public string idusuario { get; set; }

        /// <summary>
        /// Gets or Sets user_id
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string user_id { get; set; }

        /// <summary>
        /// Gets or Sets password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string password { get; set; }

        /// <summary>
        /// Gets or Sets usuario_activo
        /// </summary>
        [DataMember(Name="usuarioActivo", EmitDefaultValue=false)]
        public bool? usuario_activo { get; set; }

        /// <summary>
        /// Gets or Sets campo_biometrico_empleado
        /// </summary>
        [DataMember(Name="campoBiometricoEmpleado", EmitDefaultValue=false)]
        public string campo_biometrico_empleado { get; set; }

        /// <summary>
        /// Gets or Sets use_alternative_location
        /// </summary>
        [DataMember(Name="useAlternativeLocation", EmitDefaultValue=false)]
        public int? use_alternative_location { get; set; }

        /// <summary>
        /// Gets or Sets idusuario_navigation
        /// </summary>
        [DataMember(Name="idusuarioNavigation", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOEmpleadoDTO idusuario_navigation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOUsuarioDTO {\n");
            sb.Append("  idusuario: ").Append(idusuario).Append("\n");
            sb.Append("  user_id: ").Append(user_id).Append("\n");
            sb.Append("  password: ").Append(password).Append("\n");
            sb.Append("  usuario_activo: ").Append(usuario_activo).Append("\n");
            sb.Append("  campo_biometrico_empleado: ").Append(campo_biometrico_empleado).Append("\n");
            sb.Append("  use_alternative_location: ").Append(use_alternative_location).Append("\n");
            sb.Append("  idusuario_navigation: ").Append(idusuario_navigation).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOUsuarioDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOUsuarioDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOUsuarioDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOUsuarioDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.idusuario == input.idusuario ||
                    (this.idusuario != null &&
                    this.idusuario.Equals(input.idusuario))
                ) && 
                (
                    this.user_id == input.user_id ||
                    (this.user_id != null &&
                    this.user_id.Equals(input.user_id))
                ) && 
                (
                    this.password == input.password ||
                    (this.password != null &&
                    this.password.Equals(input.password))
                ) && 
                (
                    this.usuario_activo == input.usuario_activo ||
                    (this.usuario_activo != null &&
                    this.usuario_activo.Equals(input.usuario_activo))
                ) && 
                (
                    this.campo_biometrico_empleado == input.campo_biometrico_empleado ||
                    (this.campo_biometrico_empleado != null &&
                    this.campo_biometrico_empleado.Equals(input.campo_biometrico_empleado))
                ) && 
                (
                    this.use_alternative_location == input.use_alternative_location ||
                    (this.use_alternative_location != null &&
                    this.use_alternative_location.Equals(input.use_alternative_location))
                ) && 
                (
                    this.idusuario_navigation == input.idusuario_navigation ||
                    (this.idusuario_navigation != null &&
                    this.idusuario_navigation.Equals(input.idusuario_navigation))
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
                if (this.idusuario != null)
                    hashCode = hashCode * 59 + this.idusuario.GetHashCode();
                if (this.user_id != null)
                    hashCode = hashCode * 59 + this.user_id.GetHashCode();
                if (this.password != null)
                    hashCode = hashCode * 59 + this.password.GetHashCode();
                if (this.usuario_activo != null)
                    hashCode = hashCode * 59 + this.usuario_activo.GetHashCode();
                if (this.campo_biometrico_empleado != null)
                    hashCode = hashCode * 59 + this.campo_biometrico_empleado.GetHashCode();
                if (this.use_alternative_location != null)
                    hashCode = hashCode * 59 + this.use_alternative_location.GetHashCode();
                if (this.idusuario_navigation != null)
                    hashCode = hashCode * 59 + this.idusuario_navigation.GetHashCode();
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
