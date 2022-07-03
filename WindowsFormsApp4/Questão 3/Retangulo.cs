using System;
using System.Collections.Generic;

public class Retangulo
{
    private double lado1;
    private double lado2;

    public string GetLado1()
    {
        return Convert.ToString(this.lado1);
    }

    public string GetLado2()
    {
        return Convert.ToString(this.lado2);
    }

    public void SetLado1(string entrada)
    {
        this.lado1 = Convert.ToDouble(entrada);
    }

    public void SetLado2(string entrada)
    {
        this.lado2 = Convert.ToDouble(entrada);
    }

    public double CalcArea()
    {
        return lado1 * lado2;
    }
}