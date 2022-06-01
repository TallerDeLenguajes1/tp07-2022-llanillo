namespace Ejercicio1;

public class Tarea{
    
    public string Descripcion { get; }
    private readonly int _tareaId;
    private readonly int _duracion;

    public Tarea(int tareaId, string descripcion, int duracion){
        _tareaId  = tareaId;
        Descripcion = descripcion;
        _duracion = duracion;
    }

    public void MostrarTarea(){
        Console.WriteLine("--- Tarea " + _tareaId.ToString() + " ---");
        Console.WriteLine("Descripción: " + Descripcion + " ---");
        Console.WriteLine("Duración " + _duracion.ToString() + " ---");
    }

}