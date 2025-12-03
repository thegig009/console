using System;

namespace console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string name = "";
				double height = 0;
				double weight = 0;

				// รับชื่อ
				while (true)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.Write("Please enter your full name (eng): ");
					Console.ResetColor();
					name = Console.ReadLine();

					if (!string.IsNullOrWhiteSpace(name))
						break;

					Console.WriteLine("Error: Name cannot be empty. Please try again.\n");
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Hello, welcome " + name + "!");
				Console.ResetColor();

			
				while (true)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Please enter your height (cm): ");
					Console.ResetColor();
					string inputHeight = Console.ReadLine();

					if (double.TryParse(inputHeight, out height) && height > 0)
						break;

					Console.WriteLine("Error: Height must be a positive number. Please try again.\n");
				}

				while (true)
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					Console.Write("Please enter your weight (kg): ");
					Console.ResetColor();
					string inputWeight = Console.ReadLine();

					if (double.TryParse(inputWeight, out weight) && weight > 0)
						break;

					Console.WriteLine("Error: Weight must be a positive number. Please try again.\n");
				}

				
				double heightMeters = height / 100.0;
				double bmi = weight / (heightMeters * heightMeters);

				
				string result = "";
				if (bmi < 18.5) result = "Underweight";
				else if (bmi < 25) result = "Normal weight";
				else if (bmi < 30) result = "Overweight";
				else result = "Obesity";

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\n{name}, your BMI is: {bmi:F2}");
				Console.WriteLine("BMI Result: " + result);
				Console.ResetColor();

				
				Console.Write("\nPress Q to quit or Enter to continue: ");
				string exitInput = Console.ReadLine();

				if (exitInput.ToLower() == "q")
				{
					break;
				}

				Console.Clear();
			}
		}
	}
}
