// Uygulamalarda sabitleri kullanmamız gerekebilir.Birden fazla sabite ihtiyacımız olduğu durumlarda kodun okunabilirliğini arttırabilmek amaçlı kullanılır.

System.Console.WriteLine((int)Days.Friday+" indexli eleman "+Days.Friday+" dir.");

//Enumların indexi 0 dan başlar fakat deger=index diyerek başlayacağı indexi değiştirebiliriz.

int sicaklik=32;

if(sicaklik<=(int)HavaDurumu.Soguk)
{
    System.Console.WriteLine("Dışarıya çıkmak için çok soğuk, karlı veya yağmurlu olabilir.");
}
else if (sicaklik<=(int)HavaDurumu.Normal)
{
    System.Console.WriteLine("Hava soğuk değil ama yanına kalın bir şeyler alsan iyi olur :)");
}
else if(sicaklik<=(int)HavaDurumu.Sıcak)
{
    System.Console.WriteLine("Hava normal");
}
else if(sicaklik<=(int)HavaDurumu.CokSıcak)
{
    System.Console.WriteLine("Hava Sıcak");
}
else{
    System.Console.WriteLine("Kavurucu bir sıcak var...");
}


public enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday

}

public enum HavaDurumu
{
    Soguk=10,
    Normal=20,
    Sıcak=30,
    CokSıcak=40
}
