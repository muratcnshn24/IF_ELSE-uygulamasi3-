using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_uygulamasi3_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int m = 9;
            int n = 7;
            int p = 5;

            if (m>=n && m>p)
            {
                Console.WriteLine(" En Büyük m");
            }

            if (m>n && !(p>m))  // ünlemi gördüğünde true çevirecek
            {
                Console.WriteLine(" En Büyük m");
            }

            // || veya demek
            if (m>n || m>p)
            {
                Console.WriteLine("m En Küçük Değil");
            }

            // burada else bloğu yok şart sağlarsa çıktıyı ekrana veriyor

            m = 4;
            if (!(m>=n || m>=p ))
            {
                Console.WriteLine("m Artık En Küçük");
            }
        }
    }
}
