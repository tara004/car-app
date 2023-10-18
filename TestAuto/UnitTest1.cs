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
			app_auto.Auto myCar;

			myCar = new app_auto.Auto();

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
			app_auto.Auto myCar;

			myCar = new app_auto.Auto("", "", "", app_auto.Auto.Motore.benzina, 0);

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

		/// <summary>
		/// Tests Auto.Accelerate
		/// </summary>
		[TestMethod]
		public void TestAccelerate()
		{
			//declare and initialize object
			app_auto.Auto myCar;

			myCar = new app_auto.Auto("", "", "", app_auto.Auto.Motore.benzina, 10);

			//test accelerate when car is turned off
			if (myCar.Accelerate(10)){
				//car is turned off and has accelerated: error
				throw new Exception("Can't accelerate car");
			}

			//call object method
			myCar.Accendi();

			//test accelerate when car is turned on
			if (myCar.Accelerate(10))
			{
				//car is turned on and has accelerated: ok
			} else {
				//car has not accelerated: error
				throw new Exception("Car haven't accelerate");
			}
		}
	}
}