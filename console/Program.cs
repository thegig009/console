namespace console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)   
			{
				string name = "";
				int height = 0;
				int genderChoice = 0;
				int weight = 0;

				while (true)
				{
					Console.Write("Please enter your full name (eng): "); 
					name = Console.ReadLine();

					if (!string.IsNullOrWhiteSpace(name))
						break;

					Console.WriteLine("Error: Name cannot be empty. Please try again.\n");
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Hello, welcome " + name);
				Console.ResetColor();

				while (true)
				{
					Console.Write("Please enter your height (cm): ");
					string inputHeight = Console.ReadLine();

					if (int.TryParse(inputHeight, out height) && height > 0)
						break;

					Console.WriteLine("Error: Height must be a positive number. Please try again.\n");
				}

				while (true)
				{
					Console.WriteLine("\nSelect your gender:");
					Console.WriteLine("1. Male (ชาย)");
					Console.WriteLine("2. Female (หญิง)");
					Console.Write("Enter your choice (1 or 2): ");

					string genderInput = Console.ReadLine();

					if (int.TryParse(genderInput, out genderChoice) && (genderChoice == 1 || genderChoice == 2))
						break;

					Console.WriteLine("Error: Invalid choice. Please enter 1 or 2.\n");
				}

				if (genderChoice == 1)
				{
					weight = height - 100;
					Console.WriteLine("\nGender: Male");
				}
				else
				{
					weight = height - 110;
					Console.WriteLine("\nGender: Female");
				}

				Console.WriteLine("Your ideal weight is " + weight + " kg");

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
