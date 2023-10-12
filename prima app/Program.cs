// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Auto miaAuto;

miaAuto = new Auto("Fiat", "Multipla", "Argento", Auto.motore.benzina);

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

	/// <summary>
	/// Inizializza l'oggetto
	/// </summary>
	/// <param name="marca">Marca del veicolo (es: Fiat)</param>
	/// <param name="modello">Modello del veicolo (es: Punto)</param>
	/// <param name="colore">Colore del veicolo</param>
	/// <param name="tipoMotore">Tipo di motore (a scelta fra quelli disponibili)</param>
	public Auto(string marca, string modello, string colore, motore tipoMotore){
		this.marca = marca;
		this.modello = modello;
		this.colore = colore;
		this.tipoMotore = tipoMotore;
	}

	public void StampaDescrizione()
	{
		//stampo le caratteristiche dell'auto
		Console.WriteLine(GeneraDescrizione());
	}

	/// <summary>
	/// Costruisce la descrizione completa del veicolo
	/// </summary>
	/// <returns>Stringa che contiene la descrizione</returns>
	public string GeneraDescrizione()
	{
		//dichiarazione variabili
		string result;

		//costruisco il risultato concatenando le descrizioni
		result = "marca: " + this.marca +"\n";
		result += $"modello: {this.modello} \n";
		result += $"motore: {this.tipoMotore} \n";
		result += "colore: " + this.colore;

		//restituisco il risultato
		return result;
	}
}