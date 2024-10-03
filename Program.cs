using Interface_Proj;

class Program
{
    static void Main(string[] args)
    {

        
        Carro carro = new Carro();
        IVeiculos carros = carro;
        
        carros.Abastecer();
        carros.Andar();
        carros.Comprar();
        carros.Desligar();
        carros.EmitirAlertaDefalhas();
        carros.Ligar();
        carros.Quebrar();


        Homem homem = new Homem();
        IServivo homens = homem;

        homens.Acordar();
        homens.Andar();
        homens.Beber();
        homens.Comer();
        homens.Dormir();
        homens.Enxergar();
        homens.Morrer();
        homens.Respirar();

        Aeronave aeronave = new Aeronave();
        IVoador naves = aeronave;

        naves.Decolar();
        naves.Planar();
        naves.Pousar();
        naves.Voar();

        Gato gato = new Gato();
        IFelino gatos = gato;

        gatos.IFelinoAnda();
        gatos.IFelinoMia();
        gatos.IFelinoDorme();
        gatos.IFelinoMia();
        gatos.IFelinoCome();

    }
}
