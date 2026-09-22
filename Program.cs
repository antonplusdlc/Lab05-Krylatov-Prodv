/*Console.WriteLine("obratniy otscet");

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

Console.WriteLine();
Console.WriteLine("pramoi schet");
for (int k = 1; k <= 5; k++)
{
    Console.WriteLine(k);
}

Console.WriteLine();
Console.WriteLine("obratno");
for (int k = 5; k >= 1; k--)
{
    Console.WriteLine(k);
}

Console.WriteLine();
Console.WriteLine("chetnie chisla ot 0 do 20");
for (int k = 0; k <= 20; k += 2)
{
    Console.WriteLine(k);
}

Console.WriteLine();
Console.WriteLine("foreach str");

string word = "programming";

foreach (char letter in word)
{
    Console.Write($"{letter}");
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("glastnie");

string sentence = "Курс алгоритмизации и программирования";
string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
int vowelCnt = 0;

foreach (char letter in sentence)
{
    if (vowels.Contains(letter))
    {
        vowelCnt++;
    }
}

Console.WriteLine($"glastnix bukv: {vowelCnt}");

Console.WriteLine();
Console.WriteLine("таблица * от 1-9");

for (int row = 1; row <= 9; row++)
{
    for (int col = 1; col <= 9; col++)
    {
        Console.Write($"{row * col,4}");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("треугольник");

for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("break прерывает только внутренний цикл");

for (int row = 1; row <= 3; row++)
{
    Console.WriteLine($"внешняя интерация: {row}");
    for (int col = 1; col <= 5; col++)
    {
        if (col == 3)
        {
            break;
        }
        Console.WriteLine($"    внутренняя итерация: {col}");
    }
}*/

// TextAnalyzer

string glastnie = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
string soglastnie = "бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
string probel = " ";
int glastnieCnt = 0;
int soglastnieCnt = 0;
int probelCnt = 0;
bool zaglavBukza = false;

string menu;
do
{
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("enter punkt: ");
    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.Write("Enter предложение: ");
            string predl = Console.ReadLine();

            foreach (char da in predl)
            {
                if (glastnie.Contains(da)) glastnieCnt++;
                if (soglastnie.Contains(da)) soglastnieCnt++;
                if (probel.Contains(da)) probelCnt++;
            }

            Console.WriteLine($"Predl: {predl}\nglastnie: {glastnieCnt}\nsoglastnie: {soglastnieCnt}\nprobel: {probelCnt}\nvsego: {predl.Length}");
            glastnieCnt = 0;
            soglastnieCnt = 0;
            probelCnt = 0;
            break;
        case "2":
            Console.Write("Enter предложение: ");
            string predll = Console.ReadLine();

            for (int i = 0; i < predll.Length; i++)
            {
                if (char.IsUpper(predll[i]))
                {
                    Console.WriteLine($"FOUND! Position is: {i}\nchar: {predll[i]}");
                    zaglavBukza = true;
                    break;
                }
            }
            if (!zaglavBukza) Console.WriteLine("Заглавных букв нет");
            break;
        case "0":
            Console.WriteLine("exit.");
            break;
        default:
            Console.WriteLine("no no no mr.fish");
            break;
    }
} while (menu != "0");