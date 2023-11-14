using api.digitalsoftec.net.Api;
using api.digitalsoftec.net.Client;
using api.digitalsoftec.net.Model;
using DigitalsoftWebApp.Models.Account;
using DigitalsoftWebApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitalsoftWebApp.Controllers
{
    public class ClienteController : BaseController
    {
        public ClienteController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(httpContextAccessor, configuration)
        {
        }
        public async Task<IActionResult> List()
        {
            ConfigureUserData();

            Configuration apiConfiguration = new Configuration();
            apiConfiguration.BasePath = _base_url;
            apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);

            ClienteApi empresaApi = new ClienteApi(apiConfiguration);
            var list = await empresaApi.ApiClienteListPostAsync(new api.digitalsoftec.net.Model.BusinessLayerVentasClientesHelpersListClientesRequest()
            {
                filtro = "",
                empresa_id = 1
            });
            return View(list);
        }
        private async Task<List<BusinessLayerPersonsDTOGeneroDTO>> getGeneroList()
        {
            GeneroApi api = new GeneroApi(_apiConfiguration);
            return await api.ApiGeneroListGetAsync("");
        }
        private async Task<List<BusinessLayerPersonsDTOTipoPersonaDTO>> getTipoPersonaList()
        {
            TipoPersonaApi api = new TipoPersonaApi(_apiConfiguration);
            return await api.ApiTipoPersonaListGetAsync("");
        }
        private async Task<List<BusinessLayerCommonDTOTipoIdentificacionDTO>> getTipoIdentificacionList()
        {
            TipoIdentificacionApi api = new TipoIdentificacionApi(_apiConfiguration);
            return await api.ApiTipoIdentificacionListGetAsync("");
        }
        private async Task<List<BusinessLayerPersonsDTOEstadoCivilDTO>> getEstadoCivilList()
        {
            EstadoCivilApi api = new EstadoCivilApi(_apiConfiguration);
            return await api.ApiEstadoCivilListGetAsync();
        }
        private async Task<List<BusinessLayerAdminEmpresasDTOEmpresaDTO>> getEmpresaList()
        {
            EmpresaApi api = new EmpresaApi(_apiConfiguration);
            var filtro = new BusinessLayerAdminEmpresasHelpersListEmpresasRequest
            {
                filtro = "",
                activa = true
            };
            return await api.ApiEmpresaListPostAsync(filtro);
        }
        private async Task<List<BusinessLayerVentasTransaccionesDTOTarifaVentaDTO>> getTarifaList()
        {
            TarifaVentaApi api = new TarifaVentaApi(_apiConfiguration);
            return await api.ApiTarifaVentaListGetAsync();
        }
        private async Task<List<BusinessLayerVentasTransaccionesDTOTipoVentaDTO>> getTipoVentaList()
        {
            TipoVentaApi api = new TipoVentaApi(_apiConfiguration);
            return await api.ApiTipoVentaListGetAsync();
        }
        private async Task<List<BusinessLayerVentasClientesDTOZonaClienteDTO>> getZonaClienteList()
        {
            ZonaClienteApi api = new ZonaClienteApi(_apiConfiguration);
            return await api.ApiZonaClienteListGetAsync();
        }
        private async Task<List<BusinessLayerVentasClientesDTOGrupoClienteDTO>> getGrupoClienteList()
        {
            GrupoClienteApi api = new GrupoClienteApi(_apiConfiguration);
            return await api.ApiGrupoClienteListGetAsync();
        }
        private async Task<List<BusinessLayerVentasClientesDTOClienteDTO>> getClienteVendedorList()
        {
            ClienteApi api = new ClienteApi(_apiConfiguration);
            var filtro = new BusinessLayerVentasClientesHelpersListClientesRequest
            {
                filtro = "",
                empresa_id = 1
            };
            return await api.ApiClienteListPostAsync(filtro);
        }
        private async Task<List<BusinessLayerVentasClientesDTOClienteDTO>> getClienteCobradorList()
        {
            ClienteApi api = new ClienteApi(_apiConfiguration);
            var filtro = new BusinessLayerVentasClientesHelpersListClientesRequest
            {
                filtro = "",
                empresa_id = 1
            };
            return await api.ApiClienteListPostAsync(filtro);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);
            var cliente = await clienteApi.ApiClienteGetByIdPostAsync(new BusinessLayerVentasClientesHelpersFindClienteRequest()
            {
                cliente_id = id
            });

            List<BusinessLayerPersonsDTOGeneroDTO> genero = await getGeneroList();
            ViewBag.Genero = new SelectList(genero, "genero_id", "genero_nombre", cliente.genero_id);

            List<BusinessLayerPersonsDTOTipoPersonaDTO> tipoPersona = await getTipoPersonaList();
            ViewBag.TipoPersona = new SelectList(tipoPersona, "tipo_persona_id", "tipo_persona_nombre", cliente.tipo_persona_id);

            //List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            //ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", cliente.tipo_identificacion_id);

            //List<BusinessLayerPersonsDTOEstadoCivilDTO> estadoCivil = await getEstadoCivilList();
            //ViewBag.EstadoCivil = new SelectList(estadoCivil, "estado_civil_id", "estado_civil_nombre", cliente.estado_civil_id);

            //List<BusinessLayerAdminEmpresasDTOEmpresaDTO> empresa = await getEmpresaList();
            //ViewBag.Empresa = new SelectList(empresa, "empresa_id", "empresa_nombre", cliente.empresa_id);

            //List<BusinessLayerVentasTransaccionesDTOTarifaVentaDTO> tarifa = await getTarifaList();
            //ViewBag.TarifaVenta = new SelectList(tarifa, "tarifa_venta_id", "tarifa_venta_nombre", cliente.cliente_tarifa_id);

            //List<BusinessLayerVentasTransaccionesDTOTipoVentaDTO> tipoVenta = await getTipoVentaList();
            //ViewBag.TipoVenta = new SelectList(tipoVenta, "tipo_venta_id", "tipo_venta_nombre", cliente.cliente_tipo_venta_id);

            //List<BusinessLayerVentasClientesDTOZonaClienteDTO> zonaCliente = await getZonaClienteList();
            //ViewBag.ZonaCliente = new SelectList(zonaCliente, "zona_cliente_id", "zona_cliente_nombre", cliente.zona_cliente_id);

            //List<BusinessLayerVentasClientesDTOGrupoClienteDTO> grupoCliente = await getGrupoClienteList();
            //ViewBag.GrupoCliente = new SelectList(grupoCliente, "grupo_cliente_id", "grupo_cliente_nombre", cliente.grupo_cliente_id);

            //List<BusinessLayerVentasClientesDTOClienteDTO> clienteVendedor = await getClienteVendedorList();
            //ViewBag.ClienteVendedor = new SelectList(clienteVendedor, "cliente_id", "cliente_nombre", cliente.persona_id);

            //List<BusinessLayerVentasClientesDTOClienteDTO> clienteCobrador = await getClienteCobradorList();
            //ViewBag.ClienteCobrador = new SelectList(clienteCobrador, "cliente_id", "cliente_nombre", cliente.persona_id);

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BusinessLayerVentasClientesDTOClienteDTO cliente)
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);
            BusinessLayerVentasClientesHelpersEditClienteRequest request = new BusinessLayerVentasClientesHelpersEditClienteRequest();
            CustomMapper.CopyProperties(cliente, request);
            var edited = await clienteApi.ApiClienteEditPutAsync(request);
            TempData["SuccessMessage"] = "Datos guardados exitosamente!";

            List<BusinessLayerPersonsDTOGeneroDTO> genero = await getGeneroList();
            ViewBag.Genero = new SelectList(genero, "genero_id", "genero_nombre", cliente.genero_id);

            List<BusinessLayerPersonsDTOTipoPersonaDTO> tipoPersona = await getTipoPersonaList();
            ViewBag.TipoPersona = new SelectList(tipoPersona, "tipo_persona_id", "tipo_persona_nombre", cliente.tipo_persona_id);

            //List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            //ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", cliente.tipo_identificacion_id);

            //List<BusinessLayerPersonsDTOEstadoCivilDTO> estadoCivil = await getEstadoCivilList();
            //ViewBag.EstadoCivil = new SelectList(estadoCivil, "estado_civil_id", "estado_civil_nombre", cliente.estado_civil_id);

            //List<BusinessLayerAdminEmpresasDTOEmpresaDTO> empresa = await getEmpresaList();
            //ViewBag.Empresa = new SelectList(empresa, "empresa_id", "empresa_nombre", cliente.empresa_id);

            //List<BusinessLayerVentasTransaccionesDTOTarifaVentaDTO> tarifa = await getTarifaList();
            //ViewBag.TarifaVenta = new SelectList(tarifa, "tarifa_venta_id", "tarifa_venta_nombre", cliente.cliente_tarifa_id);

            //List<BusinessLayerVentasTransaccionesDTOTipoVentaDTO> tipoVenta = await getTipoVentaList();
            //ViewBag.TipoVenta = new SelectList(tipoVenta, "tipo_venta_id", "tipo_venta_nombre", cliente.cliente_tipo_venta_id);

            //List<BusinessLayerVentasClientesDTOZonaClienteDTO> zonaCliente = await getZonaClienteList();
            //ViewBag.ZonaCliente = new SelectList(zonaCliente, "zona_cliente_id", "zona_cliente_nombre", cliente.zona_cliente_id);

            //List<BusinessLayerVentasClientesDTOGrupoClienteDTO> grupoCliente = await getGrupoClienteList();
            //ViewBag.GrupoCliente = new SelectList(grupoCliente, "grupo_cliente_id", "grupo_cliente_nombre", cliente.grupo_cliente_id);

            //List<BusinessLayerVentasClientesDTOClienteDTO> clienteVendedor = await getClienteVendedorList();
            //ViewBag.ClienteVendedor = new SelectList(clienteVendedor, "cliente_id", "cliente_nombre", cliente.persona_id);

            //List<BusinessLayerVentasClientesDTOClienteDTO> clienteCobrador = await getClienteCobradorList();
            //ViewBag.ClienteCobrador = new SelectList(clienteCobrador, "cliente_id", "cliente_nombre", cliente.persona_id);

            return View(edited);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);

            List<BusinessLayerPersonsDTOGeneroDTO> genero = await getGeneroList();
            ViewBag.Genero = new SelectList(genero, "genero_id", "genero_nombre");

            List<BusinessLayerPersonsDTOTipoPersonaDTO> tipoPersona = await getTipoPersonaList();
            ViewBag.TipoPersona = new SelectList(tipoPersona, "tipo_persona_id", "tipo_persona_nombre");

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre");

            List<BusinessLayerPersonsDTOEstadoCivilDTO> estadoCivil = await getEstadoCivilList();
            ViewBag.EstadoCivil = new SelectList(estadoCivil, "estado_civil_id", "estado_civil_nombre");

            List<BusinessLayerAdminEmpresasDTOEmpresaDTO> empresa = await getEmpresaList();
            ViewBag.Empresa = new SelectList(empresa, "empresa_id", "empresa_nombre");

            List<BusinessLayerVentasTransaccionesDTOTarifaVentaDTO> tarifa = await getTarifaList();
            ViewBag.TarifaVenta = new SelectList(tarifa, "tarifa_venta_id", "tarifa_venta_nombre");

            List<BusinessLayerVentasTransaccionesDTOTipoVentaDTO> tipoVenta = await getTipoVentaList();
            ViewBag.TipoVenta = new SelectList(tipoVenta, "tipo_venta_id", "tipo_venta_nombre");

            List<BusinessLayerVentasClientesDTOZonaClienteDTO> zonaCliente = await getZonaClienteList();
            ViewBag.ZonaCliente = new SelectList(zonaCliente, "zona_cliente_id", "zona_cliente_nombre");

            List<BusinessLayerVentasClientesDTOGrupoClienteDTO> grupoCliente = await getGrupoClienteList();
            ViewBag.GrupoCliente = new SelectList(grupoCliente, "grupo_cliente_id", "grupo_cliente_nombre");

            List<BusinessLayerVentasClientesDTOClienteDTO> clienteVendedor = await getClienteVendedorList();
            ViewBag.ClienteVendedor = new SelectList(clienteVendedor, "cliente_id", "cliente_nombre");

            List<BusinessLayerVentasClientesDTOClienteDTO> clienteCobrador = await getClienteCobradorList();
            ViewBag.ClienteCobrador = new SelectList(clienteCobrador, "cliente_id", "cliente_nombre");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BusinessLayerVentasClientesDTOClienteDTO cliente)
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);
            BusinessLayerVentasClientesHelpersCreateClienteRequest request = new BusinessLayerVentasClientesHelpersCreateClienteRequest();
            CustomMapper.CopyProperties(cliente, request);
            var created = await clienteApi.ApiClienteCreatePostAsync(request);
            TempData["SuccessMessage"] = "Datos guardados exitosamente!";

            List<BusinessLayerPersonsDTOGeneroDTO> genero = await getGeneroList();
            ViewBag.Genero = new SelectList(genero, "genero_id", "genero_nombre", cliente.genero_id);

            List<BusinessLayerPersonsDTOTipoPersonaDTO> tipoPersona = await getTipoPersonaList();
            ViewBag.TipoPersona = new SelectList(tipoPersona, "tipo_persona_id", "tipo_persona_nombre", cliente.tipo_persona_id);

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", cliente.tipo_identificacion_id);

            List<BusinessLayerPersonsDTOEstadoCivilDTO> estadoCivil = await getEstadoCivilList();
            ViewBag.EstadoCivil = new SelectList(estadoCivil, "estado_civil_id", "estado_civil_nombre", cliente.estado_civil_id);

            List<BusinessLayerAdminEmpresasDTOEmpresaDTO> empresa = await getEmpresaList();
            ViewBag.Empresa = new SelectList(empresa, "empresa_id", "empresa_nombre", cliente.empresa_id);

            List<BusinessLayerVentasTransaccionesDTOTarifaVentaDTO> tarifa = await getTarifaList();
            ViewBag.TarifaVenta = new SelectList(tarifa, "tarifa_venta_id", "tarifa_venta_nombre", cliente.cliente_tarifa_id);

            List<BusinessLayerVentasTransaccionesDTOTipoVentaDTO> tipoVenta = await getTipoVentaList();
            ViewBag.TipoVenta = new SelectList(tipoVenta, "tipo_venta_id", "tipo_venta_nombre", cliente.cliente_tipo_venta_id);

            List<BusinessLayerVentasClientesDTOZonaClienteDTO> zonaCliente = await getZonaClienteList();
            ViewBag.ZonaCliente = new SelectList(zonaCliente, "zona_cliente_id", "zona_cliente_nombre", cliente.zona_cliente_id);

            List<BusinessLayerVentasClientesDTOGrupoClienteDTO> grupoCliente = await getGrupoClienteList();
            ViewBag.GrupoCliente = new SelectList(grupoCliente, "grupo_cliente_id", "grupo_cliente_nombre", cliente.grupo_cliente_id);;

            List<BusinessLayerVentasClientesDTOClienteDTO> clienteVendedor = await getClienteVendedorList();
            ViewBag.ClienteVendedor = new SelectList(clienteVendedor, "cliente_id", "cliente_nombre", cliente.persona_id);

            List<BusinessLayerVentasClientesDTOClienteDTO> clienteCobrador = await getClienteCobradorList();
            ViewBag.ClienteCobrador = new SelectList(clienteCobrador, "cliente_id", "cliente_nombre", cliente.persona_id);


            return View(created);
        }

        [HttpGet]
        public async Task<IActionResult> Eliminar(int id)
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);
            var cliente = await clienteApi.ApiClienteGetByIdPostAsync(new BusinessLayerVentasClientesHelpersFindClienteRequest()
            {
                cliente_id=id
            });

            return View(cliente);
        }
        [HttpPost]
        public async Task<IActionResult> Eliminar(BusinessLayerVentasClientesDTOClienteDTO cliente)
        {
            ConfigureUserData();
            ClienteApi clienteApi = new ClienteApi(_apiConfiguration);
            var eliminar = await clienteApi.ApiClienteDeleteDeleteAsync(new BusinessLayerVentasClientesHelpersDeleteClienteRequest()
            {
                cliente_id = cliente.persona_id
            });
            TempData["SuccessMessage"] = "Persona eliminada exitosamente!";

            return RedirectToAction("List", "Cliente");
        }
    }

}
