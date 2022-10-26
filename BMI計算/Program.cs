using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI計算
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double height = 0;
			double weight = 0;
			try
			{ 
				height = GetHeight();
			}
			catch(Exception ex)
			{ 
				Console.WriteLine(ex.Message); 
				return;
			}


			try
			{
				weight = GetWeight();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return ;
			}


			string BMI = BMIcalc(height, weight);
			
			Display(BMI);

		}

		private static void Display(string BMI)
		{
			Console.WriteLine($"您的BMI為: {BMI}"); ;
		}

		private static string BMIcalc(double height, double weight)
		{
			string BMI = (weight/Math.Pow(height,2)).ToString("0.0");
			return BMI;
		}

		private static double GetWeight()
		{
			Console.Write("請輸入體重(公斤): ");
			string weight = Console.ReadLine();
			
			return GetValue(weight);
		}

		private static double GetHeight()
		{
			Console.Write("請輸入身高(公尺): ");
			string height = Console.ReadLine();
			
			return GetValue(height);
			
		}
		private static double GetValue(string input)
		{
			bool isDouble = double.TryParse(input, out double value);
			
			return isDouble ? value : throw new Exception("請輸入數字");
		}
	}
}
