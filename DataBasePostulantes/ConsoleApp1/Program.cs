using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new PostulantesEntities();
            //inserto
            var nuevoInstrumento = new Instrumento();
            nuevoInstrumento.Id = 100;
            nuevoInstrumento.Nombre = "Gaita";

            db.Instrumento.Add(nuevoInstrumento);
            db.SaveChanges();

            //listo
            var lista = db.Instrumento.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine(item.Id + " " + item.Nombre);
            }
            Console.ReadKey();
        }
    }
}
