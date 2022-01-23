
int a=2,b=10;
// System.Console.WriteLine(Topla(a,b));

// static int Topla(int a=0,int b=0)
// {
//     return a+b;
// }
otherMethods myMethods=new otherMethods();
//myMethods.print("Hello");


myMethods.print((a+b).ToString());
System.Console.WriteLine("Arttir ve topla: "+myMethods.ArttirveTopla(ref a,ref b));
myMethods.print((a+b).ToString());

//static bir class içerisinden sadece static methodlar erişilebilir.
//başka bir classdaki methoda erişmek istiyorsak instance i yaratılıp daha sonra çağırılmalıdır.
//method içerisindeki parametreler sadece method içerisinden erişilebilir.Eğer fonksiyon içerisindeki değişkene erişebilmek ve değiştirebilmek için ref keywordunu parametre yollarken belirtmemiz gerekli.

public class otherMethods
{
    public void print(string data){
        System.Console.WriteLine("Printle Toplandı: "+data);
    }
    public int ArttirveTopla(ref int deger,ref int deger2)
    {
        deger+=1;
        deger2+=1;
        return deger+deger2;
    }
}