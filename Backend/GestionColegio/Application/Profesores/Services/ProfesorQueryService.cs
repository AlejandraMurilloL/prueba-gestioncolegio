using AutoMapper;
using GestionColegio.Application.Profesores.Dtos;
using GestionColegio.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Profesores.Services
{
    public class ProfesorQueryService : IProfesorQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProfesorQueryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProfesorDto>> GetAll()
        {
            var profesores = await _unitOfWork.ProfesorRepository.GetAllAsync().ConfigureAwait(false);

            return _mapper.Map<IEnumerable<ProfesorDto>>(profesores);
        }

        public async Task<ProfesorDto> GetById(int id)
        {
            var profesor = await _unitOfWork.ProfesorRepository.GetByIdAsync(id).ConfigureAwait(false);

            return _mapper.Map<ProfesorDto>(profesor);
        }
    }
}
