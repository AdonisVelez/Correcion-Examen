class EstudiantePrimaria : Estudiante , ICalcular
{
    int valorFijoAnual = 100;

    public EstudiantePrimaria( string nombre, string apellido, string nombreinstitucion, int id) : base(nombre, apellido,nombreinstitucion,id)
    { 

    }

   public void calcularMatricula()
   {
    Console.WriteLine("El valor fijo de la matricula es de: "+valorFijoAnual);
   }
}