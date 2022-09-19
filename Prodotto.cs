// See https://aka.ms/new-console-template for more information








class Prodotto
{
    int codice = 123;
    string nome;
    string descrizione;
    double prezzo;
    int iva;


    //COSTRUTTORE PRODOTTO
    public Prodotto(string nome, string descrizione, double prezzo, int iva)
    {
        Random random = new Random( );
        this.codice = random.Next(1, 123445);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = iva;
    }

    //GET

    public void getProdotto()
    {
        Console.WriteLine("Codice prodotto: " + codice);
        Console.WriteLine("Nome prodotto: " + nome);
        Console.WriteLine("Descrizione prodotto: " + descrizione);
        Console.WriteLine("Prezzo prodotto: " + prezzo);
        Console.WriteLine("Iva prodotto: " + iva);
    }
    public void getCodice()
    {
        Console.WriteLine(codice);
    }

    public void getNome()
    {
        Console.WriteLine(nome);
    }

    public void getDescrizione()
    {
        Console.WriteLine(descrizione);
    }

    public void getPrezzo()
    {
        Console.WriteLine(prezzo);
    }


    public void getIva()
    {
        Console.WriteLine(iva);
    }

    //SET

    public string setNome(string nomeNuovo)
    {
        nome = nomeNuovo;
        return nome;
    }

    public string setDescrizione(string descrizioneNuova)
    {
        descrizione = descrizioneNuova;
        return descrizione;
    }

    public double setPrezzo(double prezzoNuovo)
    {
        prezzo = prezzoNuovo;
        return prezzo;
    }

    public int setIva(int ivaNuova)
    {
        iva = ivaNuova;
        return iva;
    }


    // GET PREZZO CON IVA
    public void getPrezzoConIva()
    {
        double prezzoiva = Math.Round(prezzo + ((prezzo * 22) / 100), 2);
        Console.WriteLine("Prezzo con Iva: " + prezzoiva);
    }

    // GET NOME ESTESO
    public void getNomeEsteso()
    {
        string nomeEsteso = codice + nome;
        Console.WriteLine("Nome esteso: " + nomeEsteso);
    }

    //BONUS PAD LEFT
    public void getCodicePad()
    {
       
        string codicePad = codice.ToString();
        while(codicePad.Length < 8)
        {
            codicePad = "0" + codicePad;
        }
        Console.WriteLine(codicePad);
    }
};


