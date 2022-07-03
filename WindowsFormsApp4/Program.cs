using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        ProcessarQuestao1();
        ProcessarQuestao2();
        ProcessarQuestao3();
        ProcessarQuestao4();
    }

    private static void ProcessarQuestao1()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 1");
        Console.WriteLine("-----------------------------------");
        Paciente paciente = new Paciente();
        paciente.SetNome("Carlos Costa");
        paciente.SetCNS("123456789123456");

        Console.WriteLine("\n" + paciente);
        
    }

    private static void ProcessarQuestao2()
    {
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Resposta da Questão 2");
        Console.WriteLine("-----------------------------------");
        Eletrodomestico el = new Eletrodomestico();
        el.SetNome("Fornão Eletrolux");
        el.SetCOD("839780653699");
        el.SetPreco("2888.99");

        string nome1 = el.GetNome();
        string cod = el.GetCOD();
        string preco = el.GetPreco();

        Console.WriteLine("\n" + el);


    }

    private static void ProcessarQuestao3()
    {
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Resposta da Questão 3");
        Console.WriteLine("-----------------------------------");

        Circulo circo = new Circulo();
        circo.SetRaio("2");

        Quadrado quad = new Quadrado();
        quad.SetLado("2");

        Retangulo ret = new Retangulo();
        ret.SetLado1("2");
        ret.SetLado2("3");

        Losango los = new Losango();
        los.SetDiagonalA("2");
        los.SetDiagonalB("3");

        double area0 = circo.CalcArea();
        double area1 = quad.CalcArea();
        double area2 = ret.CalcArea();
        double area3 = los.CalcArea();

        Console.WriteLine("Área do Círculo: {0}", area0);
        Console.WriteLine("Área do Quadrado: {0}", area1);
        Console.WriteLine("Área do Retangulo: {0}", area2);
        Console.WriteLine("Área do Losango: {0}", area3);
    }

    private static void ProcessarQuestao4()
    {

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Resposta da Questão 4");
        Console.WriteLine("-----------------------------------");

        Soma som = new Soma();
        som.SetValorA("2.5");
        som.SetValorB("-3.0");

        Multiplicacao mul = new Multiplicacao();
        mul.SetValorA("2.5");
        mul.SetValorB("-3.0");

        Divisao div = new Divisao();
        div.SetValorA("2.5");
        div.SetValorB("-3.0");

        Subtracao sub = new Subtracao();
        sub.SetValorA("2.5");
        sub.SetValorB("-3.0");

        double op0 = som.Operar();
        double op1 = mul.Operar();
        double op2 = div.Operar();
        double op3 = sub.Operar();

        Console.WriteLine("Resultado Soma: {0}", op0);
        Console.WriteLine("Resultado Multiplicação: {0}", op1);
        Console.WriteLine("Resultado Divisão: {0}", op2);
        Console.WriteLine("Resultado Subtração: {0}", op3);
    }
}
