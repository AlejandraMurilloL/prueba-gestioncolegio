using AutoMapper;
using GestionColegio.Application.Estudiantes.Dtos;
using GestionColegio.Domain.Entities;
using GestionColegio.Domain.Interfaces;
using System.Threading.Tasks;

namespace GestionColegio.Application.Estudiantes.Services
{
    class EstudianteCommandService : IEstudianteCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EstudianteCommandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Save(EstudianteDto profesor)
        {
            var newEstudiante = new Estudiante(profesor.Identificacion, profesor.Nombre, profesor.Apellido);

            newEstudiante.Actualizar(profesor.Edad, profesor.Direccion, profesor.Telefono);

            _unitOfWork.EstudianteRepository.Add(newEstudiante);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Update(EstudianteDto dto, int id)
        {
            var estudiante = await _unitOfWork.EstudianteRepository.GetByIdAsync(id).ConfigureAwait(false);

            estudiante.ConIdentificacion(dto.Identificacion)
                    .ConNombreCompleto(dto.Nombre, dto.Apellido)
                    .Actualizar(dto.Edad, dto.Direccion, dto.Telefono);

            _unitOfWork.EstudianteRepository.Update(estudiante);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }

        public async Task Delete(int id)
        {
            var estudiante = await _unitOfWork.EstudianteRepository.
                        GetByIdAsync(id).ConfigureAwait(false);

            _unitOfWork.EstudianteRepository.Remove(estudiante);

            await _unitOfWork.CompleteAsync().ConfigureAwait(false);
        }
    }
}
