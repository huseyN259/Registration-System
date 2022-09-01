class Program
{
	static void Main()
	{
		string start = "========== WELCOME TO REGISTRATION SYSTEM ==========";
		Console.WriteLine(start.PadLeft(75));
		Thread.Sleep(2000);
		Console.WriteLine("\nLoading...");
		Thread.Sleep(2000);
		Console.Clear();

		while (true)
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;

			Login list = new Login();
			Console.WriteLine("DO YOU WANT TO REGISTER ?\nStart -> [2]\nExit -> [1]");
			int selection = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			if (selection == 2)
			{
				User person = new User();
				person.Create();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\nPerson passed registration successfully !\n");
				Console.ForegroundColor = ConsoleColor.White;
				list.Add(person);

				while (true)
				{
					Console.WriteLine("\nLog In Select -> [1]\nLog Up Select -> [2]\nShow List Select -> [3]\nDelete Person By List Number Select -> [4]\nExit -> [5]");
					selection = Convert.ToInt32(Console.ReadLine());
					Console.Clear();

					if (selection == 1)
					{
						string Username; string Password;
						do
						{
							Console.Write("Username : ");
							Username = Console.ReadLine();
							Console.Write("Password : ");
							Password = Console.ReadLine();
							Console.Clear();
						}
						while (!list.CheckLog(Username, Password));
					}
					else if (selection == 2)
					{
						person = new User();
						do
						{
							person.Create();
						} while (!list.CheckOnlyUsername(person.Username));

						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("\nPerson passed registration successfully !\n");
						Console.ForegroundColor = ConsoleColor.White;
						list.Add(person);
					}
					else if (selection == 3)
						list.show();
					else if (selection == 4)
					{
						Console.Write("Write number of person in list : ");
						int index = Convert.ToInt32(Console.ReadLine());
						list.Remove(index);
					}
					else if (selection == 5)
						Environment.Exit(0);
					else
						Console.WriteLine("You can select only 1 or 2 !");
				}
			}
			else if (selection == 1)
			{	
				Console.WriteLine("\nYou left the system !\n");
				break;
			}
			else
				Console.WriteLine("\nYou can select only 1 or 2 !\n");
		}
	}
}