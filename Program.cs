Console.WriteLine("obratniy otscet");

int countdown = 5;
while (countdown >= 1)
{
    Console.WriteLine(countdown);
    countdown--;
}
Console.WriteLine("start!");

Console.WriteLine();
Console.WriteLine("summa ot 1 do 10");

int num = 1;
int sum = 0;

while (num <= 10)
{
    sum += num;
    num++;
}

Console.WriteLine($"sum: {sum}");

Console.WriteLine();
Console.WriteLine("beskonechii while");

int i = 1;
while (i <= 5)
{
    Console.WriteLine($"{i}");
    i++;
}

Console.WriteLine();
Console.WriteLine("Validation vvoda cherez while");
bool isValid = false;
int enteredAge = 0;

while (!isValid)
{
    Console.Write("enter your age (int, not float!): ");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out enteredAge);

    if (!isValid)
    {
        Console.WriteLine("ITS NOT INT");
    }
}
Console.WriteLine($"vozrast: {enteredAge}");

Console.WriteLine();
Console.WriteLine("menu (bez vizoda odin prohod)");

string menuChoice;
do
{
    Console.WriteLine("1 - date");
    Console.WriteLine("2 - hello");
    Console.WriteLine("0 - exit");
    Console.Write("enter punkt: ");
    menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            Console.WriteLine($"today: {DateTime.Now:dd.MM.yyyy}");
            break;
        case "2":
            Console.WriteLine($"hello!");
            break;
        case "0":
            Console.WriteLine("exit.");
            break;
        default:
            Console.WriteLine("no no no mr.fish");
            break;
    }
} while (menuChoice != "0");