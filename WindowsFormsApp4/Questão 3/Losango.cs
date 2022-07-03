using System;
using System.Collections.Generic;

public class Losango
{
    private double diagonalA;
    private double diagonalB;

    public string GetDiagoalA()
    {
        return Convert.ToString(this.diagonalA);
    }

    public string GetDiagoalB()
    {
        return Convert.ToString(this.diagonalB);
    }

    public void SetDiagonalA(string entrada)
    {
        this.diagonalA = Convert.ToDouble(entrada);
    }

    public void SetDiagonalB(string entrada)
    {
        this.diagonalB = Convert.ToDouble(entrada);
    }

    public double CalcArea()
    {
        return (diagonalA * diagonalB) / 2;
    }
}