using System;

namespace AdonisExamenCorrecion
{
    class Program
    {
        public static void Main(String [] args)
        {
            Estudiante primaria = new EstudiantePrimaria("Mario","Perez", "Luis Felipe Chavez",1316765287);
            primaria.ImprimirDatos();

             Estudiante secundaria = new EstudianteSecundaria(4, "Maria","Perez", "Manta",1316765287);
            secundaria.ImprimirDatos();

             Estudiante universidad = new EstudianteUniversitario(8, "Pedro","Perez", "Uleam",1316765287);
            universidad.ImprimirDatos();

            List<Estudiante> listEstu = new List<Estudiante>();
            listEstu.Add(primaria);
            listEstu.Add(secundaria);
            listEstu.Add(universidad);

            foreach (ICalcular item in listEstu )
            {
               item.calcularMatricula();
            }      
        }
    }
}
