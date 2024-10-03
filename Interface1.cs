using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Proj
{
    internal interface IVoador
    {
        public void Voar();
        public void Decolar();
        public void Planar();
        public void Pousar();
    }
    internal interface IServivo
    {
        public void Comer();
        public void Respirar();
        public void Beber();
        public void Morrer();
        public void Andar();
        public void Dormir();
        public void Acordar();
        public void Enxergar();
    }
    internal interface IVeiculos
    {
        public void Ligar();
        public void Desligar();
        public void Abastecer();
        public void Andar();
        public void Quebrar();
        public void Comprar();
        public void EmitirAlertaDefalhas();
    }
    internal interface IFelino
    {
        public void IFelinoMia();
        public void IFelinoCome();
        public void IFelinoAnda();
        public void IFelinoBebeAgua();
        public void IFelinoDorme();
    }
    internal interface ICanino
    {
        public void Icanino();
        public void ICaninoDorme();
        public void ICaninoMorde();
        public void ICaninoCome();
        public void ICaninoAnda();
        public void ICaninoRespira();   
    }


































}
