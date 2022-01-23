
int[] myArray={1,23,35,49,5};


// Sort Order
//Array.Sort(myArray);


//IndexOf : Aranan elemanın indexini döndürür.
//System.Console.WriteLine(Array.IndexOf(myArray,49));


//Clear : Verilen indexten verilen sayı kadar item siler.
//Array.Clear(myArray,2,2);


//Reverse : Diziyi ters çevirir.
//Array.Reverse(myArray);


//Resize: Array'in yeniden boyutlandırmasına yarar.
Array.Resize<int>(ref myArray,6);
myArray[5]=99;


foreach (var item in myArray)

{
    System.Console.WriteLine(item);
}


