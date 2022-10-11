Console.Write("Введите имя пользователя  ");
string username = Console.ReadLine();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Да не уж то наша Даша почтила нас своим присутствием!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

