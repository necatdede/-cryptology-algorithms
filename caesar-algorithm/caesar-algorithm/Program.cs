using System.Text;

string chars = "abcçdefgğhıijklmnoöprsştuüvyz";

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

while (true)
{
    string cryptedData = "";
    Console.Write("İşlem seçiniz 1-Şifrele 2-Şifre Çöz : ");
    int islem = int.Parse(Console.ReadLine());
    if (islem == 1)
    {
        Console.Write("Şifrelenecek metni giriniz: ");
        string data = Console.ReadLine().ToLower();
        foreach (var x in data)
        {
            int index = chars.IndexOf(x);
            if (index < 26) cryptedData = cryptedData + chars[index + 3];
            else cryptedData += chars[index % 26];

        }
        Console.WriteLine("Şifrelenmiş veri: " + cryptedData);
    }
    if (islem == 2)
    {
        Console.Write("Çözülecek metni giriniz: ");
        string data = Console.ReadLine().ToLower();
        foreach (var x in data)
        {
            int index = chars.IndexOf(x);
            if(index>2) cryptedData = cryptedData + chars[index - 3];
            else cryptedData += chars[index + 26];
        }
        Console.WriteLine("Çözülmüş veri: " + cryptedData);
    }  
}