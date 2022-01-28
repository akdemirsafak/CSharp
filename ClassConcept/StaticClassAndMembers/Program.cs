
//Statik olmayan classlara ve içerdiği methodlara,property ve fieldlara oluşabilmek için o sınıfan oluşturulan nesne üzerinden ulaşırız.
//statik olan sınıflara da class.method gibi ulaşılabilir.


System.Console.WriteLine("Number of Employees: "+ Employee.NumberOfEmployees);

Employee employee=new Employee("Name","LastName","HR");
System.Console.WriteLine("Number of Employees : "+Employee.NumberOfEmployees);

Employee employee2=new Employee("Mark","Zuckerberg","CEO");
System.Console.WriteLine("Number of Employees : "+Employee.NumberOfEmployees);

System.Console.WriteLine("Result : "+Operations.Sum(100,5));
System.Console.WriteLine("Result : "+Operations.Substraction(100,20));

class Employee
{
    private static int _NumberOfEmployees;
    private string? _Name;
    private string? _LastName;
    private string? _Department;
    public static int NumberOfEmployees { get => _NumberOfEmployees; set => _NumberOfEmployees = value; }
    // public string Name { get => _Name; set => _Name = value; }
    // public string LastName { get => _LastName; set => _LastName = value; }
    // public string Department { get => _Department; set => _Department = value; }


    public Employee(string name,string lastname,string department)
    {
        this._Name=name;
        _LastName=lastname;
        _Department=department;
        _NumberOfEmployees+=1;
    }
    static Employee(){ //Static constructor da yaratılabilir. Static ctor'ların erişim belirteçleri (public,private vs ) olmaz

        _NumberOfEmployees=0;

    }
    //Static ve public ctor olduğu durumda static ctor sadece bir kere çalışır.



    //static olmayan class içerisindeki özellikler methodlar nesneye özgüdür.
}

//static olan üyeler class bazında atanır

static class Operations{
    
   
    public static long Sum(long value1,long value2)
    { return value1+value2;}
    public static long Substraction(long value1,long value2)
    { return value1-value2;}
    
}