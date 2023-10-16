using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prima_app
{
	internal class AutoInterattiva : prima_app.Auto
	{

		public AutoInterattiva() {
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
						//chiedo all'utente quanto carburante vuole aggiungere
						//rifornisco l'auto
						this.Rifornisci(this.ChiediCarburante());
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
		/// Chiede all'utente quanto carburante immettere nel serbatoio
		/// </summary>
		/// <returns></returns>
		private int ChiediCarburante(){
			int result;

			Console.WriteLine("Quanto carburante vuoi aggiungere?");

			result = Int32.Parse(Console.ReadLine());

			return result;
		}

		/// <summary>
		/// Stampa il menu
		/// </summary>
		private void Menu()
		{
			Console.WriteLine("Seleziona un comando");
			Console.WriteLine("1) Accendi");
			Console.WriteLine("2) Spegni");
			Console.WriteLine("3) Rifornisci");
			Console.WriteLine("0) Esci");

		}
	}
}
