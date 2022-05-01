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
        public IAsignaturaCommandService CommandService { get; set; }

        public AsignaturasController(IAsignaturaQueryService queryService, IAsignaturaCommandService commandService)
        {
            QueryService = queryService;
            CommandService = commandService;
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

        [HttpPost]
        public async Task Add([FromBody] AsignaturaDto asignatura)
        {
            await CommandService.Save(asignatura);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task Update(int id, [FromBody] AsignaturaDto asignatura)
        {
            await CommandService.Update(asignatura, id);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(int id)
        {
            await CommandService.Delete(id);
        }
    }
}
