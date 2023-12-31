namespace Books.Classes
{
  public class kitoblar
  {
    private string Bname;
    private string[] Blist;
    private int k=0;

    public kitoblar(string bookName, string[] Books)
    {
      Bname=bookName;
      Blist=Books;
    }

    public void CheckList_1()
    {
      for(int i=0;i<Blist.Length;i++)
      {
        if(Blist[i]==Bname)
        {
          System.Console.WriteLine($"Siz izlagan kitob:\n{Blist[i]}");
          System.Console.WriteLine("Ushbu kitob haqida ma'lumot olishni hohlaysizmi:\n1.Ha 2.Yo'q");
          string YesOrNo = Console.ReadLine();
          switch(YesOrNo)
          {
            case "1":
              switch(Bname)
              {
                case "Karera programmista":
                  Console.WriteLine("Ushbu qo'llanmaning muallifi CareerCup asoschisi va  Apple, Google va Microsoft kabi yirik kompaniyalarning sobiq xodimi G. Makdouell bo'ladi. Kitob dasturiy ta'minotni ishlab chiquvchilarni tayyorlash uchun mo'ljallangan.");
                    break;
                case "24 Deadly Sins of Software Security":
                  Console.WriteLine("Mazkur kitobda Microsoft xavfsizligi ekspertlari Maykl Xovard va Devid Leblank turli-tuman dasturiy ta'minot yaratayotgan paytda yo'l qo'yiladigan keng tarqalgan va jiddiy xatolar haqida hikoya qiladi.");
                    break;
                case "Artificial Intelligence for Games":
                  Console.WriteLine("Ushbu qo'llanmada o'yinlar industriyasida mashhur dasturchi va bir qator kitoblar muallifi Yan Millington suniy ong yaratish hamda turli-tuman o'yinlarda suniy ongni yaxshilash bo'yicha o'z tajribalari bilan o'rtoqlashadi.");
                    break;
                case "Mathematics for 3D Game Programming and Computer Graphics":
                  Console.WriteLine("Ushbu qo'llanmada kompyuter o'yinlari uchun professional darajada grafika va o'yin harakatlarini yaratuvchi zamonaviy dasturchi bilishi lozim bo'lgan jami matematik konseptlar haqida hikoya qiladi.");
                    break;
                case "Game Programming Patterns":
                  Console.WriteLine("Ko'plab o'yin dasturchilari uchun eng katta muammo, bu mahsulotni dasturlashni nihoyasiga yetkazish. Aksariyat hollarda loyiha «charchab qoladi», murakkabliklar ko'payib, kodlari aralashib ketadi. Mazkur kitob ana shu muammolarni butunlay hal etishga mo'ljallangan.");
                    break;
                case "Jump Start MySQL":
                  Console.WriteLine("Ushbu kitob yordamida bir hafta ichida MySQL'ni o'zlashtirishingiz, uning  tezligini va moslashuvchanligini ishlatishni o'rganishingiz mumkin.");
                    break;
                case "Python dasturlash tili":
                  Console.WriteLine("Ushbu kitob bugungi kunda dasturlash asoslariga oid o'zbek tilidagi mukammal tuzilgan qo'llanmalardan biridir. Muallifi Anvar Narzullayev hisoblanadi.");
                    break;
                case "Html va CSS":
                  Console.WriteLine("Ushbu kitob zamonaviy dasturlashni o'rganmoqchi bo'lganlar, dasturlash bilan shug'ullanadiganlar, hatto dasturiy ta'minot yaratish bo'yicha yetuk mutaxassislar uchun ham mo'ljallangan. Muallifi Javlon Abdullo hisoblanadi");
                    break;
                case "C# 9 va .NET 5 — Zamonaviy platformalarni ishlab chiqish":
                  Console.WriteLine("Muallifi Mark J.Prays. Kitob .NET Core 5.0 yordamida zamonaviy kross-platforma dasturlarini yozishni o'rgatadi va o'quvchilarni C# 9ning muhim xususiyatlari bilan tanishtiradi.");
                    break;
              }
                break;
            case "2":
              System.Console.WriteLine("Kutubxonamizga tashrif buyurganingiz uchun rahmat!!!");
                break;
            default:
              System.Console.WriteLine("1 yoki 2 raqamidan birini tanlang!");
                break;
          }
        }
      }
    }

    public void CheckList_2()
    {
      for(int i=0;i<Blist.Length;i++)
      {
        if(Blist[i]!=Bname)
        {
          k++;
          if(k==Blist.Length)
          {
            System.Console.WriteLine("Afsuski siz izlagan kitob topilmadi!");
            System.Console.WriteLine("Kutubxonadagi kitoblar ro'yxatini ko'rishni xohlaysizmi:\n1. Ha 2. Yo'q");
            string HaYoq= Console.ReadLine();
            switch(HaYoq)
            {
              case "1":
                foreach(string royxat in Blist)
                {
                  System.Console.WriteLine(royxat);
                }
                System.Console.WriteLine();
                System.Console.WriteLine("Ushbu kitoblar haqida ma'lumot olishni hohlaysizmi:\n1.Ha 2.Yo'q");
                string javob = Console.ReadLine();
                switch(javob)
                {
                  case "1":
                    key:
                    System.Console.WriteLine("Ulardan birini yozing:");
                    string kitobNomi = Console.ReadLine();
                    switch(kitobNomi)
                    {
                      case "Karera programmista":
                        Console.WriteLine("Ushbu qo'llanmaning muallifi CareerCup asoschisi va  Apple, Google va Microsoft kabi yirik kompaniyalarning sobiq xodimi G. Makdouell bo'ladi. Kitob dasturiy ta'minotni ishlab chiquvchilarni tayyorlash uchun mo'ljallangan.");
                          break;
                      case "24 Deadly Sins of Software Security":
                        Console.WriteLine("Mazkur kitobda Microsoft xavfsizligi ekspertlari Maykl Xovard va Devid Leblank turli-tuman dasturiy ta'minot yaratayotgan paytda yo'l qo'yiladigan keng tarqalgan va jiddiy xatolar haqida hikoya qiladi.");
                          break;
                      case "Artificial Intelligence for Games":
                        Console.WriteLine("Ushbu qo'llanmada o'yinlar industriyasida mashhur dasturchi va bir qator kitoblar muallifi Yan Millington suniy ong yaratish hamda turli-tuman o'yinlarda suniy ongni yaxshilash bo'yicha o'z tajribalari bilan o'rtoqlashadi.");
                          break;
                      case "Mathematics for 3D Game Programming and Computer Graphics":
                        Console.WriteLine("Ushbu qo'llanmada kompyuter o'yinlari uchun professional darajada grafika va o'yin harakatlarini yaratuvchi zamonaviy dasturchi bilishi lozim bo'lgan jami matematik konseptlar haqida hikoya qiladi.");
                          break;
                      case "Game Programming Patterns":
                        Console.WriteLine("Ko'plab o'yin dasturchilari uchun eng katta muammo, bu mahsulotni dasturlashni nihoyasiga yetkazish. Aksariyat hollarda loyiha «charchab qoladi», murakkabliklar ko'payib, kodlari aralashib ketadi. Mazkur kitob ana shu muammolarni butunlay hal etishga mo'ljallangan.");
                          break;
                      case "Jump Start MySQL":
                        Console.WriteLine("Ushbu kitob yordamida bir hafta ichida MySQL'ni o'zlashtirishingiz, uning  tezligini va moslashuvchanligini ishlatishni o'rganishingiz mumkin.");
                          break;
                      case "Python dasturlash tili":
                        Console.WriteLine("Ushbu kitob bugungi kunda dasturlash asoslariga oid o'zbek tilidagi mukammal tuzilgan qo'llanmalardan biridir. Muallifi Anvar Narzullayev hisoblanadi.");
                          break;
                      case "Html va CSS":
                        Console.WriteLine("Ushbu kitob zamonaviy dasturlashni o'rganmoqchi bo'lganlar, dasturlash bilan shug'ullanadiganlar, hatto dasturiy ta'minot yaratish bo'yicha yetuk mutaxassislar uchun ham mo'ljallangan. Muallifi Javlon Abdullo hisoblanadi");
                          break;
                      case "C# 9 va .NET 5 — Zamonaviy platformalarni ishlab chiqish":
                        Console.WriteLine("Muallifi Mark J.Prays. Kitob .NET Core 5.0 yordamida zamonaviy kross-platforma dasturlarini yozishni o'rgatadi va o'quvchilarni C# 9ning muhim xususiyatlari bilan tanishtiradi.");
                          break;
                      default:
                        System.Console.WriteLine("To'g'irlab yozishingiz kerak");goto key;
                          break;
                    }
                      break;
                  case "2":
                    System.Console.WriteLine("Kutubxonamizga tashrif buyurganingiz uchun rahmat!!!");
                      break;
                }
                  break;
              case "2":
                System.Console.WriteLine("Kutubxonamizga tashrif buyurganingiz uchun rahmat!!!");
                  break;
              default:
                System.Console.WriteLine("1 yoki 2 raqamidan birini tanlang!");
                  break;
            }
          }
        }
      }
    }

  }
}