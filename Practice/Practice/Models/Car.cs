using System;
namespace Practice.Models
{
	public class Car
	{
		public string color;
		public int speed;
		private string vin = "salam";
		public string Vin
		{

			get
			{
				if (speed > 450)
				{
					return vin;
				}
				return null;
			}


			set
			{
				vin = value;

			}
		}
	}
}

