using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
              
        
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string,string> phoneBook=new Dictionary<string, string>();
        string input;
        string name;
        string phoneNum;
        for(int i=0;i<n;i++)
        {
             input=Console.ReadLine()!;
             name=input.Split(' ')[0].ToLower();
             phoneNum=input.Split(' ')[1];
             phoneBook.Add(name,phoneNum);
              
        }
        
        for (int i = 0; i < n; i++)
        {
            name=Console.ReadLine()!;
            try
            {
                Console.WriteLine("{0}={1}",name, phoneBook[name]);
            }
            catch{
                Console.WriteLine("Not found");
            }
            
        }
        
    }
}

