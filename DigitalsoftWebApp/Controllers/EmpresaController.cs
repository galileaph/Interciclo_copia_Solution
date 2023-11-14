using api.digitalsoftec.net.Api;
using api.digitalsoftec.net.Client;
using api.digitalsoftec.net.Model;
using DigitalsoftWebApp.Models.Account;
using DigitalsoftWebApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitalsoftWebApp.Controllers
{
    public class EmpresaController : BaseController
    {
        public EmpresaController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpContextAccessor, configuration)
        {
        }

        public async Task<IActionResult> List()
        {
            ConfigureUserData();

            Configuration apiConfiguration = new Configuration();
            apiConfiguration.BasePath = _base_url;
            apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);

            EmpresaApi empresaApi = new EmpresaApi(apiConfiguration);
            var list = await empresaApi.ApiEmpresaListPostAsync(new api.digitalsoftec.net.Model.BusinessLayerAdminEmpresasHelpersListEmpresasRequest()
            {
                filtro = "",
                activa = true
            });
            return View(list);
        }

        private async Task<List<BusinessLayerCommonDTOTipoIdentificacionDTO>> getTipoIdentificacionList()
        {
            TipoIdentificacionApi api = new TipoIdentificacionApi(_apiConfiguration);
            return await api.ApiTipoIdentificacionListGetAsync();
        }

        private async Task<List<BusinessLayerCommonDTORegimenTributarioDTO>> getRegimenTributarioList()
        {
            RegimenTributarioApi api = new RegimenTributarioApi(_apiConfiguration);
            return await api.ApiRegimenTributarioListPostAsync(new BusinessLayerCommonHelpersListRegimenTributarioRequest());
        }

        private async Task<List<BusinessLayerAdminUbicacionesDTOParroquiaDTO>> getParroquiaList()
        {
            UbicacionesApi api = new UbicacionesApi(_apiConfiguration);
            var filtro = new BusinessLayerAdminUbicacionesHelpersListUbicacionesRequestParroqias
            {
                ciudad_id = "0301",
                filtro = ""
            };
            return await api.ApiUbicacionesListParroquiasPostAsync(filtro);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            var empresa = await empresaApi.ApiEmpresaGetByIdPostAsync(new BusinessLayerAdminEmpresasHelpersFindEmpresaRequest()
            {
                empresa_id = id
            });

            List<BusinessLayerCommonDTORegimenTributarioDTO> regimenTributario = await getRegimenTributarioList();
            ViewBag.RegimenTributario = new SelectList(regimenTributario, "regimen_id", "regimen_nombre", empresa.empresa_regimen_tributario_id=1);

            List<BusinessLayerAdminUbicacionesDTOParroquiaDTO> parroquia = await getParroquiaList();
            ViewBag.Parroquia = new SelectList(parroquia, "parroquia_id", "parroquia_nombre", empresa.empresa_parroquia_id);

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", empresa.tipo_identificacion_id);

            return View(empresa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BusinessLayerAdminEmpresasDTOEmpresaDTO empresa)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            BusinessLayerAdminEmpresasHelpersEditEmpresaRequest request = new BusinessLayerAdminEmpresasHelpersEditEmpresaRequest();
            CustomMapper.CopyProperties(empresa, request);
            var edited = await empresaApi.ApiEmpresaEditPutAsync(request);
            TempData["SuccessMessage"] = "Datos guardados exitosamente!";

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", empresa.tipo_identificacion_id);

            List<BusinessLayerCommonDTORegimenTributarioDTO> regimenTributario = await getRegimenTributarioList();
            ViewBag.RegimenTributario = new SelectList(regimenTributario, "regimen_id", "regimen_nombre", empresa.empresa_regimen_tributario_id=1);

            List<BusinessLayerAdminUbicacionesDTOParroquiaDTO> parroquia = await getParroquiaList();
            ViewBag.Parroquia = new SelectList(parroquia, "parroquia_id", "parroquia_nombre", empresa.empresa_parroquia_id);

            return View(edited);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);


            List<BusinessLayerCommonDTORegimenTributarioDTO> regimenTributario = await getRegimenTributarioList();
            ViewBag.RegimenTributario = new SelectList(regimenTributario, "regimen_id", "regimen_nombre");

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre");

            List<BusinessLayerAdminUbicacionesDTOParroquiaDTO> parroquia = await getParroquiaList();
            ViewBag.Parroquia = new SelectList(parroquia, "parroquia_id", "parroquia_nombre");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BusinessLayerAdminEmpresasDTOEmpresaDTO empresa)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            BusinessLayerAdminEmpresasHelpersCreateEmpresaRequest request = new BusinessLayerAdminEmpresasHelpersCreateEmpresaRequest();
            CustomMapper.CopyProperties(empresa, request);
            var created = await empresaApi.ApiEmpresaCreatePostAsync(request);
            TempData["SuccessMessage"] = "Datos guardados exitosamente!";

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", empresa.tipo_identificacion_id);

            List<BusinessLayerCommonDTORegimenTributarioDTO> regimenTributario = await getRegimenTributarioList();
            ViewBag.RegimenTributario = new SelectList(regimenTributario, "regimen_id", "regimen_nombre", empresa.empresa_regimen_tributario_id=1);

            List<BusinessLayerAdminUbicacionesDTOParroquiaDTO> parroquia = await getParroquiaList();
            ViewBag.Parroquia = new SelectList(parroquia, "parroquia_id", "parroquia_nombre", empresa.empresa_parroquia_id);

            return View(created);
        }
        [HttpGet]
        public async Task<IActionResult> Eliminar(int id)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            var empresa = await empresaApi.ApiEmpresaGetByIdPostAsync(new BusinessLayerAdminEmpresasHelpersFindEmpresaRequest()
            {
                empresa_id = id
            });

            return View(empresa);
        }
        [HttpPost]
        public async Task<IActionResult> Eliminar(BusinessLayerAdminEmpresasDTOEmpresaDTO empresa)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            var eliminar = await empresaApi.ApiEmpresaDeleteDeleteAsync(new BusinessLayerAdminEmpresasHelpersDeleteEmpresaRequest()
            {
                empresa_id = empresa.empresa_id
            });
            TempData["SuccessMessage"] = "Empresa eliminada exitosamente!";

            return RedirectToAction("List", "Empresa");
        }
    }
}
