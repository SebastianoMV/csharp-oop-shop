// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP SHOP");

Acqua acqua = new Acqua("San Benedetto", "Acqua naturale oligominerale", 1.50, 10, 1.5, 5.50);
ConfezioneAcqua confAcqua = new ConfezioneAcqua("San Benedetto Confezione", "Acqua naturale oligominerale", 1.50, 10, 1.5, 5.50, 6);
Frutta pesca = new Frutta("pesca", "frutto", 1.5, 4, "bianca");
SacchettoFrutta confPesche = new SacchettoFrutta("Confezione di pesche", "frutto", 1.5, 4, "bianca", 6); 



List<Prodotto> carrello = new List<Prodotto>();

Console.WriteLine("Benvenuto! Cosa vuoi acquistare?");
bool flag = true;

while (flag)
{
    Console.WriteLine("1. Bottiglia d'acqua");
    Console.WriteLine("2. Confezione d'acqua");
    Console.WriteLine("3. Una pesca");
    Console.WriteLine("4. Un sacchetto di pesche");
    int scelta = Int32.Parse(Console.ReadLine());

    switch (scelta)
    {
        case 1:
            carrello.Add(acqua);
            Console.WriteLine("Acqua aggiunta al carrello");
            break;
        case 2:
            carrello.Add(confAcqua);
            Console.WriteLine("Confezione d'acqua aggiunta al carrello");
            break;
        case 3:
            carrello.Add(pesca);
            Console.WriteLine("Pesca aggiuta al carrello");
            break;
        case 4:
            carrello.Add(confPesche);
            Console.WriteLine("Sacchetto di pesche aggiunto al carrello");
            break;
        default:
            Console.WriteLine("Prodotto inesistente");
            break;
    }
    Console.WriteLine("Vuoi aggiungere altri prodotti? [si/no]");
    string scelta2 = Console.ReadLine();
    if (scelta2 == "no") flag = false;
}


foreach (Prodotto car in carrello)
{
    car.getProdotto();
}










//Prodotto prodotto = new Prodotto("pippo", "ciao come stai", 20.99 , 22);
//prodotto.getCodicePad();

//prodotto.getProdotto();

//prodotto.getPrezzoConIva();

//prodotto.getNomeEsteso();

//bool flagChange = false;
//string scelta;

//Console.WriteLine("vuoi cambiare qualcosa? [si,no]");
//scelta = Console.ReadLine();
//if(scelta == "si")
//{
//    flagChange = true;
//};

//while (flagChange)
//{
//    Console.WriteLine("Cosa vuoi cambiare? [nome,descrizione,prezzo,iva]");
//    scelta= Console.ReadLine();
//    if (scelta == "nome")
//    {
//        string s = Console.ReadLine();
//        prodotto.setNome(s);

//    }else if (scelta == "descrizione")
//    {
//        string s = Console.ReadLine();
//        prodotto.setDescrizione(s);

//    }
//    else if (scelta == "prezzo")
//    {
//        double prezzoNew = double.Parse(Console.ReadLine());
//        prodotto.setPrezzo(prezzoNew);
//    }
//    else if (scelta == "iva")
//    {
//        int ivaNew = Int32.Parse(Console.ReadLine());
//        prodotto.setIva(ivaNew);
//    }
//    else
//    {
//        Console.WriteLine("Scelta non valida.");
//    }

//    Console.WriteLine("vuoi cambiare altro? [si,no]");
//    scelta = Console.ReadLine();

//    if (scelta == "no")
//    {
//        flagChange = false;
//        prodotto.getProdotto();
//    };


//};



