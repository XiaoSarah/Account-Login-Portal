// Account Set Up: set up a username and verify password

Console.WriteLine("Enter a username:");
string username = Console.ReadLine();

Console.WriteLine("Enter a password:");
string password = Console.ReadLine();

Console.WriteLine("Re-enter password:");
string verify = Console.ReadLine();

Console.WriteLine(password == verify ? "Login successful" : "Password verification failed");

// Account Login: enter username and password

Console.WriteLine("Enter your login credentials:");

Console.WriteLine("Username:");
string username_input = Console.ReadLine();

Console.WriteLine("Password:");
string password_input = Console.ReadLine();

Console.WriteLine(username_input == username && password_input == password ? "Login successful" : "Username and password do not match");