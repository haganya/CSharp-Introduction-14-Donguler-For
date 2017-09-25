using System;

namespace _20170807_7Con_ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * for döngüsü sayı ile çalışan, sayıya göre çalışan döngüdür.diğer döngülere göre daha derli topludur
             * for döngüsü argümanları kendi içerisinde barındıran bir türdür. böylelikle kod dağınık olmamış oluyor.
             * 
             */

            /*
             * GELEN FOR TANIMI.
             * .................................
             for(sayaç tanımı ; koşulu ; artım)
               {
                    işlemler; 
              }
                ...........................................
             */

            // while döngüsü ile 1-100 arası sayıların toplamını yapacak olursak
            int toplam = 0;
            int sayac = 0;
            while (sayac <= 100)
            {
                toplam += sayac;
                sayac++;
            }

        

            // aynı işlemi while yerine for döngüsü kullanarak yaparsak
            int toplamFor = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplamFor += i;
            }

        }
    }
}
