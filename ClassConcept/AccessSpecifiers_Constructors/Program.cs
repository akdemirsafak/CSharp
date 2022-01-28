//Söz Dizisi

// public class SinifAdi
// {
//     [Erişim Belirleyici] [VeriTipi] [İsim];
//     [Erişim Belirleyici] [Geri Dönüşlüyse Tipi] MethodAdi(parametreler)
//     {
//         Method Komutları
//     }
// }

//Erişim Belirleyiciler
// Public
// Private
// Internal
// Protected



//Sınıf ismiyle aynı isimde olmalıdır.Public olmalıdır Geri dönüş türü olmaz. Constructor overload edilebilir.

Calisan calisanim=new Calisan("Şafak","Akdemir","Bilgi İşlem");


public class Calisan
{

    public Calisan()
    {
        
    }
    public Calisan(string name,string lastname)
    {
     Name=name;
     LastName=lastname;   
    }
     public Calisan(string name,string lastname,string department)
    {
     Name=name;
     LastName=lastname;
     Department=department;

     System.Console.WriteLine("Çalışanın Adı Soyadı: {0} \nDepartmanı ise {1}",(Name+" "+LastName),Department);
    }
    public string Name { get; set; }
    public string LastName { get; set; }
    
    public string Department { get; set; }
    public int No { get; set; }
    
    
    
    
    
}
