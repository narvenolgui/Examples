Console.WriteLine("Введите имя подьзователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}