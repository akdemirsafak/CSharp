
//out değişkeninin bir ilk değeri olmak zorunda değildir.Ref kullanırken zorunludur.

string sayi="999";

bool result=int.TryParse(sayi,out int outSayi);
if(result)
{
    System.Console.WriteLine("Başarılı");
    System.Console.WriteLine(outSayi);

}else
{
    System.Console.WriteLine("başarısız");
}
Methodlar methodlar=new Methodlar();
methodlar.Topla(4,5,out int toplamSonuc);
System.Console.WriteLine(toplamSonuc);
System.Console.WriteLine("\n******** OVERLOADING ********\n");

methodlar.EkranaYaz(4);
methodlar.EkranaYaz("myName");
methodlar.EkranaYaz("myName","Surname");


public class Methodlar
{
    public void Topla(int a,int b,out int toplam)
    {
        toplam=a+b;   
    }


    //Method Overloading(Aşırı yüklenme)
    public void EkranaYaz(string data)
    {
        System.Console.WriteLine("Data");
    }
    public void EkranaYaz(int parameter)
    {
        System.Console.WriteLine(parameter.ToString());
    }
    public void EkranaYaz(string parameter,string parameter2)
    {
        System.Console.WriteLine(parameter+" "+parameter2);
    }


    
}