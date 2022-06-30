int n1, n2;
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine(n1 % n2);
}