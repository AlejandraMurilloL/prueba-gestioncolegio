using GestionColegio.Application.Profesores.Dtos;
using GestionColegio.Application.Profesores.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        public IProfesorQueryService QueryService { get; set; }
        public IProfesorCommandService CommandService { get; set; }

        public ProfesoresController(IProfesorQueryService queryService, IProfesorCommandService commandService)
        {
            QueryService = queryService;
            CommandService = commandService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ProfesorDto> GetProfesor(int id)
        {
            return await QueryService.GetById(id);
        }

        [HttpGet]
        public async Task<IEnumerable<ProfesorDto>> GetAll()
        {
            return await QueryService.GetAll();
        }

        [HttpPost]
        public async Task Add([FromBody]ProfesorDto profesor)
        {
            await CommandService.Save(profesor);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task Update(int id, [FromBody] ProfesorDto profesor)
        {
            await CommandService.Update(profesor, id);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task Delete(int id)
        {
            await CommandService.Delete(id);
        }
    }
}
