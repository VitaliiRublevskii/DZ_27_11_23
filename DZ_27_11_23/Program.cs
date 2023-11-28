

// Задание 1
Console.WriteLine("Введите число от 1 до 100");
int choice = int.Parse(Console.ReadLine());

if (choice > 0 && choice < 101)
{
    if (choice % 3 == 0 && choice % 5 == 0)
        Console.WriteLine("Fizz Buzz");
    else if (choice % 3 == 0 && choice % 5 != 0)
        Console.WriteLine("Fizz");
    else if (choice % 5 == 0 && choice % 3 != 0)
        Console.WriteLine("Buzz");
    else Console.WriteLine("Число " + choice + " не кратно 3 та не кратно 5");
}
else Console.WriteLine("Некорректний ввод");



// Задание 2
Console.WriteLine("Введите число");
float choice2 = float.Parse(Console.ReadLine());
Console.WriteLine("Введите процент");
float percent = float.Parse(Console.ReadLine());

Console.WriteLine(percent + " %  от  " + choice2 + " = " + ((choice2 * percent) / 100));




// Задание 3
Console.WriteLine("Введите 1-е число");
int one = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int two = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int three = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 4-е число");
int four = int.Parse(Console.ReadLine());
Console.WriteLine("Введенное число " + one + two + three + four);




// Задание 4
Console.WriteLine("Введите 6-значное число");
int choice4 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первый разряд");
int place1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй разряд");
int place2 = int.Parse(Console.ReadLine());

if (choice4 >= 100000 && choice4 <= 999999)
{
    int x1 = choice4 / 100000;
    int x2 = (choice4 - (x1 * 100000)) / 10000;
    int x3 = (choice4 - (x1 * 100000) - (x2 * 10000)) / 1000;
    int x4 = (choice4 - (x1 * 100000) - (x2 * 10000) - (x3 * 1000)) / 100;
    int x5 = (choice4 - (x1 * 100000) - (x2 * 10000) - (x3 * 1000) - (x4 * 100)) / 10;
    int x6 = choice4 - (x1 * 100000) - (x2 * 10000) - (x3 * 1000) - (x4 * 100) - (x5 * 10);

    Console.WriteLine(x1 + " " + x2 + " " + x3 + " " + x4 + " " + x5 + " " + x6);

    if (place1 == 1) place1 = x1;
    if (place1 == 2) place1 = x2;
    if (place1 == 3) place1 = x3;
    if (place2 == 4) place2 = x4;
    if (place2 == 5) place2 = x5;
    if (place2 == 6) place2 = x6;

    if (place1 == 1) x1 = place2;
    if (place1 == 2) x2 = place2;
    if (place1 == 3) x3 = place2;
    if (place2 == 4) x4 = place1;
    if (place2 == 5) x5 = place1;
    if (place2 == 6) x6 = place1;

    Console.WriteLine(x1 + " " + x2 + " " + x3 + " " + x4 + " " + x5 + " " + x6);
}
else Console.WriteLine("Вы указали не шестизначное число");




//  Задание 5
Console.WriteLine("Введите день");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("Введите месяц");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Введите год");
int year = int.Parse(Console.ReadLine());

if (month == 12 || month == 01 || month == 02) Console.Write("Зима ");
if (month == 03 || month == 04 || month == 05) Console.Write("Весна ");
if (month == 06 || month == 07 || month == 08) Console.Write("Лето ");
if (month == 09 || month == 10 || month == 11) Console.Write("Осень ");
int a = (14 - month) / 12;
int y = year - a;
int m = month + 12 * a - 2;
int R = 7000 + (day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12);
int dayWek = R % 7;
if (dayWek == 1) Console.Write("Понедельник");
if (dayWek == 2) Console.Write("Вторник");
if (dayWek == 3) Console.Write("Среда");
if (dayWek == 4) Console.Write("Четверг");
if (dayWek == 5) Console.Write("Пятница");
if (dayWek == 6) Console.Write("Суббота");
if (dayWek == 0) Console.Write("Воскресенье");




// Задание 6
Console.WriteLine("Введите показание температуры");
float temp = float.Parse(Console.ReadLine());
Console.WriteLine("Выберите вид градусов для перевода (1 - Фаренгейт, 2 - Цельсий)");
int choice6 = int.Parse(Console.ReadLine());

if (choice6 == 1) Console.WriteLine("Введеные вами " + temp + " градусов Цельсия = " + ((temp - 32) * 5 / 9) + " градусов по Фаренгейту");
if (choice6 == 2) Console.WriteLine("Введеные вами " + temp + " градусов по Фаренгейту = " + (temp * (9 / 5) + 32) + " градусов Цельсия");
else Console.WriteLine("Некорректный выбор");





// Задание 7
Console.WriteLine("Введите начало диапазона");
int d1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конец диапазона");
int d2 = int.Parse(Console.ReadLine());

if (d1 > d2)
{
    int d3 = d1;
    d1 = d2;
    d2 = d3;
}
Console.WriteLine("Четные числа в указанном диапазоне:");
for (int i = d1;  i <= d2; i++)
{
    if (i % 2 == 0)
        Console.Write(i + "  ");
}
    
