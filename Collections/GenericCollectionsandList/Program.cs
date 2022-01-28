// T-> Object type

List<int> numberList=new();

numberList.Add(23);
numberList.Add(5);
numberList.Add(10);
numberList.Add(103204);
numberList.Add(65);

List<string> stringList=new();

stringList.Add("New");
stringList.Add("String");
stringList.Add("List");
stringList.Add("Hello");
stringList.Add("Black");


//Count

System.Console.WriteLine("********** Count *********");
System.Console.WriteLine(stringList.Count);
System.Console.WriteLine(numberList.Count);

foreach (var item in stringList)
{
    System.Console.WriteLine(item);
}
//farklı bir foreach
numberList.ForEach(x=>System.Console.WriteLine(x));

//listeden eleman çıkarma
numberList.Remove(4); //item
numberList.RemoveAt(2); // item index

//listede arama

numberList.Contains(1);// bulunursa true yoksa false döner.

//index ile elemana erişme
System.Console.WriteLine(numberList.BinarySearch(2));


//diziyi listle birleştirme
string[] myList={"bird","dog","cat"};

stringList.AddRange(myList);
// liste temizleme
stringList.Clear();



public class Users
{
    public string Name { get; set; }=string.Empty;
    public string LastName { get; set; }=string.Empty;
    public int Age { get; set; }
    
    
    
    
    
    
}