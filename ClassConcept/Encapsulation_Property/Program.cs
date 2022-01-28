// Kapsülleme OOP 'nin  temel kavramlarından biridir.
//Bir nesnenin bazı özellik ya da methodlarını diğer classlardan ve diğer nesnelerden 
//korumak anlamına gelir.Erişim belirleyicilerle yapılır.

//private ulaşılamaz
//protected bazı şartlarda ulaşılabilir
//public ulaşılabilir

//Propertyler Get ve Setlerden oluşur.

Student student=new Student("Ufuk","Akdemir",3,5);
student.PassTheClass();
student.WriteStudentDetail();


 class Student
{   
    //private string myName; //this is a field
    private string _Name; // property
    private string _LastName;//eğer bir property tanımlanırken setter i olmazsa dışarıdan değer tanımlamanaz hale gelir.
    private int _studentId; //property oluşturmanın kolay yolu prop yazıp Enter kullanmaktır
    private int _ClassId;
    public string Name { get => _Name; set => _Name = value; }
    public string LastName { get => _LastName; set => _LastName = value; }
    public int StudentId { get => _studentId; set => _studentId = value; }
    public int ClassId { get => _ClassId; set => _ClassId = value; }
    public string FullName { get => _FullName=_Name+" "+_LastName; set => FullName = _Name+" "+_LastName; }

    private string _FullName;

    public Student() => System.Console.WriteLine("Working");
    public Student(string name = "Safak", string lastname = "Akdemir", int studentid = 1, int classid = 1)
    {
        Name=name;
        LastName=lastname;
        StudentId=studentid;
        ClassId=classid;        
    }
   
    public void WriteStudentDetail()
    {
        System.Console.WriteLine("\n********* STUDENT DETAILS ************\n");
        System.Console.WriteLine("FullName: {0}\nStudentId {1} and ClassId {2}\n",FullName,StudentId,ClassId);
    }
    public void PassTheClass()
    {
        StudentId+=1;
    }
    
}