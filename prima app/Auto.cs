using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
	class Auto
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
		public int livelloCarburante;
		/// <summary>
		/// Marca del veicolo
		/// </summary>
		public string marca;
		public string modello;
		public string colore;
		public Motore tipoMotore;

		private bool accesa;

		#endregion

		#region  " metodi "

		//costruttore
		public Auto()
		{
			this.marca = "Fiat";
			this.modello = "Punto";
			this.tipoMotore = Motore.diesel;
			this.colore = "Rosso";
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
			this.marca = marca;
			this.modello = modello;
			this.colore = colore;
			this.tipoMotore = tipoMotore;
			this.livelloCarburante = 10;
		}

		/// <summary>
		/// Gestisce il menu delle opzioni
		/// </summary>
		public void StampaMenu()
		{
			string Comando;

			do
			{
				//stampo il menu
				this.Menu();

				//leggo l'input dell'utente
				Comando = Console.ReadLine();

				//chiamo il metodo scelto dall'utente
				switch (Comando)
				{
					case "1":
						//accendo l'auto
						this.Accendi();
						//stampo lo stato
						this.StampaStato();
						break;
					case "2":
						//spengo l'auto
						this.Spegni();
						//stampo lo stato
						this.StampaStato();
						break;
					case "3":
						//rifornisco l'auto
						//this.;
						//stampo lo stato
						this.StampaStato();

						break;
					case "0":
						//esco
						break;
					default:
						//continuo il ciclo
						break;
				}
				//se l'utente ha inserito "0", esco
			} while (Comando != "0");
		}

		/// <summary>
		/// Stampa il menu
		/// </summary>
		private void Menu(){
			Console.WriteLine("Seleziona un comando");
			Console.WriteLine("1) Accendi");
			Console.WriteLine("2) Spegni");
			Console.WriteLine("3) Rifornisci");
			Console.WriteLine("0) Esci");

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
		/// Tenta di avviare il veicolo <para>
		/// Se non c'è carburante l'accensione fallisce</para>
		/// </summary>
		public void Accendi()
		{
			//verifico il livello del carburante
			if (this.livelloCarburante > 0)
			{
				//se è maggiore di zero accendo il veicolo
				this.accesa = true;
			}
			else
			{
				//se è minore o uguale a zero spengo il veicolo
				this.accesa = false;
			}
		}

		/// <summary>
		/// Spegne il veicolo
		/// </summary>
		public void Spegni()
		{
			//spegne il veicolo
			this.accesa = false;
		}

		#endregion
	}
}
