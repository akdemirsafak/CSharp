//Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

string input=Console.ReadLine();

string sesliHarfler="aeıioöuü";

ArrayList cumledekiSesliHarfler=new ArrayList();


foreach (var item in input)
{
    foreach (var chars in sesliHarfler)
    {
        if(item==chars)
        {
            cumledekiSesliHarfler.Add(item);
        }
    }
}

cumledekiSesliHarfler.Sort();
foreach (var item in cumledekiSesliHarfler)
{
    System.Console.WriteLine(item);
}