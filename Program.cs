using System.Security.Cryptography;

Console.Write("Password length (int): ");

int num = int.Parse(Console.ReadLine());

Console.Write("Include numbers? (Y/N): ");
char include_numbers = char.Parse(Console.ReadLine());

Console.Write("Include Symbols (Y/N): ");
char include_symbols = char.Parse(Console.ReadLine());

Console.Write("Include Caps (Y/N): ");
char include_caps = char.Parse(Console.ReadLine());

string options = "abcdefghijklmnopqrstuvwxyz";
string numbers = "0123456789";
string symbols = "!@€£#$%^&*()-_=+[]{};':\"|\\,.<>/?`~";
string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

if (include_numbers == 'y')
{
    options += numbers;
}

if (include_symbols == 'y')
{
    options += symbols;

}

if (include_caps == 'y')
{
    options += caps;
}

char[] password = new char[num];

for (int i = 0; i < num; i++)
{
    password[i] = options[RandomNumberGenerator.GetInt32(options.Length)];
}

Console.WriteLine(password);

Console.ReadLine();