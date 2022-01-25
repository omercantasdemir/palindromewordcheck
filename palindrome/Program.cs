using System;
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = "";
            do
            {
                Console.Clear();
                //İfadenin kullanıcıdan tarafından girilme veya sistem tarafından oluşturulma durumu denetleniyor.
                Console.WriteLine("İfadeyi siz mi girersiniz biz mi oluşturalım?\n1) Ben girerim\n2) Siz oluşturun");
                switch (Convert.ToInt16(Console.ReadLine()))
                {
                    case 1:
                        //İfade kullanıcı tarafından girilecekse bu ifade burada alınıyor.
                        Console.Write("Lütfen denemek istediğiniz ifadeyi girin: ");
                        ifade = Console.ReadLine();
                        break;
                    case 2:
                        //İfade sistem tarafından oluşturulacaksa burada uzunluğu alınıp işleniyor.
                        Creator creator = new Creator();
                        Console.Write("Lütfen oluşturmak istediğiniz ifadenin uzunluğunu giriniz: ");
                        ifade = creator.palindromeCreator(Convert.ToInt16(Console.ReadLine()));
                        break;
                }
                //İfade kontrol ediliyor ve sonuca göre ekrana çıktı yapılıyor.
                if (palindromeCheck(ifade))
                    Console.WriteLine("Kelime Bir Palindrom.");
                else
                    Console.WriteLine("Kelime Bir Palindrom Değildir.");
                //Devam edilme durumu kontrol ediliyor.
            } while (cevap());
        }
        //Kelime kontrol işlemi yapılıyor.
        public static bool palindromeCheck(string phrase)
        {
            //İfadenin boş olma durumu kontrol ediliyor.
            if (!string.IsNullOrEmpty(phrase))
            {
                //İfadenin ekrana yazdırılması. (Sadece görsellik için.)
                Console.WriteLine(phrase);
                //İfade karakter dizisine dönüştürülüyor ve indexlerdeki gerekli kontroller yapılıyor.
                char[] chars = phrase.ToCharArray();
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[i] != phrase[phrase.Length - i - 1])
                    {
                        //Uygunsuzluk durumu yakalanırsa yanlış döndüren kısım.
                        return false;
                    }
                }
                //Bütün karakterler kurala uyuyorsa doğru döndüren kısım.
                return true;
            }
            //İfade boşsa yanlış döndüren kısım.
            return false;
        }
        public static bool cevap()
        {
            Console.WriteLine("Devam etmek ister misiniz? e/h");
            if (Console.ReadLine() == "e")
                return true;
            return false;
        }
    }
}