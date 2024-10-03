using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Proj
{
    public class Carro : IVeiculos
    {
        void IVeiculos.Abastecer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Gasolina Cara!");
            Console.ReadLine();
        }

        void IVeiculos.Andar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mas sem Gasolina o Carro não anda né!");
            Console.ReadLine();
        }

        void IVeiculos.Comprar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("E que dinheiro que não tenho!");
            Console.ReadLine();
        }

        void IVeiculos.Desligar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cheguei, Desliguei hehe!");
            Console.ReadLine();
        }

        void IVeiculos.EmitirAlertaDefalhas()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tenho esse sistema, mas torço que não soem nenhum!");
            Console.ReadLine();
        }

        void IVeiculos.Ligar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Liguei, VAM BOOOOORA!");
            Console.ReadLine();
        }

        void IVeiculos.Quebrar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Não quero isso pro meu querido Carrinho");
            Console.ReadLine();
        }
    }
    public class Homem : IServivo
    {
        void IServivo.Acordar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Acordei, UUUUAR!");
            Console.ReadLine();
        }

        void IServivo.Andar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vou Até a Padaria compra um pãozinho!");
            Console.ReadLine();
        }

        void IServivo.Beber()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ou talves um suco!");
            Console.ReadLine();
        }

        void IServivo.Comer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("O pão que comprei mesmo, tava bom, Pão de logo cedo do dia é otimo!");
            Console.ReadLine();
        }

        void IServivo.Dormir()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("So a noite mesmo!");
            Console.ReadLine();
        }

        void IServivo.Enxergar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vejo coisas KKKKK!");
            Console.ReadLine();
        }
        void IServivo.Morrer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Erros de estruturamento, eu não morro e depois respiro!");
            Console.ReadLine();
        }

        void IServivo.Respirar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Estou vivo, Respiro bem!");
            Console.ReadLine();

        }
    }
    public class Aeronave : IVoador
    {
        void IVoador.Decolar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("3, 2, 1...");
            Console.ReadLine();
        }

        void IVoador.Planar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Uma Paradinha no AR!");
            Console.ReadLine();
        }

        void IVoador.Pousar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Destino Concluido, Preparice para Pousar");
            Console.ReadLine();
        }

        void IVoador.Voar()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Estou voando de Avião");
            Console.ReadLine();
        }
    }
    public class Gato : IFelino
    {

        void IFelino.IFelinoAnda()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Passeia muito a noite");
            Console.ReadLine();
        }

        void IFelino.IFelinoBebeAgua()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Depois que chega do passeio, bebe!");
            Console.ReadLine();
        }

        void IFelino.IFelinoCome()
        {
            Console.WriteLine("Como e muitoooooo");
            Console.ReadLine();
        }
        void IFelino.IFelinoDorme()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dorme");
            Console.ReadLine();
        }
        void IFelino.IFelinoMia()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("QUEROOOO COMIDAAAAAAAAA");
            Console.ReadLine();
        }
        

        
    

    }
}
