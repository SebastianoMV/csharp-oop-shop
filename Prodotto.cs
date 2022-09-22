// See https://aka.ms/new-console-template for more information

abstract class Prodotto
{
    public int Codice { get; set; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }


    //COSTRUTTORE PRODOTTO
    public Prodotto(string nome, string descrizione, double prezzo, int iva)
    {
        Random random = new Random( );
        Codice = random.Next(1, 123445);
        Nome = nome;
        Descrizione = descrizione;
        Prezzo = prezzo;
        Iva = iva;
    }

    //GET

    public void getProdotto()
    {
        Console.WriteLine("Codice prodotto: " + Codice);
        Console.WriteLine("Nome prodotto: " + Nome);
        Console.WriteLine("Descrizione prodotto: " + Descrizione);
        Console.WriteLine("Prezzo prodotto: " + Prezzo);
        Console.WriteLine("Iva prodotto: " + Iva);
    }
    public void getCodice()
    {
        Console.WriteLine(Codice);
    }


    // GET PREZZO CON IVA
    public void getPrezzoConIva()
    {
        double prezzoiva = Math.Round(Prezzo + ((Prezzo * Iva) / 100), 2);
        Console.WriteLine("Prezzo con Iva: " + prezzoiva);
    }

    // GET NOME ESTESO
    public virtual void getNomeEsteso()
    {
        string nomeEsteso = Codice + Nome;
        Console.WriteLine("Nome esteso: " + nomeEsteso);
    }

    //BONUS PAD LEFT
    public void getCodicePad()
    {
       
        string codicePad = Codice.ToString();
        while(codicePad.Length < 8)
        {
            codicePad = "0" + codicePad;
        }
        Console.WriteLine(codicePad);
    }


    //METODI ASTRATTI
};


class Acqua : Prodotto
{
    public double Litri { get; set; }
    public double Ph { get; set; }

    

    public Acqua(string nome, string descrizione, double prezzo, int iva, double litri, double ph) : base(nome, descrizione, prezzo, iva)
    {
        this.Litri = Litri;
        this.Ph = ph;
    }

    public override void getNomeEsteso()
    {
        base.getNomeEsteso();
        Console.WriteLine("Livello ph: " + Ph);
        Console.WriteLine("Litri: " + Litri);
    }
}

class ConfezioneAcqua : Acqua
{
    public int NumeroBottiglie{ get; set; }
    public ConfezioneAcqua(string nome, string descrizione, double prezzo, int iva, double litri, double ph, int numeroBottiglie) : base(nome, descrizione, prezzo, iva, litri, ph)
    {
        NumeroBottiglie = numeroBottiglie;
    }

    public override void getNomeEsteso()
    {
        base.getNomeEsteso();
        Console.WriteLine("Confezione da " + NumeroBottiglie + " bottiglie");
    }
}

class Frutta : Prodotto
{
    public string Varietà { get; set; }

    public Frutta(string nome, string descrizione, double prezzo, int iva, string varietà) : base(nome, descrizione, prezzo, iva)
    {
        Varietà = varietà;
    }
}

class SacchettoFrutta : Frutta
{
    public int Quantità { get; set; }
    public SacchettoFrutta(string nome, string descrizione, double prezzo, int iva, string varietà, int quantità) : base(nome, descrizione, prezzo, iva, varietà)
    {
        Quantità = quantità;
    }
}