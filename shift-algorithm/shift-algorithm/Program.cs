using System.Text;

namespace shift_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            string chars = "abcçdefgğhıijklmnoöprsştuüvyz";

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                string cryptedData = "";
                Console.Write("İşlem seçiniz 1-Şifrele 2-Şifre Çöz : ");
                int islem = int.Parse(Console.ReadLine());
                Console.Write("Kaydırma sayısı : ");
                int kaydirma = int.Parse(Console.ReadLine());  
                if (islem == 1)
                {
                    Console.Write("Şifrelenecek metni giriniz: ");
                    string data = Console.ReadLine().ToLower();
                    foreach (var x in data)
                    {
                        int index = chars.IndexOf(x)+kaydirma;
                        if (index > 28) index = index % 29;
                        cryptedData += chars[index];

                    }
                    Console.WriteLine("Şifrelenmiş veri: " + cryptedData);
                }
                if (islem == 2)
                {
                    Console.Write("Çözülecek metni giriniz: ");
                    string data = Console.ReadLine().ToLower();
                    foreach (var x in data)
                    {
                        int index = chars.IndexOf(x)-kaydirma;
                        if (index < 0) index = index % 29+29;
                         cryptedData += chars[index];
                    }
                    Console.WriteLine("Çözülmüş veri: " + cryptedData);
                }
            }
        }
    }
}