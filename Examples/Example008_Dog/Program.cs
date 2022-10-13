double firstFriendSpeed = new Random().Next(1, 11);
double secondFriendSpeed = new Random().Next(1, 11);
double dogSpeed = new Random().Next(10, 16);
double distants = 1500;
int friend = 1;
int minDistants = 10;
int count = 0;

Console.WriteLine("Скорость первого друга равна " + firstFriendSpeed + ", скорость второго друга - " + secondFriendSpeed + ", скорость собаки - " + dogSpeed);

while (minDistants < distants)
{
    if (friend == 1)
    {
        distants = distants - (firstFriendSpeed + secondFriendSpeed) * distants / (secondFriendSpeed + dogSpeed);
        friend = 2;
        count++;
    }
    else
    {
        distants = distants - (firstFriendSpeed + secondFriendSpeed) * distants /(firstFriendSpeed + dogSpeed);
        friend = 1;
        count++;
    }
}

Console.WriteLine("От одного друга до другого собака пробежит " + count + " раз");


