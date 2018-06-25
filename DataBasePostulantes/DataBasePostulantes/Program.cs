using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePostulantes
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBasePostulantesEntities DB = new DataBasePostulantesEntities();
            FichaDatos P1 = new FichaDatos
            
            {
                Nombre = "Roy Ernesto",
                Apellido = "Martínez Ramírez",
                FechaNacimiento = new DateTime(1988,01,02),
                Sexo = "Masculino",
                DNI = "45390831",
                Celular = 972014679,
                Correo = "roymartinezramirez@gmail.com",
                Direccion = "Prol. Las Mercedes 701",
                Distrito = "Chaclacayo",
                Departamento = "Lima",
                EstadoCivil = "Soltero",
                Nacionalidad = "Peruano",
                PuestoInteresado = "Analista Selección",
                GradoInstruccion = "Universitario",
                CentroEstudiosSuperiores = "UPC",
                EstudiosComplementarios = "Power Bi, SQL, C#",
                
            };
            ExperienciaLaboral E1 = new ExperienciaLaboral
            {
                NombreEmpresa = "Trampolinka",
                Puesto = "Practicante Seleccion",
                TiempoLaborado = 6,
                MotivoRenuncia = "Nuevas oportunidades",
                NombreReferencia = "Viviana",
                CelularReferencia = 952154825,
                FichaDatosId = 1
            };

            
            DB.FichaDatos.Add(P1);
            DB.ExperienciaLaboral.Add(E1);
            DB.SaveChanges();
        }
    }
}
