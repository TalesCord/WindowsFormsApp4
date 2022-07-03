using System;
using System.Collections.Generic;

public class Quadrado
{
    private double lado;

    public string GetLado()
    {
        return Convert.ToString(this.lado);
    }

    public void SetLado(string entrada)
    {
        this.lado = Convert.ToDouble(entrada);
    }

    public double CalcArea()
    {
        return Math.Pow(lado, 2);
    }
}