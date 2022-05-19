using Domain.DepreciationDBEntities;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public IPepitoSchoolContext context;
        public EstudianteRepository(IPepitoSchoolContext context)
        {
            this.context = context;
        }

        public void Create(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Estudiante t)
        {
            throw new NotImplementedException();
        }
    }
}
