using AutoMapper;
using GestionColegio.Application.Estudiantes.Dtos;
using GestionColegio.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Estudiantes.Services
{
    class EstudianteQueryService : IEstudianteQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EstudianteQueryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EstudianteDto>> GetAll()
        {
            var asignaturas = await _unitOfWork.EstudianteRepository.GetAllAsync().ConfigureAwait(false);

            return _mapper.Map<IEnumerable<EstudianteDto>>(asignaturas);
        }

        public async Task<EstudianteDto> GetById(int id)
        {
            var profesor = await _unitOfWork.EstudianteRepository.GetByIdAsync(id).ConfigureAwait(false);

            return _mapper.Map<EstudianteDto>(profesor);
        }
    }
}
