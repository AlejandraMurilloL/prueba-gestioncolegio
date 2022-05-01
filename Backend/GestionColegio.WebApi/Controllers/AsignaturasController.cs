using GestionColegio.Application.Asignaturas.Dtos;
using GestionColegio.Application.Asignaturas.Services;
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

        [HttpGet]
        [Route("{id}")]
        public async Task<AsignaturaDto> GetPAsignatura(int id)
        {
            return await QueryService.GetById(id);
        }
    }
}
