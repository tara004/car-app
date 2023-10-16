// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

prima_app.Auto miaAuto;

miaAuto = new prima_app.Auto("Fiat", "Multipla", "Argento", prima_app.Auto.Motore.benzina);

miaAuto.StampaMenu();

Console.ReadLine();

