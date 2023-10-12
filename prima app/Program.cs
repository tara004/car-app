// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Auto miaAuto;

miaAuto = new Auto();

miaAuto.stampa();

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

	public void stampa(){
		//stampo le caratteristiche dell'auto
		Console.WriteLine("marca: " + this.marca); 
		Console.WriteLine("modello: " + this.modello); 
		Console.WriteLine("motore: " + this.tipoMotore); 
		Console.WriteLine("colore: " + this.colore);
	}
}