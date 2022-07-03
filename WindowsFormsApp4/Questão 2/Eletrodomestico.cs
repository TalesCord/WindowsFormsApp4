using System;
using System.Collections.Generic;

public class Eletrodomestico
{
    private string nome;
    private UInt64 codigo;
    private decimal preco;

    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string entrada)
    {
        this.nome = entrada;
    }

    public string GetCOD()
    {
        return Convert.ToString(this.codigo);
    }

    public void SetCOD(string entrada)
    {
        this.codigo = Convert.ToUInt64(entrada);
    }

    public string GetPreco()
    {
        return Convert.ToString(this.preco);
    }

    public void SetPreco(string entrada)
    {
        this.preco = Convert.ToDecimal(entrada);
    }
    public override String ToString()
    {
        return String.Format("{0:##-####-#####-#},\n{1},", codigo, nome) + "\nR" + String.Format("{0:C}", preco);
    }


}