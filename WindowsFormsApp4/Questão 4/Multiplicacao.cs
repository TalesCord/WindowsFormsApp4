using System;
using System.Collections.Generic;

public class Multiplicacao
{
    private double valorA;
    private double valorB;

    public string GetValorA()
    {
        return Convert.ToString(this.valorA);
    }

    public void SetValorA(string entrada)
    {
        this.valorA = Convert.ToDouble(entrada);
    }

    public string GetValorB()
    {
        return Convert.ToString(this.valorB);
    }

    public void SetValorB(string entrada)
    {
        this.valorB = Convert.ToDouble(entrada);
    }

    public double Operar()
    {
        return valorA * valorB;
    }
}