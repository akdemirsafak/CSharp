// Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan 
//ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
using System.Collections;

ArrayList list=new ArrayList();
for (var i = 0; i < 10; i++)
{
    System.Console.Write("Sayı giriniz : ");
    list.Add(Convert.ToInt32(Console.ReadLine()));
    
}
ArrayList minValues=new ArrayList();
ArrayList maxValues=new ArrayList();

list.Sort();

for (var i = 0; i < 3; i++)
{
    minValues.Add(list[i]);
}
    
    maxValues.Add(list[list.Count-1]);
    maxValues.Add(list[list.Count-2]);
    maxValues.Add(list[list.Count-3]);

    decimal result=0;
    System.Console.WriteLine("En küçük 3 sayı : ");
    foreach (int item in minValues)
    {
        System.Console.WriteLine(item);
        result+=item;
    }
    System.Console.WriteLine("Ortalaması ise : ",result/3);

    System.Console.WriteLine("\n");
    result=0;
    System.Console.WriteLine("En Büyük 3 sayı : ");
    foreach (int item in maxValues)
    {
        System.Console.WriteLine(item);
        result+=item;
    }
    System.Console.WriteLine("Ortalaması ise : ",result/3);