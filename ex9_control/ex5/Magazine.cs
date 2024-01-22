using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex5
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска
        private double cust;
        private bool returnSrok;
        private static double price = 9;
        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


       public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public void Subs()
      {
          // действия при оформлении подписки на журнал
      }
        public void PriceMagazine(int s)
        {

            if (this.returnSrok == true)
                this.cust = s * price;
            else this.cust = s * (price + price * 0.13); ;

        }


        public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
       }
    }
}
