﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DigitalsoftWebApp.Models.Account;
//
//    var loggedUserResponse = LoggedUserResponse.FromJson(jsonString);

namespace DigitalsoftWebApp.Models.Account
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LoggedUserResponse
    {
        [JsonProperty("user_id")]
        public Guid UserId { get; set; }

        [JsonProperty("empleado_id")]
        public long EmpleadoId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("roles")]
        public List<object> Roles { get; set; }

        [JsonProperty("profilePicture")]
        public object ProfilePicture { get; set; }

        [JsonProperty("empleado")]
        public Empleado Empleado { get; set; }
    }

    public partial class Empleado
    {
        [JsonProperty("empleado_codigo_interno")]
        public string EmpleadoCodigoInterno { get; set; }

        [JsonProperty("empleado_cargo")]
        public string EmpleadoCargo { get; set; }

        [JsonProperty("empleado_feha_ingreso")]
        public DateTimeOffset EmpleadoFehaIngreso { get; set; }

        [JsonProperty("empleado_fecha_ultima_modificacion")]
        public object EmpleadoFechaUltimaModificacion { get; set; }

        [JsonProperty("cliente_observaciones")]
        public object ClienteObservaciones { get; set; }

        [JsonProperty("empleado_user_registra_id")]
        public Guid EmpleadoUserRegistraId { get; set; }

        [JsonProperty("empresa_id")]
        public long EmpresaId { get; set; }

        [JsonProperty("empresa")]
        public Empresa Empresa { get; set; }

        [JsonProperty("persona_id")]
        public long PersonaId { get; set; }

        [JsonProperty("persona_nro_identificacion")]
        public string PersonaNroIdentificacion { get; set; }

        [JsonProperty("persona_nombres")]
        public string PersonaNombres { get; set; }

        [JsonProperty("persona_apellidos")]
        public string PersonaApellidos { get; set; }

        [JsonProperty("persona_fecha_nacimiento")]
        public DateTimeOffset PersonaFechaNacimiento { get; set; }

        [JsonProperty("genero_id")]
        public long GeneroId { get; set; }

        [JsonProperty("genero")]
        public object Genero { get; set; }

        [JsonProperty("tipo_persona_id")]
        public long TipoPersonaId { get; set; }

        [JsonProperty("tipoPersona")]
        public object TipoPersona { get; set; }

        [JsonProperty("tipo_identificacion_id")]
        public long TipoIdentificacionId { get; set; }

        [JsonProperty("tipoIdentificacion")]
        public object TipoIdentificacion { get; set; }

        [JsonProperty("estado_civil_id")]
        public long EstadoCivilId { get; set; }

        [JsonProperty("estadoCivil")]
        public object EstadoCivil { get; set; }

        [JsonProperty("is_externa")]
        public bool IsExterna { get; set; }
    }

    public partial class Empresa
    {
        [JsonProperty("empresa_id")]
        public long EmpresaId { get; set; }

        [JsonProperty("empresa_codigo_interno")]
        public string EmpresaCodigoInterno { get; set; }

        [JsonProperty("empresa_razon_social")]
        public string EmpresaRazonSocial { get; set; }

        [JsonProperty("empresa_nombre_comercial")]
        public string EmpresaNombreComercial { get; set; }

        [JsonProperty("empresa_activa")]
        public bool EmpresaActiva { get; set; }

        [JsonProperty("empresa_nro_identificacion")]
        public string EmpresaNroIdentificacion { get; set; }

        [JsonProperty("tipo_identificacion_id")]
        public long TipoIdentificacionId { get; set; }

        [JsonProperty("tipoIdentificacion")]
        public object TipoIdentificacion { get; set; }

        [JsonProperty("empresa_telefono")]
        public string EmpresaTelefono { get; set; }

        [JsonProperty("empresa_movil")]
        public string EmpresaMovil { get; set; }

        [JsonProperty("empresa_direccion_principal")]
        public string EmpresaDireccionPrincipal { get; set; }

        [JsonProperty("empresa_direccion_ref")]
        public string EmpresaDireccionRef { get; set; }

        [JsonProperty("empresa_email")]
        public string EmpresaEmail { get; set; }

        [JsonProperty("empresa_site_url")]
        public string EmpresaSiteUrl { get; set; }

        [JsonProperty("empresa_slogan")]
        public string EmpresaSlogan { get; set; }

        [JsonProperty("empresa_contribuyente_especial")]
        public bool EmpresaContribuyenteEspecial { get; set; }

        [JsonProperty("empresa_obligado_contabilidad")]
        public bool EmpresaObligadoContabilidad { get; set; }

        [JsonProperty("empresa_realiza_ats")]
        public bool EmpresaRealizaAts { get; set; }

        [JsonProperty("empresa_agente_retencion")]
        public bool EmpresaAgenteRetencion { get; set; }

        [JsonProperty("empresa_logo")]
        public string EmpresaLogo { get; set; }

        [JsonProperty("empresa_rep_legal_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long EmpresaRepLegalId { get; set; }

        [JsonProperty("empresa_rep_legal")]
        public string EmpresaRepLegal { get; set; }

        [JsonProperty("empresa_conatdor_id")]
        public string EmpresaConatdorId { get; set; }

        [JsonProperty("empresa_contador_name")]
        public string EmpresaContadorName { get; set; }

        [JsonProperty("empresa_regimen_tributario_id")]
        public long EmpresaRegimenTributarioId { get; set; }

        [JsonProperty("regimenTributario")]
        public object RegimenTributario { get; set; }

        [JsonProperty("empresa_parroquia_id")]
        public string EmpresaParroquiaId { get; set; }

        [JsonProperty("parroquia")]
        public object Parroquia { get; set; }

        [JsonProperty("empresa_tipo_agente_retencion_id")]
        public long EmpresaTipoAgenteRetencionId { get; set; }

        [JsonProperty("tipoAgenteRetencion")]
        public object TipoAgenteRetencion { get; set; }

        [JsonProperty("sucursales")]
        public List<object> Sucursales { get; set; }

        [JsonProperty("tarifas_venta_detalle")]
        public List<object> TarifasVentaDetalle { get; set; }
    }

    public partial class LoggedUserResponse
    {
        public static LoggedUserResponse FromJson(string json) => JsonConvert.DeserializeObject<LoggedUserResponse>(json, DigitalsoftWebApp.Models.Account.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LoggedUserResponse self) => JsonConvert.SerializeObject(self, DigitalsoftWebApp.Models.Account.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}