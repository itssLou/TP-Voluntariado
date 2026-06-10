using System;

public  class Voluntario : Persona
{
    private int horasTrabajadas;
    public int HorasTrabajadas
    {
        get{return horasTrabajadas; } set{horasTrabajadas= value;}

    }

    public Voluntario(string nombre, int edad, int horasTrabajadas)
        :base(nombre, edad)
    {
        this.horasTrabajadas=horasTrabajadas;

    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Voluntario: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
    }

    
}

