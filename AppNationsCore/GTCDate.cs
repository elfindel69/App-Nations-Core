namespace AppNationsCore
{
	/**
	 * Class GTCDate - gestion des dates GTC
	 * @Author : elfindel69
	 * @version: 0.0.1
	 **/
	internal class GTCDate
	{
		public int Year { get; set;}

		public int Month { get; set; }

		public int Day { get; set; }

		public int Hour { get; set; }

		public int Minute { get; set;  }

		public int Second { get; set; }

		public GTCDate() { }

		//constructor with parameters
		public GTCDate(int lYear, int lMonth, int lDay, int lHour, int lMinute, int lSecond)
		{
			Year = lYear;
			Month = lMonth;
			Day = lDay;
			Hour = lHour;
			Minute = lMinute;
			Second = lSecond;
		}

		//date constructor
		public GTCDate(int lYear, int lMonth, int lDay)
		{
			Year = lYear;
			Month = lMonth;
			Day = lDay;
			Hour = 0;
			Minute = 0;
			Second = 0;
		}

		//returns formatted date
		public override string ToString() {
			if (Hour > 0 &&Minute >0 && Second > 0)
			{
				return Year + "-" + CompZero(Month) + "-" + CompZero(Day) + 'T' + CompZero(Hour) + ":" + CompZero(Minute) + ":" + CompZero(Second) + " GTC";
			}
			else
			{
				return Year + "-" + CompZero(Month) + "-" + CompZero(Day) + " GTC";
			}
		}

		public static string CompZero(int nombre)
		{
			return nombre < 10 ? "0" + nombre : nombre.ToString();
		}
	}
}