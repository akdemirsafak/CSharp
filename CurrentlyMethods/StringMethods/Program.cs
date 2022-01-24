
string word="Hello Welcome!",other="hello Welcome!";

System.Console.WriteLine("Length : "+word.Length);
System.Console.WriteLine("ToUpper : "+word.ToUpper());
System.Console.WriteLine("ToLower : "+word.ToLower());
System.Console.WriteLine(String.Concat(word," Concat ile Birleştirdik"));
System.Console.WriteLine("\n******* CompareTo and Compare ********");
//CompareTo
System.Console.WriteLine(word.CompareTo(other)); 
//KARAKTER SAYISI iki değişken eşitse 0 döndürür. 1. değişken  2. değişkenden büyükse 1 döndürür, 2. değişken 1. değişkenden büyükse -1 döndürür.
//Compare
System.Console.WriteLine(String.Compare(word,other,true));// sondaki parametre true ise non caseSensitive hale gelir

System.Console.WriteLine(String.Compare(word,other,false)+"\n");// sondaki parametre false ise caseSensitive hale gelir

System.Console.WriteLine("\nContains");
System.Console.WriteLine(word.Contains("hello"));

System.Console.WriteLine("\nEndsWith and StartsWith");
System.Console.WriteLine(word.EndsWith("come!"));
System.Console.WriteLine(word.StartsWith("Hello"));

System.Console.WriteLine("\nIndexOf");
System.Console.WriteLine(word.IndexOf("x")); //varsa ilk bulduğunun indexini döner yoksa -1 döner.
System.Console.WriteLine(word.LastIndexOf("x")); //aramaya sondan başlar

System.Console.WriteLine("\nInsert");
System.Console.WriteLine(word.Insert(word.Length,"x")); //(index,karakter) karakteri verilen index 'e ekler.


System.Console.WriteLine("\nPadLeft and PadRight");
System.Console.WriteLine(word.PadLeft(30)); //eğer string ifadedeki karakter sayısı 30 dan küçükse 30 a tamamlayacak kadar sola boşluk eklenir.(ya da istediğimiz karakter)
System.Console.WriteLine(word.PadRight(30,'*'));//yukardakinin sağa ekleyeni

System.Console.WriteLine("\nRemove");
System.Console.WriteLine(word.Remove(3,3)); //Verilen indeksten sonraki 5 karakteri siler.
System.Console.WriteLine(word.Remove(10)); //Verilen indeksten sonraki kısmı siler.

System.Console.WriteLine("\nReplace");
System.Console.WriteLine(word.Replace("Hello","Merhaba")); //eski deger,yeni deger

System.Console.WriteLine("\nSplit");
System.Console.WriteLine(word.Split(' ')[1]); //Boşluklara göre parçalara ayır 1. indexteki parçayı getir.


System.Console.WriteLine("\nSubString");
System.Console.WriteLine(word.Substring(4)); //4. indexten sonrasını getirir.

System.Console.WriteLine(word.Substring(4,6)); //4. indexten sonra 6 karakter getirir.

