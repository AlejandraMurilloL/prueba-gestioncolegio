using AutoMapper;
using GestionColegio.Application.Asignaturas.Dtos;
using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using System.Threading.Tasks;

namespace GestionColegio.Application.Asignaturas.Services
{
    public class AsignaturaCommandService : IAsignaturaCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AsignaturaCommandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Save(AsignaturaDto dto)
        {
            var asignatura = _mapper.Map<AsignaturaDto, Asignatura>(dto);

            _unitOfWork.AsignaturaRepository.Add(asignatura);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Update(AsignaturaDto dto, int id)
        {
            var asignatura = await _unitOfWork.AsignaturaRepository.GetByIdAsync(id).ConfigureAwait(false);

            asignatura.Actualizar(dto.Codigo, dto.Nombre);

            _unitOfWork.AsignaturaRepository.Update(asignatura);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var asignatura = await _unitOfWork.AsignaturaRepository.
                        GetByIdAsync(id).ConfigureAwait(false);

            _unitOfWork.AsignaturaRepository.Remove(asignatura);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }
    }
}
