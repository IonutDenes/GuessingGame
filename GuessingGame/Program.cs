using System;
namespace Ionut06
{
	class Program
	{
		static void Main(string[] args)
		{
			string Dev = "Ionut";
			string Version = "1.0";
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Made by: " + Dev + " App Version: " + Version);
			Console.ResetColor();
			Console.WriteLine("Hello! What's your name?");
			string input = Console.ReadLine();
			Console.WriteLine("Hello! " + input + " I want to play a guessing game");
			Random random = new Random();
			int RandomNum = random.Next(1, 10);
			Console.WriteLine("Guess the number between 1 and 10 :)");
			string inputanswer = "Y";
			while (inputanswer != "N")
			{
				int guessNum = 0;
				while (guessNum != RandomNum)
				{
					string inputNum = Console.ReadLine();
					if (!int.TryParse(inputNum, out guessNum))
					{
						Console.ForegroundColor = ConsoleColor.DarkMagenta;
						Console.WriteLine("You must enter a number between 1 and 10");
						Console.ResetColor();
						continue;
					}

					guessNum = Int32.Parse(inputNum);
					if (guessNum != RandomNum)
					{
						Console.ForegroundColor = ConsoleColor.DarkRed;
						Console.WriteLine("Wrong number, guess again!");
						Console.ResetColor();
					}
				}

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("You are CORRECT !!!");
				Console.ResetColor();
				Console.WriteLine();
				Console.WriteLine();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Do you want to play Again?");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("Y / N");
				Console.ResetColor();
				inputanswer = Console.ReadLine().ToUpper();

				if (inputanswer == "Y")
				{
					continue;
				}
				else if (inputanswer == "N")
				{
					return;
				}
				else
				{
					return;
				}
            }
        }
	}
}