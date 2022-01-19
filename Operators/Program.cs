// See https://aka.ms/new-console-template for more information


// Operators

// Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
// Mantıksal Operatörler (||, &&, !)
// İlişkisel Operatörler (==,!=, <, >, >=,<=)
// Aritmetik (+, -, *, /, %, ++, --)

int y=30;

y=y+2;
System.Console.WriteLine(y);
y+=2;
System.Console.WriteLine(y);
y*=3;
System.Console.WriteLine(y);
y/=4;
System.Console.WriteLine(y);
y-=1;
 System.Console.WriteLine(y);

bool isSuccess=true,isCompleted=false;

if (isSuccess)
{
    System.Console.WriteLine("Success");
}
if (!isCompleted)
{
    System.Console.WriteLine("Not Completed");
}
if (isSuccess || isCompleted)
{
    System.Console.WriteLine("Completed or Success");
}
isCompleted=true;
if (isSuccess && isCompleted)
{
    System.Console.WriteLine("ever true");
}


Console.WriteLine("3<5 = "+(3<5));

System.Console.WriteLine("5>=5 = "+ (5>=5));

System.Console.WriteLine("4<=5 = "+ (4<=5));
System.Console.WriteLine("10==10 = "+ (10==10));

System.Console.WriteLine("10!=10 = "+ (10!=10));

