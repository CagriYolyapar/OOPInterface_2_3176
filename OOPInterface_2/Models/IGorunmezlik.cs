using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface_2.Models
{
    //Interface'ler aslında bizim icin bir kontrat kümesidir...Yani Interface'lerde sadece gövdesi olmayan davranıslar ve property'ler bulunur... Interface icerisinde acılan yapıların C# 7.3 versiyonunda önce kesinlikle body'leri olamaz...

    //Interfaceler iclerinde field barındıramaz

    //Interface'lerin metotlarının body'leri acılamaz (C# 7.3'den önce)

    //Interfaceler'in icerisindeki yapıların erişim belirtecleri acıkca yazılamaz...Ancak onlar her zaman public'tir Interface internal olsa bile bu ögeler public'tir...

    //Bir sınıf sadece bir sınıftan miras alabilir ama istedigi kadar interface'ten miras alabilir...

    //Bir sınıf eger hem bir sınıftan hem de bir interface'den miras almak istiyorsa önce sınıftan miras almalıdır...

    //Bir interface'in icinde görevi tanımlı olan bir yapı varsa bu yapı miras verildigi yerde implement edilmek zorundadır...Implement edilmezse syntax hatası alırsınız...


    //Interface'ler miras alır ama sadece Interface'lerden miras alırlar...Class'lardan miras alamazlar...


    public interface IGorunmezlik
    {
        int Deneme { get; set; }
        void Gorunmezlik();
        

        
    }
}
