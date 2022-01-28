
//Class yapısına çok benzerler.
//Kendi ctorları prop ve methodları vardır.
// *********** Class'lar ile aralarında çok büyük performans farkı vardır.*************

//Classlar referans türündedir. Referans türündeki değişkenler belleğin heap bölgesinde tutulur.Değer tipindekiler ise stack bölgesinde tutulur. 
//Referans tiplerinin adı ise stackte tutulur ve heapteki verilerin bulunduğu adresi işaret eder.

//STRUCTLAR DEĞER TİPİNDEDİR.


Rectangle rectangle=new Rectangle();
rectangle.width=10;
rectangle.height=5;
System.Console.WriteLine("Class Rectangle Area : "+ rectangle.AreaOfRectangle());


Rectangle_Struct rectangle_Struct=new Rectangle_Struct();
rectangle_Struct.width=10;
rectangle_Struct.height=5;
System.Console.WriteLine("Class Rectangle Area : "+ rectangle_Struct.AreaOfRectangle());

//Class'da new ile nesnesini yaratmamız gerekirken structta newlememize gerek yoktur. Rectangle_Struct rectangle_Struct;
//Class'ların tanımlamasak bile default constructorları vardır. Tanımlayarak override edebilir veya overload yapabiliriz.
// ******** Structlarda parametresiz constructor tanımlayamayız.

Rectangle_Struct rectangle_Struct2; //bu şekilde kullanıldığında initial değerlerini kendisi atayamaz.

Rectangle_Struct rectangle_Struct3=new Rectangle_Struct(13,25);
System.Console.WriteLine("Class Rectangle Area : "+ rectangle_Struct.AreaOfRectangle());


//Class'lar referans tipi olması nedeniyle performans avantajı sağlar(16byte dan büyük veriler), structlar performans avantajı sağlar(16byte a kadar)

 class Rectangle
{
    public int height;
    public int width;
    
    public long AreaOfRectangle(){
        return height*width;
    }
    
}
 public struct Rectangle_Struct
{
    public int height;
    public int width;
    
    public Rectangle_Struct(int height,int width)
    {
        this.height=height;
        this.width=width;
    }
    public long AreaOfRectangle(){
        return height*width;
    }

}
