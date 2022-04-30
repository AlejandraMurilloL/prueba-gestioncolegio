using AutoMapper;
using GestionColegio.Application.Asignatura.Dtos;
using GestionColegio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignatura.Services
{
    public class AsignaturaQueryService : IAsignaturaQueryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AsignaturaQueryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AsignaturaDto>> GetAll()
        {
            var asignaturas = await _unitOfWork.AsignaturaRepository.GetAllAsync().ConfigureAwait(false);

            return _mapper.Map<IEnumerable<AsignaturaDto>>(asignaturas);
        }
    }
}
