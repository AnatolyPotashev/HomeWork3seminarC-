// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите 5-ти значное число:");
string text = Console.ReadLine();
char[] obrtext = text.ToCharArray();

Array.Reverse(obrtext); 
string finaltext = new string(obrtext);

if (finaltext == text)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("НЕ палиндром");
}

// Гуглил, часть кода не понимал как написать, сейчас получилось, разбираюсь!
