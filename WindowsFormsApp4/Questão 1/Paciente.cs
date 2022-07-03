using System;
using System.Collections.Generic;

public class Paciente {
  private string nome;
  private UInt64 cns;

  public string GetNome(){
    return this.nome;
  }
  public void SetNome(string entrada){
    this.nome = entrada;
  }

  public string GetCNS(){
    return Convert.ToString(this.cns);
  }

  public void SetCNS(string entrada){
    this.cns = Convert.ToUInt64(entrada);
  }
    public override String ToString()
    {
        return nome + "\n" + String.Format("{0:### #### #### ####}", cns);
    }
}