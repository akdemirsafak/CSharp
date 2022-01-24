//key,value  Generic Collection
using System.Collections.Generic;

//
Dictionary<int,string> myDictionary=new Dictionary<int, string>();

//Add Items
 myDictionary.Add(24,"MyName");
 myDictionary.Add(32,"BrotherName");
 myDictionary.Add(25,"FriendName");
 myDictionary.Add(27,"CousinName");

 //get Items
 System.Console.WriteLine("\n******** Get Items ***********\n");
 foreach (var item in myDictionary)
 {
     System.Console.WriteLine(item);
 }
 //Get Item
 System.Console.WriteLine("\n******** Get Item ***********\n");
 System.Console.WriteLine(myDictionary[24]);

 //Count
 System.Console.WriteLine("\n******** Items Count ***********\n");
 System.Console.WriteLine(myDictionary.Count);

 //Contains
 System.Console.WriteLine("\n******** Items Contains ***********\n");
 System.Console.WriteLine("Contains Key : "+myDictionary.ContainsKey(32));
 System.Console.WriteLine("Contains Value : "+myDictionary.ContainsValue("BrotherName"));

 //Remove
 System.Console.WriteLine("\n******** Item Remove ***********\n");
 myDictionary.Remove(27);//Working with key.27 is KEY.
 foreach (var item in myDictionary)
 {
     System.Console.WriteLine(item);
 }

 //Key  and Values
 System.Console.WriteLine("\n******** Items Keys or Values ***********\n");
 
 foreach (var item in myDictionary)
 {
     System.Console.WriteLine(item.Key);
 }
 foreach (var item in myDictionary)
 {
     System.Console.WriteLine(item.Value);
 }
