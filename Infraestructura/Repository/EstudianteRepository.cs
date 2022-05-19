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
            try
            {
                context.Estudiantes.Add(t);
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto Asset no puede ser null.");
                }

                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"El objeto con id {t.Id} no existe.");
                }

                context.Estudiantes.Remove(estudiante);
                int result = context.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return context.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return context.Estudiantes.ToList();
        }
            public int Update(Estudiante t)
        {
            throw new NotImplementedException();
        }
    }
}
