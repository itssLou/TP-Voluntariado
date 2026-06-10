using System;

public class Coordinador : Persona
{
    
    private string areaAsig;
    private int personasAcargo;

    public string AreaAsig
    {
        get{return areaAsig;}set{areaAsig=value;}
    }

    public int PersonasAcargo
    {
        get{return personasAcargo;}set{personasAcargo=value;}

    }

    public Coordinador(string nombre, int edad, string areaAsig, int personasACargo)
        : base(nombre, edad)
    {
        
        this.areaAsig = areaAsig;
        this.personasAcargo = personasACargo;
    }


     public override void MostrarInfo()
    {
        Console.WriteLine($"Coordinador: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Área asignada: {areaAsig}");
        Console.WriteLine($"Personas a cargo: {personasAcargo}");
    }
}
