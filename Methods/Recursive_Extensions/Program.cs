//Recursive - Öz Yinelemeli methodlar

//Kendi kendini çağıran methodlardır for döngüleriyle yapılabilir
//en çok kullanılan alanı üs alma işlemleridir.

//example 3^4

int result=1;
for (int i = 1; i < 5; i++){
    result*=3;
    
}
System.Console.WriteLine(result);
Islemler islemler=new();
System.Console.WriteLine(islemler.Expo(3,4));



// ********* Extensions(Genişletilmiş) Method Kullanımı ******

//Aynı kodu defalarca yazmak yerine her yerden erişebileceğimiz kullanımı kolay methodlardır.
//Çok kullanılırlar.
//Dikkat etmemiz gereken kurallar:
    //Static class içerisinde static bir method olarak yazılmalılardır.
    //Extension method'da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

    string word="Travis Scott ButterFly Effect";
    System.Console.WriteLine(word.CheckSpaces());
     if (word.CheckSpaces())
     {
        System.Console.WriteLine(word.RemoveWhiteSpaces());
     }

        System.Console.WriteLine(word.MakeUpperCase());
        System.Console.WriteLine(word.MakeLowerCase());
        int[] myArray={1,5,3,8,7,2,10};
        myArray.SortArray();
        myArray.printArray();
        System.Console.WriteLine(word.FirstChar());
        System.Console.WriteLine(myArray[2].isEvenNumber());
    public class Islemler
    {
        public int Expo(int number, int n) //Recursive method
        {
            if (n==0)
            {
                return 1;
            }
            else if (n<2)
            {
                return number;
            }
            else
            {
                return Expo(number,n-1)*number;//IMPORTANT HERE
            }
        }
   
    }
    public static class Extensions{ //method ve classlar static olmalı!

        public static bool CheckSpaces(this string parameter)
        {
            return parameter.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string parameter)
        {
            return parameter.Replace(" ",string.Empty);
        }
        public static string MakeUpperCase(this string parameter)
        {
            return parameter.ToUpper();
        }
        public static string MakeLowerCase(this string parameter)
        {
            return parameter.ToLower();
        }
        public static void SortArray(this int[] parameter)
        {
            Array.Sort(parameter);
        }
        public static void printArray(this int[] parameter)
        {
            foreach (var item in parameter)
            {
                System.Console.WriteLine(item);
            }
        }
        public static bool isEvenNumber(this int parameter)
        {
            return parameter%2==0;
        }
        public static char FirstChar(this string parameter)
        {
            return parameter.First();
        }
       
    }
