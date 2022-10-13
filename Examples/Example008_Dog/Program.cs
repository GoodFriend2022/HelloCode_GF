int firstFriendSpeed = new Random().Next(1, 4);
int secondFriendSpeed = new Random().Next(1, 4);
int dogSpeed = new Random().Next(5, 10);
int distants = 150;
int friend = 1;
int minDistants = 5;
int count = 0;
int x = 1;
int y = 1;

Console.Clear();

Console.WriteLine("Скорость первого друга равна " + firstFriendSpeed + ", скорость второго друга - " + secondFriendSpeed + ", скорость собаки - " + dogSpeed);

while (minDistants < distants)
{
    if (friend == 1)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("|");
        Console.SetCursorPosition(x + 1, y);
        Console.WriteLine("@");
        Console.SetCursorPosition(x + distants, y);
        Console.WriteLine("|");
        distants = distants - (firstFriendSpeed + secondFriendSpeed) * distants / (secondFriendSpeed + dogSpeed);
        friend = 2;
        count++;
        x = x + firstFriendSpeed * distants / (secondFriendSpeed + dogSpeed);
        y = y + 2;
    }
    else
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine("|");
        Console.SetCursorPosition(x + distants - 1, y);
        Console.WriteLine("@");
        Console.SetCursorPosition(x + distants, y);
        Console.WriteLine("|");
        distants = distants - (firstFriendSpeed + secondFriendSpeed) * distants / (firstFriendSpeed + dogSpeed);
        friend = 1;
        count++;
        x = x + firstFriendSpeed * distants / (firstFriendSpeed + dogSpeed);
        y = y + 2;
    }
}

Console.WriteLine("От одного друга до другого собака пробежит " + count + " раз");


