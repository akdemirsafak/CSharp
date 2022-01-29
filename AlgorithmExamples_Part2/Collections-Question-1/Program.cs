
// Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Text.RegularExpressions;

List<int> prime=new List<int>();

List<int> notPrime=new List<int>();


Regex regex=new Regex("[^0-9]");

for (var i = 0; i < 5; i++)
{
    System.Console.WriteLine("{0}. sayıyı giriniz",i+1);
    var input=Console.ReadLine();
    if (!String.IsNullOrEmpty(input) || !String.IsNullOrWhiteSpace(input))
    {
        
        if(regex.IsMatch(input))
        {
            System.Console.WriteLine("Sadece Sayı(Ondalıklı ve negatif olmamalı) girebilirsin");
            i--;
            continue;
        }
        else {
            int number=Convert.ToInt32(input);
            int counter=0;
            
           if (number==0 || number==1)
           {
               notPrime.Add(number);
           }
           else if(number==2)
           {
               prime.Add(number);
           }else{
                for (var j = 2; j < number; j++)
                {
                    if (number%j==0)
                    {
                        counter++;
                    }
                    
                }
                if (counter==0)
                {
                    prime.Add(number);
                }
                else{notPrime.Add(number);}
              }  
                
            
        }
    }
    else{
           System.Console.WriteLine("Sadece Sayı(Ondalıklı ve negatif olmamalı) girebilirsin");
            i--;
    }

}
    


if (prime.Count()>0)
{
prime.Sort();
System.Console.WriteLine("Asal Sayılar :");
prime.ForEach(x=>System.Console.WriteLine(x));

System.Console.WriteLine("Asal sayıların eleman sayısı {0} :  Ortalaması : {1}",prime.Count(),prime.Average());
    
}else
{
    System.Console.WriteLine("********* Hiç Asal Sayı Yok ***************");
}

if (notPrime.Count()>0)
{
    notPrime.Sort();

System.Console.WriteLine("Asal Olmayan Sayılar :");
notPrime.ForEach(x=>System.Console.WriteLine(x));
System.Console.WriteLine("Asal Olmayan sayıların eleman sayısı : {0} Ortalaması ise : {1}",notPrime.Count(),notPrime.Average());
}else{
    System.Console.WriteLine("******* Tüm Sayılar Asal ***********");
}