using System.Collections;

ArrayList arrayList=new();
//set items
arrayList.Add("Name");
arrayList.Add(1);
arrayList.Add(true);
arrayList.Add("Hello");
arrayList.Add(12.3f);

//get items
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);
}

//AddRange add multiple items
System.Console.WriteLine("********** AddRange ********");
string[] myList={"Yellow","White","Black"};
arrayList.AddRange(myList);

//Sort : IMPORTANT. IF TYPES ARE NOT THE SAME THATS WILL RETURN ERROR.
//System.Console.WriteLine("********** Sort ********");
//arrayList.Sort(arrayList);


// System.Console.WriteLine("********** Binary Search ********");
// //Liste sıralı olmalı ki bu method u kullanabilelim.
// System.Console.WriteLine(arrayList.BinarySearch(9));



System.Console.WriteLine("********** Reverse ********");
arrayList.Reverse();
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("********** Clear ********");
arrayList.Clear();
foreach (var item in arrayList)
{
    System.Console.WriteLine(item);
}
