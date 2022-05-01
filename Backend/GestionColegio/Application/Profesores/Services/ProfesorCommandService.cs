using AutoMapper;
using GestionColegio.Application.Profesores.Dtos;
using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using System.Threading.Tasks;

namespace GestionColegio.Application.Profesores.Services
{
    public class ProfesorCommandService : IProfesorCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProfesorCommandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Save(ProfesorDto profesor)
        {
            var newProfesor = new Profesor(profesor.Identificacion, profesor.Nombre, profesor.Apellido);

            newProfesor.Actualizar(profesor.Edad, profesor.Direccion, profesor.Telefono);

            _unitOfWork.ProfesorRepository.Add(newProfesor);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Update(ProfesorDto dto, int id)
        {
            var profesor = await _unitOfWork.ProfesorRepository.GetByIdAsync(id).ConfigureAwait(false);

            profesor.ConIdentificacion(dto.Identificacion)
                    .ConNombreCompleto(dto.Nombre, dto.Apellido)
                    .Actualizar(dto.Edad, dto.Direccion, dto.Telefono);

            _unitOfWork.ProfesorRepository.Update(profesor);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var profesor = await _unitOfWork.ProfesorRepository.
                        GetByIdAsync(id).ConfigureAwait(false);
            
            _unitOfWork.ProfesorRepository.Remove(profesor);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

    }
}
