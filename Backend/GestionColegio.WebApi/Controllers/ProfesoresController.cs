using GestionColegio.Application.Profesor.Dtos;
using GestionColegio.Application.Profesor.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionColegio.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        public IProfesorQueryService QueryService { get; set; }

        public ProfesoresController(IProfesorQueryService queryService)
        {
            QueryService = queryService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ProfesorDto> GetProfesor(int id)
        {
            return await QueryService.GetById(id);
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<ProfesorDto>> GetAll()
        {
            return await QueryService.GetAll();
        }
    }
}
