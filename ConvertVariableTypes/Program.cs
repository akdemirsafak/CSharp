// See https://aka.ms/new-console-template for more information


//Implicit Conversion(Bilinçsiz Dönüşüm)
//Düşük kapasiteli bir değişkenin kendinden yüksek kapasiteli değişkene çevrilme işlemidir.

byte a=5;

sbyte b=30;
short c=10;

int d=a+b+c;

System.Console.WriteLine("d=" +d);

long h=d;
System.Console.WriteLine("h= "+h);
float i=h;
System.Console.WriteLine("i= "+i);

string name="myName";
char ch='k';
object g=name+ch+d;
System.Console.WriteLine("g= "+g);


//Explicit Conversion(Bilinçli Dönüşüm)
//C# ın kendi kendine yapamadığı bizim Convert etmemiz gereken işlemlerdir

System.Console.WriteLine("\n************* Exclicit Conversion**********\n");

int x=4;
byte y=(byte)x;
System.Console.WriteLine("y = " +y);

int z=100;
byte t=(byte)z;
System.Console.WriteLine("t = "+t);

float myF=15.7f;
byte m=(byte)myF;
System.Console.WriteLine("f= "+m);



//ToString Method

System.Console.WriteLine("\n*********ToString********\n");

int xx=6;
string yy=xx.ToString();
System.Console.WriteLine("yy: "+yy);

string zz=(12.5f).ToString();
System.Console.WriteLine("zz : "+zz);

//System Convert
System.Console.WriteLine("\n************ System Convert ************\n");

string s1="10",s2="20";
int sayi1,sayi2,toplam;

sayi1=Convert.ToInt32(s1);
sayi2=Convert.ToInt32(s2);
toplam=sayi1+sayi2;

System.Console.WriteLine("{0} + {1} = {2}",sayi1,sayi2,toplam);

//Parse

System.Console.WriteLine("\n************ Parse Methods ************\n");

string metin1="10",metin2="10.25";
int rakam1;
double ondalikli;

rakam1=Int32.Parse(metin1); //parse string ifadeleri çevirir.

ondalikli=Int32.Parse(metin2); //parse string ifadeleri çevirir.

