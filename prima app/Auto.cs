using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace app_auto
{
	public class Auto
	{
		#region " tipi "

		//tipi personalizzati
		public enum Motore
		{
			benzina,
			diesel,
			elettrico
		}

		#endregion

		#region " proprietà "

		//proprietà
		public int livelloCarburante { get; private set; }
		private int livelloMassimoCarburante;
		public int speed { get; private set;}
		private int maximumSpeed;
		/// <summary>
		/// Marca del veicolo
		/// </summary>
		public string marca;
		public string modello;
		public string colore;
		public Motore tipoMotore;

		public bool accesa { get; private set;}

		#endregion

		#region  " costruttori "

		//costruttore
		public Auto()
		{
			this.Init("Fiat", "Punto", "Rosso", Motore.benzina, 10);
		}

		/// <summary>
		/// Inizializza l'oggetto
		/// </summary>
		/// <param name="marca">Marca del veicolo (es: Fiat)</param>
		/// <param name="modello">Modello del veicolo (es: Punto)</param>
		/// <param name="colore">Colore del veicolo</param>
		/// <param name="tipoMotore">Tipo di motore (a scelta fra quelli disponibili)</param>
		public Auto(string marca, string modello, string colore, Motore tipoMotore)
		{
			this.Init(marca, modello, colore, tipoMotore, 10);
		}

		/// <summary>
		/// Inizializza l'oggetto
		/// </summary>
		/// <param name="marca">Marca del veicolo (es: Fiat)</param>
		/// <param name="modello">Modello del veicolo (es: Punto)</param>
		/// <param name="colore">Colore del veicolo</param>
		/// <param name="tipoMotore">Tipo di motore (a scelta fra quelli disponibili)</param>
		/// <param name="carburante">Quantità di carburante presente nel serbatoio</param>
		public Auto(string marca, string modello, string colore, Motore tipoMotore, int carburante)
		{
			this.Init(marca, modello, colore, tipoMotore, carburante);
		}
		
		/// <summary>
		/// Inizializza l'oggetto
		/// </summary>
		/// <param name="marca">Marca del veicolo (es: Fiat)</param>
		/// <param name="modello">Modello del veicolo (es: Punto)</param>
		/// <param name="colore">Colore del veicolo</param>
		/// <param name="tipoMotore">Tipo di motore (a scelta fra quelli disponibili)</param>
		/// <param name="carburante">Quantità di carburante presente nel serbatoio</param>
		private void Init(string marca, string modello, string colore, Motore tipoMotore, int carburante)
		{
			this.marca = marca;
			this.modello = modello;
			this.colore = colore;
			this.tipoMotore = tipoMotore;
			this.livelloCarburante = carburante;
			this.livelloMassimoCarburante = 100;
			this.speed = 0;
			this.maximumSpeed = 300;
		}

		#endregion

		#region " metodi "

		/// <summary>
		/// Decelerate the vehicle
		/// </summary>
		/// <param name="value">Amount of speed to decrease</param>
		/// <returns>True if operation succeded<para>False if operation fails</para></returns>
		public bool Decelerate(int value)
		{
			bool result;

			//if the car is on, accelerate
			if (this.accesa){
				//increment the car speed
				//if the speed is over the maximum, limit the speed
				this.speed = Math.Max(this.speed - value, 0);

				result = true;
			}
			else {
			//notify the caller that the method failed
				result = false;
			}

			return result;
		}

		/// <summary>
		/// Accelerate the vehicle
		/// </summary>
		/// <param name="value">Amount of speed to increase</param>
		/// <returns>True if operation succeded<para>False if operation fails</para></returns>
		public bool Accelerate(int value)
		{
			bool result;

			//if the car is on, accelerate
			if (this.accesa){
				//increment the car speed
				this.speed += value;
				//if the speed is over the maximum, limit the speed
				this.speed = Math.Min(this.speed, this.maximumSpeed);

				this.ReduceFuel(value);

				result = true;
			}
			else {
			//notify the caller that the method failed
				result = false;
			}

			return result;
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
		public void StampaStato()
		{
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
			result = "marca: " + this.marca + "\n";
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
		public string GeneraStato()
		{
			string result;

			result = $"carburante: {this.livelloCarburante} \n";
			if (this.accesa)
			{
				//se il veicolo è acceso, scrivo "accesa"
				result += "accesa\n";
			}
			else
			{
				//altrimenti scrivo "spenta"
				result += "spenta\n";
			}

			return result;
		}

		/// <summary>
		/// Attempt to start the vehicle <para>
		/// If there is no fuel, the ignition fails</para>
		/// </summary>
		public void TurnOn()
		{
			//check fuel level
			if (this.livelloCarburante > 0)
			{
				//se è maggiore di zero accendo il veicolo
				this.accesa = true;
				ReduceFuel(1);
			}
			else
			{
				//se è minore o uguale a zero spengo il veicolo
				this.accesa = false;
			}
		}

		/// <summary>
		/// Reduce che fuel
		/// </summary>
		/// <param name="value">Amount of fuel to reduce</param>
		private void ReduceFuel(int value)
		{
			//reduce fuel level
			this.livelloCarburante = Math.Max(this.livelloCarburante - value, 0);
			//if the fuel reaches 0, turn off the car
			if (this.livelloCarburante <= 0) {
				this.TurnOff();
			}
		}

		/// <summary>
		/// Spegne il veicolo
		/// </summary>
		public void TurnOff()
		{
			//spegne il veicolo
			this.accesa = false;
			this.speed = 0;
		}

		/// <summary>
		/// Aggiunge carburante all'auto
		/// </summary>
		/// <param name="carburante">Quantità di carburante da aggiungere</param>
		public void Rifornisci(int carburante){
			//se il valore è positivo, lo aggiungo
			if (carburante > 0){
				this.livelloCarburante += carburante;
				this.livelloCarburante = Math.Min(this.livelloMassimoCarburante
				, this.livelloCarburante);
			}
		}

		#endregion
	}
}
