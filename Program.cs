// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP SHOP");


Prodotto prodotto = new Prodotto("pippo", "ciao come stai", 20.99 , 22);

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
        prodotto.setNome();
    }else if (scelta == "descrizione")
    {
        prodotto.setDescrizione();
    }else if (scelta == "prezzo")
    {
        prodotto.setPrezzo();
    }else if (scelta == "iva")
    {
        prodotto.setIva();
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



