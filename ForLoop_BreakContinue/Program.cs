
// Console.Write("Üst sınırı giriniz : ");
// int counter=int.Parse(Console.ReadLine());
// System.Console.WriteLine("0 dan {0} dahil aralıktaki çift sayılar : ",counter);
// for (int i =1;i<=counter; i++)
// {
    
//     if (i%2==0)
//     {
//         System.Console.WriteLine(i);
//     }
// }
// System.Console.WriteLine("\n**********\n");
// int evenTotal=0,oddTotal=0;
// for (var i = 1; i < counter;i++)
// {

// if (i%2==0) evenTotal+=i; 
// else oddTotal+=i; 

// }
// System.Console.WriteLine("Tek sayıların Toplamı {0}, Çift Sayıların Toplamı: {1}",oddTotal,evenTotal);

// ********* BREAK - CONTINUE *********
System.Console.WriteLine("\n********* BREAK-CONTINUE**********\n");


Console.WriteLine("\n ****Break**** \n");
for (var i = 0; i < 10; i++){

    if (i==4)
    {
        break;
    }
    Console.Write(i+" ");
}

Console.WriteLine("\n ****Continue**** \n");
for (var i = 0; i < 10; i++){

    if (i==4)
    {
        continue;
    }
    Console.Write(i+" ");
}
System.Console.WriteLine();

// for (;;) // ;; sonsuz döngüyü ifade eder.
// {
    
// }
    
