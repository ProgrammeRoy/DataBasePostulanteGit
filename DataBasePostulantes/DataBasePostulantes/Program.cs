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
      insertar();
    }
    static void insertar()
    {
      DataBasePostulantesEntities DB = new DataBasePostulantesEntities();
      //insert
      FichaDatos P1 = new FichaDatos
      {
        Nombre = "Roy Ernesto",
        Apellido = "Martínez Ramírez",
        FechaNacimiento = new DateTime(1988, 01, 02),
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
    static void Update()
    {
      DataBasePostulantesEntities db = new DataBasePostulantesEntities();
      var mificha = db.FichaDatos.First(x => x.DNI == "45390831");
      mificha.Nombre = "Roy Ernesto";
      db.SaveChanges();
    }

    static void Delete()
    {
      DataBasePostulantesEntities db = new DataBasePostulantesEntities();
      var mificha = db.FichaDatos.First(x => x.DNI == "45390831");
      db.FichaDatos.Remove(mificha);
      db.SaveChanges();
    }
    static void Select()
    {
      DataBasePostulantesEntities db = new DataBasePostulantesEntities();
      var resultado = from f in db.FichaDatos
                      join d in db.ExperienciaLaboral on f.FichaDatosId equals d.FichaDatosId
                      where f.Apellido == "Perez"
                      orderby f.Nombre descending
                      select new EntidadRetornadaDelSelect
                      {
                        Apellido = f.Apellido,
                        Nombre = f.Nombre,
                        Dni = f.DNI,
                        Celular = d.CelularReferencia
                      };

      foreach (var item in resultado)
      {
       
      }
      db.SaveChanges();
    }
    public class EntidadRetornadaDelSelect
    {
      public string Apellido { get; set; }
      public string Nombre { get; set; }
      public string Dni { get; set; }
      public int? Celular { get; set; }
    }


  }
}
