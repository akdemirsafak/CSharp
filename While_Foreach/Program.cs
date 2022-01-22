//While

//1 den n e kadar(n dahil) sayıların ortalamasını alan program
Console.Write("Tavan Sayıyı Giriniz : ");
int input=Convert.ToInt32(Console.ReadLine());
int number=1;
decimal result=0;
while(number<=input)
{
    result+=number;
    number++;
}
System.Console.WriteLine("Ortalama : "+result/input);

//a dan z ye kadar TÜM HARFLERİ yazdıran console uygulaması

char character='a';

while(character<='z')
{
    Console.Write(character + " ");
    character++;
}

System.Console.WriteLine("\n*********FOREACH*******\n");

string[] myCars={"hyundai","maserati","bmw","mercedes","skoda"};

foreach(var myCar in myCars)
{
    Console.WriteLine(myCar);
}
