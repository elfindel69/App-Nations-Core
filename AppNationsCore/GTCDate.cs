namespace AppNationsCore
{
	/**
	 * Class GTCDate - gestion des dates GTC
	 * @Author : elfindel69
	 * @version: 0.0.1
	 **/
	public class GTCDate
	{
		public int Year { get; set;}

		public int Month { get; set; }

		public int Day { get; set; }
		public GTCDate() { }

		//date constructor
		public GTCDate(int lYear, int lMonth, int lDay)
		{
			Year = lYear;
			Month = lMonth;
			Day = lDay;
		}

		//formatted date constructor
		public GTCDate(string sDate)
		{
			string[] tabDate = sDate.Split("-");
			Year = int.Parse(tabDate[0]);
			Month = int.Parse(tabDate[1]);
			Day = int.Parse(tabDate[2]);
		}
		//returns formatted date
		public override string ToString() {
				return Year + "-" + CompZero(Month) + "-" + CompZero(Day) + " GTC";
		}

		public static string CompZero(int nombre)
		{
			return nombre < 10 ? "0" + nombre : nombre.ToString();
		}
	}
}