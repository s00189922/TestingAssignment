using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*	Author: Aisling Mc Loughlin - S00189922
	Date: 16/03/2021
	Purpose: Console application */


namespace TestingAssignment
{
	public class Program
	{
		static double premium;

		public static void Main(string[] args)
		{ 
			
			//Variables
			string gender;
			int age=0;
			double PremiumTotal = 0;

			//input
			Write("Enter Gender: ");
			gender = Console.ReadLine();

			Write("Enter age: ");
			age = int.Parse(Console.ReadLine());

			//calling method
			PremiumTotal = CalcPremium(age, gender);

			//output
			WriteLine("Your gender is: {0}", gender);
			WriteLine("Your age is: {0}", age);
			WriteLine("Your premium is: {0}", PremiumTotal.ToString());
		}//end of main


		public double CalcPremium(int age, string gender)
		{
			premium = 0;

			if (gender == "female")
			{
				if ((age >= 18) && (age <= 30))
				{
					premium = 5.0;
				}
				else if (age >= 31)
				{
					premium = 3.50;
				}
				else if (age >= 50)
				{
					premium = premium / 2;
				}
				else
				{
					premium = 0.0;
				}
			}//end of if statement

			if (gender == "male")
			{
				if ((age >= 18) && (age <= 35))
				{
					premium = 6.0;
				}
				else if (age >= 36)
				{
					premium = 5.0;
				}
				else if (age >= 50)
				{
					premium = premium / 2;
				}
				else
				{
					premium = 0;
				}
			}//end of if statement


			return premium;
		}
	}
}
