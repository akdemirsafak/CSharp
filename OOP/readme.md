# Object Oriented Programming

## Inheritance

> subclass:superclass şeklinde kalıtım verilir.Subclass Superclass'ın özelliklerini de taşır fakat superclass subclass ın özelliklerini taşımayabilir.
> **Superclass'da protected olarak tanımlanan özelliklere subclass'dan newlenen nesnelerden ulaşamayız. Eğer ulaşmak istersek base keywordu ile 'superclass'dan türeyen subclass içerisinde' erişebiliriz.**

## Polymorphism and Sealed Class

> Çok biçimlilik anlamına gelir. Polymorphism ile birlikte **virtual methodlar** kullanır hale geliyoruz.Virtual methodlar kalıtım veren sınıflardan gelen alt sınıflar tarafından yeniden yazılabilen, biçimi değiştirilebilen(override) methodlardır. **Subclass'da Override edilecek methodları Superclass içerisinde virtual ile işaretleriz.** Subclass'da eğer superclass'dan gelen methoda ekleme yapacaksak base.Superclassdakimethodadi(); method içerisinde bulunur. Eğer tamamen biçimini değiştireceksek base.MethodAdi(); kaldırılır.
> **Sealed anahtar kelimesiyle bir class'ın kalıtım vermesini engelleyebiliriz.**

## Interface

> ! Important feature ! EN ÖNEMLİ ÖZELLİKLERİNDEN BİRİDİR.
> IMPLEMENTE edilir Inherit edilmez.
> Sınıflarda içermesi gereken methodların, propertylerin imzalarının yer aldığı taslaktır. İsimlendirilirken I harfiyle başlar(standart olarak). Bir interfaceden implemente edilen class'larda aynı methodlar farklı işlevlerle tanımlanabilir, bu işleme imkan verir.
> Interface'ler soyut olduğu için newlenemezler.

## Abstract Class

> Sadece kalıtım için kullanılırlar. new ile türetilemezler. Soyutturlar.Subclass'larda override edilmelidirler. Bir class sadece 1 abstract'tan kalıtım alabilir. class tanımlanırken abstract keyword ü kullanılmalıdır.
