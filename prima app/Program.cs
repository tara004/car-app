// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;
using System.Reflection.Metadata.Ecma335;

Auto miaAuto;

miaAuto = new Auto("Fiat", "Multipla", "Argento", Auto.motore.benzina);

miaAuto.StampaDescrizione();
miaAuto.StampaStato();

miaAuto.accendi();

miaAuto.StampaStato();

Console.ReadLine();

class Auto {
	//tipi personalizzati

	public enum motore {
		benzina,
		diesel,
		elettrico
	}

	//proprietà
	public int livelloCarburante;
	/// <summary>
	/// Marca del veicolo
	/// </summary>
	public string marca;
	public string modello;
	public string colore;
	public motore tipoMotore;

	private bool accesa;

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

	/// <summary>
	/// Stampa la descrizione del veicolo
	/// </summary>
	public void StampaDescrizione()
	{
		//stampo le caratteristiche dell'auto
		Console.WriteLine(GeneraDescrizione());
	}
	
	/// <summary>
	/// Stampa lo stato attuale del veicolo
	/// </summary>
	public void StampaStato() {
		Console.Write(GeneraStato());
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

	/// <summary>
	/// Genera lo stato (carburante, accensione, ...) del veicolo
	/// </summary>
	/// <returns>Lo stato del veicolo</returns>
	public string GeneraStato(){
		string result;

		result = $"carburante: {this.livelloCarburante} \n";
		if (this.accesa){
			//se il veicolo è acceso, scrivo "accesa"
			result += "accesa\n";
		}else {
			//altrimenti scrivo "spenta"
			result += "spenta\n";
		}
	
		return result;
	}

	/// <summary>
	/// Tenta di avviare il veicolo <para>
	/// Se non c'è carburante l'accensione fallisce</para>
	/// </summary>
	public void accendi(){
		//verifico il livello del carburante
		if (this.livelloCarburante > 0){
			//se è maggiore di zero accendo il veicolo
			this.accesa= true;
		} else {
			//se è minore o uguale a zero spengo il veicolo
			this.accesa = false;
		}
	}

	/// <summary>
	/// Spegne il veicolo
	/// </summary>
	public void spegni(){
		//spegne il veicolo
		this.accesa = false;
	}
}