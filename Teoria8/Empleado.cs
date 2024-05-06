namespace Teoria8;
class Empleado(string nombre, int legajo):IComparable
{
    public int CompareTo(object? obj)
    {
       
        int result = 0;
        if (obj is Empleado e)
        {
           string nombre = e.Nombre;
           result = this.Nombre.CompareTo(nombre);
        }
        return result;
    }
    public string Nombre { get; set; }
    public int legajo{get;set;}
    public void Imprimir()
    => Console.WriteLine($"Soy el empleado {Nombre}");
}