using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class EstudianteService : IEstudianteService
    {
        private IEstudianteRepository estudianteRepository;
        public EstudianteService(IEstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }

        public void Create(Estudiante t)
        {
            estudianteRepository.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            return estudianteRepository.Delete(t);
        }

        public List<Estudiante> GetAll()
        {
            return estudianteRepository.GetAll();
        }

        public int Update(Estudiante t)
        {
            return estudianteRepository.Update(t);
        }
    }
}
