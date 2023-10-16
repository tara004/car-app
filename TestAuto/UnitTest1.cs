namespace TestAuto
{
	[TestClass]
	public class TestPrimaApp
	{

		/// <summary>
		/// Tests Auto.Accendi with basic constructor
		/// </summary>
		[TestMethod]
		public void TestTurnOnBasic()
		{
			//declare and initialize object
			prima_app.Auto myCar;

			myCar = new prima_app.Auto();

			//call object method
			myCar.Accendi();

			//check object state: it has to be off
			if (myCar.GeneraStato() == "carburante: 10 \naccesa\n"){
				//ok
			} else {
				//error
				throw new Exception("");
			}
		}
		/// <summary>
		/// Tests Auto.Accendi without fuel
		/// </summary>
		[TestMethod]
		public void TestTurnOnWithoutFuel()
		{
			//declare and initialize object
			prima_app.Auto myCar;

			myCar = new prima_app.Auto("", "", "", prima_app.Auto.Motore.benzina, 0);

			//call object method
			myCar.Accendi();

			//check object state: it has to be off
			if (myCar.GeneraStato() == "carburante: 0 \nspenta\n"){
				//ok
			} else {
				//error
				throw new Exception("");
			}
		}
	}
}