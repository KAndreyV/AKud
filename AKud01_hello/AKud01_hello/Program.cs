Console.WriteLine("Hello, World!!!!!!!!");
Console.WriteLine("I'm Andrey!");
Console.WriteLine();

// С арифметикой все ясно
int x = 2;
int y = 2;
int summa = x + y;
Console.WriteLine(summa);

// Обработка строк
string firstName = "Andrey";
string lastName = "Kudimov";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string someName = "Vasya Pupkin";
int spacePosition = someName.IndexOf(" ");
firstName = someName.Substring(0, spacePosition);
lastName = someName.Substring(spacePosition + 1);
Console.WriteLine(firstName);
Console.WriteLine(lastName);

//Сгенерируйте, вычислите и выведите переменную, значение которой V.Pupkin
string nameWithPointMe = someName.Substring(0,1) + "." + lastName;
string nameWithPoint = firstName.Substring(0, 1) + "." + lastName;
Console.WriteLine(nameWithPointMe);
Console.WriteLine(nameWithPoint);

//Ветвление
double temperature = -1.1;
if (temperature < -10)
{
    Console.WriteLine("Ужасно холодно!");
}

if (temperature >= -10 && temperature <= 0)
{
    Console.WriteLine("Холодновато!");
}

if (temperature >= 0 && temperature < 10)
{
    Console.WriteLine("Прохладно!");
}

if (temperature >= 10)
{
    Console.WriteLine("Нормально!");
}

// Циклы
int i;
for (i = 0; i < 3; i++)
{
    Console.WriteLine("Hurrah!");
}

// Множественные данные
int[] nums = { 10, 20, 30 };
nums[1] = 200;
//Console.WriteLine(nums[1]);
for(i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]); 
}

// Найдите сумму квадратов и выведите чисел в масси nums
int summaSquare = 0;
for (i = 0; i < nums.Length; i++)
{
    summaSquare += (nums[i] * nums[i]);
}
Console.WriteLine(summaSquare);
