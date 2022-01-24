/********************************
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
 *******************************/

// System.Console.Write("Pozitif bir sayı giriniz : ");
// int n=0,sayi;

// List<int> myList=new List<int>();

// try{n=Convert.ToInt32(Console.ReadLine());}
// catch
// {System.Console.WriteLine("Bu sayı değil.");}

// if (n!>0)
// {
//     System.Console.WriteLine("Sayı pozitif değil.");
// }

// for (int i = 0; i < n; i++)
// {
    
//    System.Console.Write("{0}. Sayıyı girdin kaldı {1}: ",i+1,n-i);
   
//    try
//    {
//         sayi=Convert.ToInt32(Console.ReadLine());
//         if(sayi<=0){
//                 System.Console.WriteLine("Negatif veya 0 giremezsin.");break;}   
//         else
//         {
//             if(sayi%2==0)
//             {myList.Add(sayi);}
//         }
//    }
//    catch //(System.Exception ex)
//    {
//        System.Console.WriteLine("Sayısal bir değer girmeliydin.");
//    }

// }
// myList.ForEach(x=>System.Console.WriteLine(x));



/********************************Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
 Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.***********************/

// System.Console.Write("Kaç adet sayı gireceksiniz : ");
// int n=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Kaça bölünebilirliğini denetlemek istiyorsunuz : ");
// int m=Convert.ToInt32(Console.ReadLine());

// List<int> myList=new List<int>();
// for (int i = 0; i < n; i++)
// {
//     Console.Write("Sayı girin : ");
//     int input=Convert.ToInt32(Console.ReadLine());
//     if(input%m==0)
//     {
//         myList.Add(input);
//     }
    
// }
// System.Console.WriteLine("************ aşağıdaki sayılar {0} a tam bölünür.",m);

// myList.ForEach(x=>System.Console.WriteLine(x));



/**************************************
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*************************************/

// List<string> wordList=new List<string>();
// System.Console.Write("Kaç adet kelime gireceksiniz : ");
// try
// {
//     int y=Convert.ToInt32(Console.ReadLine());
//     if (y<=0)
//     {
//         System.Console.WriteLine("Pozitif bir sayı girmediniz.");
//     }
//     else
//     {
//         for (int i = 0; i < y; i++)
//         {
//             System.Console.Write("Kelimeyi giriniz : ");

//             string word=Console.ReadLine()!;
//             wordList.Add(word!);

//         }
        
//     }
// }
// catch
// {
//     System.Console.WriteLine("Sayı girmediniz.");
// }
// wordList.Reverse();
// wordList.ForEach(x=>System.Console.WriteLine(x));




//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

System.Console.WriteLine("Bir cümle yazınız.");
string kelime=Console.ReadLine()!.TrimEnd().TrimStart();
List<string> myWords=new List<string>();


myWords.AddRange(kelime.Split(' '));

System.Console.WriteLine("Kelime sayısı : "+myWords.Count);
System.Console.WriteLine("Karakter sayısı"+(kelime.Length-(myWords.Count-1)));

