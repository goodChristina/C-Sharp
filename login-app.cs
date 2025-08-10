/*    Login App

Second Try --Christina R. 

Empty dictionary (DONE)
Enter username, uppercase (DONE)
No white spaces in username(DONE)
Enter password twice (DONE)
No empty space in password (Done)
Password matches (DONE)
Username and password saved in dictionary (DONE)

Happy with username spelling? --NOT YET
Make username 2<= --NOT YET
Password hidden while typing --NOT YET
EXIT

 */


using System.Text.RegularExpressions;

Dictionary<string, string> userPWDict = new Dictionary<string, string>();


// Enter username
Console.WriteLine("Please enter your username: ");
string? usernameStart = Console.ReadLine();

// If they just hit the enter button
while (usernameStart == "")
{
    Console.WriteLine("Please enter your username: ");
    usernameStart = Console.ReadLine();
}

//So they can't add spaces
string username = Regex.Replace(usernameStart ?? "", @"\s+", "").Trim().ToUpper();
Console.WriteLine($"Your username is: {username}");

// Trying everything in a while loop
while (true)
{
    //Enter passwords
    Console.WriteLine("\nPlease enter your password: ");
    string? passwordStart = Console.ReadLine();
    
    Console.WriteLine("\nPlease enter your password ONE MORE TIME: ");
    string? passwordAgain = Console.ReadLine();
    
    if (passwordStart == usernameStart || passwordStart == usernameStart)
    {
        Console.WriteLine("Your password cannot be the same as your username!");
        continue;
    }
    
    
    if (passwordStart == username || passwordStart == username)
    {
        Console.WriteLine("Your password cannot be the same as your username!");
        continue;
    }
    
    //if not matching
    if (passwordStart != passwordAgain)
    {
        Console.WriteLine("Your passwords do not match!");
        continue;
    }
    
    if (passwordStart.Contains(" "))
    {
        Console.WriteLine("Your password cannot contain spaces!");
        continue;
    }

    if (string.IsNullOrEmpty(passwordStart) || passwordStart.Contains(" "))
    {
        Console.WriteLine("Your password cannot be empty or contains spaces!");
        continue;
    }
    
    Console.WriteLine("Your new account has been created!");
    Console.WriteLine($"Password is {passwordStart}");
    
    // Adding to the dictiona
    userPWDict.Add(username, passwordStart);
    
    // foreach (var item in userPWDict)
    // {
    //     Console.WriteLine($"{item.Key}: {item.Value}");
    // }
    break; 
}

foreach (var item in userPWDict)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
