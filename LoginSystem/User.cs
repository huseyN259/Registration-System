class User
{
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public string? Username { get; set; }
	public string? PhoneNumber { get; set; }
	public string? Password { get; set; }

	public User() { }

	public User(string Name, string Surname, string Username, string phoneNUmber, string Password)
	{
		this.Name = Name;
		this.Surname = Surname;
		SetUsername(Username);
		this.PhoneNumber = phoneNUmber;
		this.Password = Password;
	}

	public bool SetUsername(string value)
	{
		if (value.Length > 6)
		{
			this.Username = value;

			return true;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("\nCount of letter must be greater than 6 !\n");
			Console.ForegroundColor = ConsoleColor.White;

			return false;
		}
	}
	
	public bool SetPassword(string value)
	{
		if (value.Length > 8)
		{
			this.Password = value;

			return true;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("\nCount of letter must be greater than 8 !\n");
			Console.ForegroundColor = ConsoleColor.White;

			return false;
		}
	}

	public void Create()
	{
		Console.Write("Name : ");
		this.Name = Console.ReadLine();

		Console.Write("Surname : ");
		this.Surname = Console.ReadLine();

		string temp;
		do
		{
			Console.Write("Username : ");
			temp = Console.ReadLine();
		} while (!SetUsername(temp));

		Console.Write("Phone Number : ");
		this.PhoneNumber = Console.ReadLine();

		do
		{
			Console.Write("Password : ");
			temp = Console.ReadLine();
		} while (!SetPassword(temp));
		Console.WriteLine();
	}

	public void ShowUserProperty()
	{
		Console.WriteLine($"Name : {Name}");
		Console.WriteLine($"Surname : {Surname}");
		Console.WriteLine($"Username : {Username}");
		Console.WriteLine($"Phone Number : {PhoneNumber}");

		Console.Write($"Password : ");
		for (int i = 0; i < Password.Length; i++)
			Console.Write("*");
		Console.WriteLine();
	}
}