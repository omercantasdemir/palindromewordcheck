using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    public class Creator
    {
        //Palindrom kelime üretme fonksiyonu. A-Z aralığında (küçük harfler dahil değil) harflerden oluşan anlamsız
        //palindrom ifadeler oluşturur. Belirtilen uzunlukta oluşturur ve bu ifadeleri döndürür.
        public string palindromeCreator(int uzunluk)
        {
            //"uzunluk" büyüklüğünde karakter dizisi oluşturuluyor.
            char[] temp = new char[uzunluk];
            Random random = new Random();
            for (int i = 0; i < temp.Length; i++)
            {
                //Rastgele sayılar harflere çevriliyor ve karakter dizisine yerleştiriliyor.
                char harf = (char)random.Next(65, 90);
                temp[i] = harf;
                temp[uzunluk - i - 1] = harf;
            }
            //Döndürülecek string değeri karakter dizisinden türetiliyor.
            string ifade = new string(temp);
            return ifade;
        }
    }
}
