
Console.Write("Введите Ваше имя: ");

string fullName = Console.ReadLine();

if (fullName == "Admin")
{
    Console.WriteLine("Привет");

}
else
{
    Console.WriteLine($"Я так ждала Вас, {fullName}");
}