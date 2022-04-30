using GestionColegio.Application.Asignatura.Dtos;
using GestionColegio.Application.Asignatura.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturasController : ControllerBase
    {
        public IAsignaturaQueryService QueryService { get; set; }
        public AsignaturasController(IAsignaturaQueryService queryService)
        {
            QueryService = queryService;
        }

        [HttpGet]
        public async Task<IEnumerable<AsignaturaDto>> GetAll()
        {
            return await QueryService.GetAll();
        }
    }
}
