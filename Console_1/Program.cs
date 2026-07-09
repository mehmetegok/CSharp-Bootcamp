namespace Console_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesaj msj = new Mesaj();
            msj.metin();
            KisiListesi kisi = new KisiListesi();
            string ads;
            Console.WriteLine("Lütfen bir isim giriniz: ");
            ads = Console.ReadLine();
            kisi.kisilistele(ads);
            Console.Read();
        }
    }
}
