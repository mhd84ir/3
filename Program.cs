int money;

System.Console.WriteLine("hoghogh khod ra vared konid");

money = Convert.ToInt32(Console.ReadLine());


if (money < 2000000)
{
    System.Console.WriteLine("shoma moaf hastid");

}

else if (money > 2000000 && money < 3000000)
{
    System.Console.WriteLine(money * 0.05);

}

else
{

    System.Console.WriteLine(money * 0.07);

}


