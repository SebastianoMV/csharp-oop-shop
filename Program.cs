// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP SHOP");


Prodotto prodotto = new Prodotto();

prodotto.getCodice();

prodotto.setNome();

prodotto.getNome();

prodotto.getPrezzo();
prodotto.getPrezzoConIva();

prodotto.getNomeEsteso();

class Prodotto
{
    int codice = 123;
    string nome = "Scarpe";
    string descrizione = "scarpe blu taglia 44";
    decimal prezzo = 50.99m;
    int iva = 22;


    //GET
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

    public string setNome()
    {
        nome = Console.ReadLine();
        return nome;
    }

    public string setDescrizione()
    {
        descrizione = Console.ReadLine();
        return descrizione;
    }

    public decimal setPrezzo()
    {
        prezzo = decimal.Parse(Console.ReadLine());
        return prezzo;
    }

    public int setIva()
    {
        iva = Int32.Parse(Console.ReadLine());
        return iva;
    }


    // GET PREZZO CON IVA
    public void getPrezzoConIva()
    {
        decimal prezzoiva = Math.Round(prezzo + ((prezzo * 22) / 100), 2);
        Console.WriteLine("Prezzo con Iva: " + prezzoiva);
    }

    // GET NOME ESTESO
    public void getNomeEsteso()
    {
        string nomeEsteso = codice + nome;
        Console.WriteLine("Nome esteso: " + nomeEsteso);
    }
};


