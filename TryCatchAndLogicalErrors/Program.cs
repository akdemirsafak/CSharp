

//Compiled Time Kodu yazarken karşılaştığımız hatalar

//Run Time Errors bu Hataları oldukça handle etmemiz(ele almamız) gerekli


// Console.WriteLine("Bir integer sayı giriniz");


// try
// {
//     int sayi=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
// }
// catch (System.Exception ex)
// {
//      // TODO
//      System.Console.WriteLine("Hata : "+ ex.Message.ToString());
// }
// finally{ //finally optional (kullanmayabiliriz.)
//     System.Console.WriteLine("İşlem tamamlandı");
// }

//hataya göre kullanıcıya özel bildirimler yollayabiliriz.
System.Console.WriteLine("\n************************\n");
try
{
    //int sayi2=int.Parse(null);
    int sayi3=int.Parse("test");
    sayi3=int.Parse("-12332432424242424");
}
catch (ArgumentNullException ex)
{
     // TODO
     System.Console.WriteLine("Boş değer girildi");
     System.Console.WriteLine("Hata : "+ ex.Message);
}
catch(FormatException ex){
    System.Console.WriteLine("Hata : "+ex.Message);
    
}
catch(OverflowException ex)
{
    Console.WriteLine("Girilen değer çok küçük veya çok büyük : \n"+ ex);
}
catch(SystemException ex)
{
    System.Console.WriteLine("Another exceptions : " + ex.Message);
}
finally{System.Console.WriteLine("İşlem tamamlanmıştır.");}
