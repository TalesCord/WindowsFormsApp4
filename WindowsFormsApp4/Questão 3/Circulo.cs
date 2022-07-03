using System;
using System.Collections.Generic;

public class Circulo
{
    private double raio;

    public string GetRaio()
    {
        return Convert.ToString(this.raio);
    }

    public void SetRaio(string entrada)
    {
        this.raio = Convert.ToDouble(entrada);
    }

    public double CalcArea()
    {
        return Math.Pow(raio, 2) * Math.PI;
    }
}