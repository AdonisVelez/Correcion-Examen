class Estudiante
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string nombreinstitucion { get; set; }
    public int id { get; set; }
    public Estudiante(string nombre, string apellido, string nombreinstitucion, int id)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.nombreinstitucion = nombreinstitucion;
        this.id = id;
    }
    
    public void ImprimirDatos()
    {
        Console.WriteLine("El nombre del estudiante es "+nombre+" y su apellido es "+apellido);
        Console.WriteLine("Nombre de la Institucion es: "+nombreinstitucion);
        Console.WriteLine("Numero de cedula: "+id);
    }
}