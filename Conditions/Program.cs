
int time=DateTime.Now.Hour;
if (time>=6 && time<11)
{
System.Console.WriteLine("Good Morning");
}
else if(time<=18)
{
    System.Console.WriteLine("Good afternoon");
}
else
{
    System.Console.WriteLine("Good evening");
}

System.Console.WriteLine("\n******************\n");

// 2. Exception
string result=string.Empty;
//result= (time<=18 ? "Good afternoon":"Good evening");

result= time>=6 && time<11 ? "Good Morning":time<=18 ? "Good Afternoon": "Good night";

System.Console.WriteLine(result);


