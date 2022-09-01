class Login
{
	int cur = 0;
	User[] arr = new User[0];
	public void show()
	{
		for (int i = 0; i < arr.Length; i++)
		{
			Console.WriteLine($"{i + 1}.______________________________");
			arr[i].ShowUserProperty();
			Console.WriteLine("______________________________");
		}
	}

	public bool CheckOnlyUsername(string username)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i].Username == username)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nThis \"Username\" is already exist !\n");
				Console.ForegroundColor = ConsoleColor.White;
				return false;
			}
		}

		return true;
	}

	public bool CheckLog(string Username, string Password)
	{

		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i].Username == Username && arr[i].Password == Password)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\nYou Entered !\n");
				Console.ForegroundColor = ConsoleColor.White;

				return true;
			}
		}

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nInvalid Username or Password !");
		Console.ForegroundColor = ConsoleColor.White;
		return false;
	}
	
	public void Add(User data)
	{
		Array.Resize(ref arr, arr.Length + 1);
		arr[cur] = data;
		++cur;
	}

	public void Remove(int index)
	{

		if (cur == 0)
			return;

		if (index > cur || index < 0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nNumber not found !\n");
			Console.ForegroundColor = ConsoleColor.White;

			return;
		}

		index -= 1;
		User[] temp = new User[cur - 1];
		for (int i = 0; i < index; i++)
			temp[i] = arr[i];

		for (int i = index + 1, i2 = index; i < arr.Length; i++, i2++)
			temp[i2] = arr[i];

		--cur;
		arr = temp;
	}
}