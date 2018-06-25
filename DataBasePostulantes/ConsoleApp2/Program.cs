using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("console2...");

            NuevaEntities db = new NuevaEntities();
            Casas nuevaCasa = new Casas();
            nuevaCasa.Id = 2;
            nuevaCasa.Nombre = "House";

            db.Casas.Add(nuevaCasa);
            db.SaveChanges();

            Console.ReadKey();
        }
    }
}
