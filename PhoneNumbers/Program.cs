// Console PhoneBook Application

// Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.

// 1. Telefon Numarası Kaydet (Create New Person(Phone Number))
// 2. Telefon Numarası Sil (Remove a Phone Number)
// 3. Telefon Numarası Güncelle (Update)
// 4. Rehber Listeleme (A-Z, Z-A seçimli)
// 5. Rehberde Arama (Search in contacts)

// Açıklama(Description):

// Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz. (Add 5 new Record)

// Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.(First step selection process)

using System.Linq;
List<Person> phoneBook=new List<Person>();


Operations.SeedData(ref phoneBook);
    int selection=0;
    do{

    System.Console.WriteLine("\n\n*****************************************");
    System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz. / Please Select a Action");
    System.Console.WriteLine("(1) Yeni Numara Kaydetmek / ");
    System.Console.WriteLine("(2) Varolan Numarayı Silmek / Remove a Record");
    System.Console.WriteLine("(3) Varolan Numarayı Güncelleme / Update a Record");
    System.Console.WriteLine("(4) Rehberi Listelemek / List all-PhoneBook-");
    System.Console.WriteLine("(5) Rehberde Arama Yap / Search");
    System.Console.WriteLine("(9) İşlemi İptal Et / Quit");

    selection=Convert.ToInt32(Console.ReadLine()); 
    Operations.ProgramController(ref phoneBook,selection);
    }while(selection!=9);


//for controller



public class Person
{
    public int PersonId { get; set; }
    
    public string Name { get; set; }
    
    public string LastName { get; set; }
    
    public string PhoneNumber { get; set; }


    
}

public static class Operations
{
    public static void ProgramController(ref List<Person> phoneBook,int selection){
        switch (selection)
        {
            case 1: //new record
                NewPhoneNumber(phoneBook);
                break;
            case 2: //remove first by name or lastname. If no one reply
                RemoveFirstRecord(phoneBook);
                break;
            case 3: //Update
                UpdateNumber(phoneBook);
                break;
            case 4:
                //GetDatas
                GetDatas(phoneBook);
                break;
            case 5://Search
                Search(phoneBook);
                break;
            case 9://Quit
                System.Console.WriteLine("GoodBye friend");
                break;
            default:
                System.Console.WriteLine("Geçersiz bir değer girildi.");
                break;
        }

    }
  public static void SeedData(ref List<Person> phoneBook){
    phoneBook.Add(new Person{Name="Şafak",LastName="Akdemir",PhoneNumber="123 432 12 43"});
    phoneBook.Add(new Person{Name="Alfred",LastName="Borden",PhoneNumber="353 432 90 22"});
    phoneBook.Add(new Person{Name="Nicky",LastName="Focus",PhoneNumber="888 342 19 30"});
    phoneBook.Add(new Person{Name="Takashi",LastName="Kovacs",PhoneNumber="999 776 03 78"});
    phoneBook.Add(new Person{Name="Joey",LastName="Tribbiani",PhoneNumber="999 776 03 78"});
  }
  
  public static void NewPhoneNumber( List<Person> phoneBook){
      System.Console.Write("Lütfen isim giriniz : ");
      string name=Console.ReadLine();
      System.Console.Write("Lütfen soyisim giriniz : ");
      string lastName=Console.ReadLine();
      
      System.Console.Write("Lütfen telefon numarası giriniz : ");
      string phoneNumber=Console.ReadLine();
      phoneBook.Add(
        new Person{Name=name,
            LastName=lastName,
            PhoneNumber=phoneNumber});
  }
    
    public static void RemoveFirstRecord(List<Person> phoneBook){
        System.Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string input=Console.ReadLine();

        Person person=phoneBook.Where(x=>x.Name.Equals(input) || x.LastName.Equals(input)).FirstOrDefault();
        if (person!=null)
        {
            System.Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) ",person.Name);
            char approve=Convert.ToChar(Console.ReadLine());
            if (approve=='y')
            {
                phoneBook.Remove(person);
            }
            else if(approve=='n')
            {
                System.Console.WriteLine("işlem iptal edildi.");
            }
        }
        else{
            System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
            int option=Convert.ToInt32(Console.ReadLine());
            if(option==2){
                ProgramController(ref phoneBook,2);
            }
        }
        
    }
           
    public static void GetDatas(List<Person> phoneBook)
    {
        System.Console.WriteLine("Telefon Rehberi");
        System.Console.WriteLine("**********************************************");
        System.Console.WriteLine("A-Z sıralama için 1 Z-A sıralama için 2 yazınız");
        List<Person> sortedList;
        int opinion=Convert.ToInt32(Console.ReadLine());
        if (opinion==1 ||opinion==2)
        {
            if (opinion==1)
            {
                sortedList=phoneBook.OrderBy(x=>x.Name).ToList();
            }
            else 
            {
                sortedList=phoneBook.OrderByDescending(x=>x.Name).ToList();
            }
            ListDatas(sortedList);
        }
        else
        {
            System.Console.WriteLine("Hatalı giriş");
        }
    }
    
    public static void UpdateNumber(List<Person> phoneBook)
    {
        System.Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string input=Console.ReadLine();

        Person person=phoneBook.Where(x=>x.Name.Equals(input) || x.LastName.Equals(input)).FirstOrDefault();
        if (person!=null)
        {
            System.Console.Write("Yeni numarayı giriniz: ");
            string number=Console.ReadLine();
            person.PhoneNumber=number;
           
        }
        else{
            System.Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için    : (1)\n* Yeniden denemek için              : (2)");
            int opinion=Convert.ToInt32(Console.ReadLine());
            if (opinion==2)
            {
                ProgramController(ref phoneBook,3);
            }
        }
    }

    public static void Search(List<Person> phoneBook)
    {
        System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n**********************************************\nİsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
        int opinion=Convert.ToInt32(Console.ReadLine());
        List<Person> result;
        if (opinion==1 || opinion==2)
        {
           if (opinion==1)
           {
                System.Console.WriteLine("İsim veya soyisim giriniz");
                string inputData=Console.ReadLine();
                result=phoneBook.Where(x=>x.Name.Equals(inputData) || x.LastName.Equals(inputData)).ToList();
           }
           else
           {
                System.Console.WriteLine("Telefon numarası giriniz");
                string inputData=Console.ReadLine();
                result=phoneBook.Where(x=>x.PhoneNumber.Equals(inputData)).ToList(); //Telefon numarası unique olarak belirlenmediği için tolist kullanıldı.Bununla birlikte list kullanmamız gerekti.
           }
          
           if (result!=null)
            {
                System.Console.WriteLine("Arama sonuçlarınız : ");
                System.Console.WriteLine("***************************");
                ListDatas(result);
            }
            else{System.Console.WriteLine("Kayıt bulunamadı.");}
           
            
        }
        else
        {
            System.Console.WriteLine("Yanlış giriş");
        }
        
        
    }
    private static void ListDatas(List<Person> param) //yardımcı method
    {
        foreach (var item in param)
        {
            System.Console.WriteLine("İsim : {0}\nSoyisim : {1}\nTelefon Numarası : {2}\n - ",item.Name,item.LastName,item.PhoneNumber);
        }
    }
}

