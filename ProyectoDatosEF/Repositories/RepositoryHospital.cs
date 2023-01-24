using ProyectoDatosEF.Data;
using ProyectoDatosEF.Models;

namespace ProyectoDatosEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;
        private object datos;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        //Creamos nuestros métodos para recuperar datos
        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                           select datos;
            return consulta.ToList();
        }

        //Metodo para devolver un hospital
        public Hospital FindHospital(int id)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == id
                           select datos;
            return consulta.FirstOrDefault();
        }
    }
}
