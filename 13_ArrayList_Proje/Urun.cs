using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ArrayList_Proje
{
    internal class Urun
    {
        internal static int HalUrunAl(ArrayList list,string urun)
        {
            if (!list.Contains(urun))
            {
                list.Add(urun);
            }

            Console.WriteLine("Kaç kilo istersiniz:");
            return Convert.ToInt32(Console.ReadLine());
        }


        internal static void HalUrunAl2(ArrayList list,string urun,ArrayList kList)
        {
            if (!list.Contains("urun"))
            {
                list.Add("urun");
                Console.WriteLine("Kaç kilo istersiniz:");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç kilo istersiniz:");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf("urun");
                kList[index] = (int)kList[index] + kilo;
            }
        }

        internal static void ManavUrunAl(ArrayList list, string urun, ArrayList kList,ArrayList musteriList)
        {
            Console.WriteLine("Kaç kilo istersiniz?");
            int kilo = Convert.ToInt32(Console.ReadLine());

            int index = list.IndexOf(urun);
            int olanKilo = (int)kList[index];

            if (olanKilo >= kilo)
            {
                musteriList.Add(list);
                int kalanKilo = olanKilo - kilo;
                if (kalanKilo == 0)
                {
                    list.Remove(urun);
                }
                else
                {
                    kList[index] = kalanKilo;
                }
            }
            else
            {
                Console.WriteLine($"İstenilen kilo yok. {olanKilo} kilo {urun} var.");
            }
        }

    }
}
