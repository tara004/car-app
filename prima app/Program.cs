// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Auto miaAuto;

miaAuto = new Auto();

miaAuto.StampaDescrizione();

Console.ReadLine();

class Auto {
	//tipi personalizzati
	public enum motore {
		benzina,
		diesel,
		elettrico
	}

	//proprietà
	public string marca;
	public string modello;
	public string colore;
	public motore tipoMotore;

	//costruttore
	public Auto(){
		this.marca = "Fiat";
		this.modello = "Punto";
		this.tipoMotore = motore.diesel;
		this.colore = "Rosso";
	}

	public void StampaDescrizione()
	{
		//stampo le caratteristiche dell'auto
		Console.WriteLine(GeneraDescrizione());
	}

	public string GeneraDescrizione()
	{
		//dichiarazione variabili
		string result;

		//costruisco il risultato concatenando le descrizioni
		result = "marca: " + this.marca +"\n";
		result += $"modello: {this.modello} \n";
		result += $"motore: {this.tipoMotore} \n";
		//result += ("motore: {0} \n", this.tipoMotore);
		result += "colore: " + this.colore;

		//restituisco il risultato
		return result;
	}
}