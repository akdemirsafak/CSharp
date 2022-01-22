// See https://aka.ms/new-console-template for more information

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // String myVariable=" "; //değer kadar yer kaplar
            // byte b=5; //byte type = need 1 byte storage
            // short s=5; //2 byte -32k ... 32k  
            // ushort us=5; //2byte 0 .. 65k.365

            // Int16 i16=2; //2 byte
            // int myInt=4; //4 byte 
            // Int32 myInt32=6; //4 byte
            // Int64 myInt64=8; //8 byte

            // float f=5; //4 byte
            // double d=5;//8 byte
            // decimal de=5; //16 byte

            // Char ch='s'; //2 byte

            // bool bl=true; //default false
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object obj="s1";
            object obj2=2;
            object obj3=4.3;


            string ad="Safak";
            string soyad="Akdemir";

            string adsoyad=ad+soyad;

            int number1=3;
            int number2=5;
            int result=number1*number2;

            

            //Covert Type

            string strNumber="20";

            int myNumber=Convert.ToInt32(strNumber);

            string myDate=DateTime.Now.ToString("dd.MM.yyyy");

            Console.WriteLine(number1);


            //String Examples
            string str1=string.Empty;
            //str1=null;

            string name="Name";
            string lastname="LastName";
            string fullName=name+" "+lastname;
            

            //Int Examples
            int integer1=5,integer2=3,resultInt=integer1+integer2;
            
            //Bool Example
            //bool myResult=3<5;

            //Change Var Type

            string str20="20";
            int int20=20;

            string yeniDeger=str20+ int20.ToString();
            Console.WriteLine("String Convert Example:{0}",yeniDeger);
            
            int newValue=Convert.ToInt32(str20)+int20;
            Console.WriteLine("Int Convert Example: {0}",newValue);

            int int22=int20+ int.Parse(str20);
            Console.WriteLine("Parse Example: {0}",int22);

            //datetime
            string dateTime=DateTime.Now.ToString("dd.MM.yy");
            Console.WriteLine("Date Time Example {0}",dateTime);

            //Değişen adları rakamla başlayamaz, boşluk kullanılamaz, _ harici özel karakter kullanılamaz,class vs özel isimler verilemez, CaseSensivity dir.

            //Referans türleri: string, object, class, interface, array, delegate, pointer
            //Referans tipi değişkenler null olabilirken değer tipi olanlar Initialize edilmese dahil her zaman bir değere sahiptir.

            //Değer tipi: int short long vs...


        }
    }
}
