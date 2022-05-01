using GestionColegio.Application.Estudiantes.Dtos;
using GestionColegio.Application.Estudiantes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        public IEstudianteQueryService QueryService { get; set; }
        public IEstudianteCommandService CommandService { get; set; }

        public EstudiantesController(IEstudianteQueryService queryService, IEstudianteCommandService commandService)
        {
            QueryService = queryService;
            CommandService = commandService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<EstudianteDto> GetProfesor(int id)
        {
            return await QueryService.GetById(id);
        }

        [HttpGet]
        public async Task<IEnumerable<EstudianteDto>> GetAll()
        {
            return await QueryService.GetAll();
        }

        [HttpPost]
        public async Task Add([FromBody] EstudianteDto estudiante)
        {
            await CommandService.Save(estudiante);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task Update(int id, [FromBody] EstudianteDto estudiante)
        {
            await CommandService.Update(estudiante, id);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(int id)
        {
            await CommandService.Delete(id);
        }
    }
}
