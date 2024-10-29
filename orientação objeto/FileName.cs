using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace orientação_objeto
{
    //public class Pessoa
    //{
    //    private string nome;
    //    private decimal preco;

    //    public void AlternarNome(string NewNome)
    //    { 
    //        nome = NewNome;
    //        Console.WriteLine("Nome alterado");
    //    }
    //    public void AlternarPreco(decimal NewPreco)
    //    {
    //        if (NewPreco > 0)
    //        {
    //            preco = NewPreco;
    //            Console.WriteLine("Valor alterado");
    //        }
    //        else
    //        {
    //            Console.WriteLine("valor não alterado");
    //        }
    //    }
    //    public override string ToString()
    //    {
    //        return $"Dados do produto nome = {nome} Preco = {preco}\n";
    //    }
    //}
    //public class Executor 
    //{ 
    //  public static void executar()
    //    {
    //        var p1 = new Pessoa();
    //        p1.AlternarNome("Joao");
    //        p1.AlternarPreco(8000);
    //        Console.WriteLine(p1.ToString());
    //    }
    //}

    //public class Veiculo 
    //{
    //    public int velocidade { get; set; }

    //    public void Mover()
    //    {
    //        Console.WriteLine("O veiculo esta se movendo");
    //    }
    //}
    //public class Carro : Veiculo
    //{ 
    //    public int QtdPortas { get; set; }

    //    public void Buzinar()
    //    {
    //        Console.WriteLine("BI! BI!");
    //    }
    //}
    //public class Executor
    //{
    //    public static void executar()
    //    {
    //        var carro = new Carro();
    //        carro.Mover();
    //        carro.Buzinar();
    //    }
    //}

    //public class Animal
    //{
    //    protected string Som { get; set; }
    //    public void EmitirSom()
    //    {
    //        Console.WriteLine(Som);
    //    }
    //}
    //public class Cachorro : Animal
    //{
    //    public Cachorro()
    //    {
    //        Som = "AU";
    //    }
    //}
    //public class Gato : Animal
    //{
    //    public Gato()
    //    {
    //        Som = "Miau";
    //    }
    //}
    //public class Executor
    //{
    //    public static void executar()
    //    {
    //        List<Animal> animais = new List<Animal>();

    //        animais.Add(new Cachorro());
    //        animais.Add(new Gato());
    //        animais.Add(new Cachorro());
    //        animais.Add(new Cachorro());
    //        animais.Add(new Gato());
    //        animais.Add(new Gato());
    //        animais.Add(new Cachorro());


    //        foreach (Animal anima in animais)
    //        {
    //            anima.EmitirSom();
    //        }

    //        var gato = new Gato();
    //        gato.EmitirSom();
    //    }
    //}

    //public class InstrumentoMusical 
    //{
    //    protected string entrada { get; set; }
    //    public void Tocar()
    //    {
    //        Console.WriteLine($"Está {entrada}");
    //    }
    //}
    //public class Violao : InstrumentoMusical
    //{
    //    public Violao()
    //    {
    //        entrada = "Tocando violão";
    //    }
    //}
    //public class Piano : InstrumentoMusical
    //{
    //    public Piano()
    //    {
    //        entrada = "Tocando piano";
    //    }
    //}
    //public class Tambor : InstrumentoMusical
    //{
    //    public Tambor()
    //    {
    //        entrada = "Tocando tambor";
    //    }
    //}
    //public class Executor
    //{
    //    public static void Executar()
    //    {

    //        var objetos = new InstrumentoMusical[3];
    //        objetos[0] = new Violao();
    //        objetos[1] = new Piano();
    //        objetos[2] = new Tambor();

    //        foreach (var objeto in objetos) 
    //        {
    //            objeto.Tocar();
    //        }
    //    }
    //}

    //public abstract class RegistroDB
    //{
    //    protected abstract string NomeTabela { get; }

    //    public void select()
    //    {
    //        var select = $"SELECT * FROM {NomeTabela}";
    //        Console.WriteLine($"Executando select no banco de dados : {select} ");
    //    }
    //}
    //public abstract class Forma
    //{
    //    public int @base { get; set; }
    //    public int altura { get; set; }
    //    public abstract void CalcularPerimetro();
    //}
    //public class Retangulo : Forma
    //{

    //    public override void CalcularPerimetro()
    //    {
    //        Console.WriteLine($"O resultado do calculado é {@base * altura}");
    //    }
    //}
    //public class Triangulo : Forma
    //{
    //    public Triangulo(int @base, int altura)
    //    {
    //        Base = @base;
    //        Altura = altura;
    //    }

    //    public override void CalcularPerimetro()
    //    {
    //        Console.WriteLine($"O resultado do calculado é {(Base * Altura) / 2}");
    //    }
    //}
    //public class PessoaDB : RegistroDB
    //{
    //    protected override string NomeTabela { get => "PESSOAS"; }
    //}

    //public class ProdutoDB : RegistroDB
    //{
    //    protected override string NomeTabela { get => "PRODUTO"; }
    //}

    //public class Executor
    //{
    //    public static void Executar()
    //    {
    //        var Triangulo = new Triangulo();
    //        var Retangulo = new Retangulo();

    //        Triangulo.CalcularPerimetro();
    //        Retangulo.CalcularPerimetro();
    //    }
    //}

    public interface IAutenticavel
    {
        void Autenticar();
        void Deslogar();
    }

    public class UsuarioSistema : IAutenticavel
    {

        public void Autenticar()
        {
            Console.WriteLine("login feito no sistema");
        }

        public void Deslogar()
        {
            Console.WriteLine("logout do sistema");
        }
    }
    public class Executor
    {
        public static void Executar()
        {
            var usuSistema = new UsuarioSistema();
            usuSistema.Autenticar();
            usuSistema.Deslogar();
        }
    }
}
