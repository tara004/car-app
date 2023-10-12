// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

prima_app.Auto miaAuto;

miaAuto = new prima_app.Auto("Fiat", "Multipla", "Argento", prima_app.Auto.motore.benzina);

miaAuto.StampaDescrizione();
miaAuto.StampaStato();

miaAuto.accendi();

miaAuto.StampaStato();

Console.ReadLine();

