using System;

public abstract class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get {return nombre; } set {nombre = value; }
        
    }


    public int Edad
    {
        get{return edad;} set {edad = value;}
   
    }

    public Persona(string nombre, int edad)
    {
        this.nombre=nombre;
        this.edad=edad;
    }

    public abstract void MostrarInfo();


}

