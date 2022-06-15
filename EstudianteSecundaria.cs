class EstudianteSecundaria : Estudiante , ICalcular
{
    int precioFijoAnual = 20;
    int nivelCursado;

    public EstudianteSecundaria(int nivelCursado, string nombre, string apellido, string nombreinstitucion, int id) : base(nombre, apellido,nombreinstitucion,id)
    {
        this.nivelCursado = nivelCursado;
    }

    public void calcularMatricula()
    {
        Console.WriteLine("El valor fijo de la matricula es de: "+precioFijoAnual);
    }
}