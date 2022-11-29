// See https://aka.ms/new-console-template for more information
using CSharpShop;

Prodotto Shop1= new Prodotto();

Shop1.SetNome("Test1");
Shop1.SetDescrizione("Descrizione1");
Shop1.SetPrezo(00);
Shop1.SetIVA(0);

Console.WriteLine(Shop1.GetCodice());
Console.WriteLine(Shop1.SetNome);


