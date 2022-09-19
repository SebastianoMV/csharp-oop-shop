// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP SHOP");


Prodotto prodotto = new Prodotto("pippo", "ciao come stai", 20.99 , 22);
prodotto.getCodicePad();

prodotto.getProdotto();

prodotto.getPrezzoConIva();

prodotto.getNomeEsteso();

bool flagChange = false;
string scelta;

Console.WriteLine("vuoi cambiare qualcosa? [si,no]");
scelta = Console.ReadLine();
if(scelta == "si")
{
    flagChange = true;
};

while (flagChange)
{
    Console.WriteLine("Cosa vuoi cambiare? [nome,descrizione,prezzo,iva]");
    scelta= Console.ReadLine();
    if (scelta == "nome")
    {
        string s = Console.ReadLine();
        prodotto.setNome(s);

    }else if (scelta == "descrizione")
    {
        string s = Console.ReadLine();
        prodotto.setDescrizione(s);

    }
    else if (scelta == "prezzo")
    {
        double prezzoNew = double.Parse(Console.ReadLine());
        prodotto.setPrezzo(prezzoNew);
    }
    else if (scelta == "iva")
    {
        int ivaNew = Int32.Parse(Console.ReadLine());
        prodotto.setIva(ivaNew);
    }
    else
    {
        Console.WriteLine("Scelta non valida.");
    }

    Console.WriteLine("vuoi cambiare altro? [si,no]");
    scelta = Console.ReadLine();

    if (scelta == "no")
    {
        flagChange = false;
        prodotto.getProdotto();
    };

    
};



