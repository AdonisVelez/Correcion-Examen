class EstudianteUniversitario : Estudiante , ICalcular
{
    int valorCredito = 7;
    int cantidadCreditos { get; set; }

    public EstudianteUniversitario(int cantidadCreditos , string nombre, string apellido, string nombreinstitucion, int id) : base(nombre, apellido,nombreinstitucion,id)
    {
        this.cantidadCreditos = cantidadCreditos;
    }

    public void calcularMatricula()
    {
        int pago = valorCredito * cantidadCreditos;
        Console.WriteLine("El valor fijo de la matricula es de: "+pago);
    }
}