namespace ornek2;
class personel
{
    private string ad;
    private string soyad;

    public static void  personelbilgi(personel p) {//burada bir fonksiyon yaptık cünkü girlen değerleri büyük istiyoduk

        p.ad = p.ad.ToUpper();
        p.soyad = p.soyad.ToUpper();
    }

    //burada METHODE OVERKOADİNG yaptık bu medemek sımıfla aynı isimde birden fazla yapıcı metot girersek bu aşırı yükleme olur
    public personel()//constructors(yapıcı metot) dikatli ol yapıcı metotlarla sınıf isimleri aynı olur ve (static,void,int,string vb) gibi şeyler yazılmaz sadece iletim operatörü ve sınıf ismi 
    {
        //bu zaten tanımlamasanda kendisi tanımlanır ama eğer bir değer alan yapıcı metot tanımlarsansa bbu sefer main metotunun içinde boş bir şekilde kullanmasın
        //    çünkü değer alan bir yapcı metotun var faka şımdş çalışır sebebi bunu tanımlamamız
        Console.WriteLine(
            "Yapıcı metot calıştı.."
            );
    }

    public personel(string calısan)//değer alan bir yapıcı metot yaptık eğer parametresiz yapsaydık calışmazdı fakat parametreli birden fazla yapıcı metot olabilir
    {
        Console.WriteLine("2 inci yapıcı metot calıştı..");
        this.ad = calısan;//burad this bu metotan buradan demek

    }

    static void Main(string[] args)
    {
        List<personel> personels = new List<personel>();//bir liste oluşturduk eklenen değer kaydedilsindiye
      

        personel pr = new personel();

        personel pr2;//kopyalama yapmak için burada pr2 yi oluşturdum ama burada new yazmam agerek yok ama burada heap da bir yer ayırmadık buna dikat

        

        Console.Write("Personel Adı :");
        pr.ad = Console.ReadLine();
        Console.Write("Personel Soyad :");
        pr.soyad = Console.ReadLine();

        personelbilgi(pr);//bunu burda kulamam sebeim kodlar üsten aşaği calışıyo ve burada girilen değerler büyük harle yazılmaya başlar
        
        personels.Add(pr); //girilen değerleri listeye ekledim      

        pr2 = pr;//buradada kopyalama yaptık yani pr yi pr2 ye kkopyaladık

        foreach (personel item in personels)//teker teker yazdırmak için foreach döngüsünü kullandım 
        {
            Console.WriteLine(
                "Personel Adınız : " + pr.ad +
                "\nPersonel soyadınız : " + pr.soyad

                );
            personel pr3 = new personel("caner");
            Console.WriteLine("MÜDÜRÜMÜZ : " + pr3.ad.ToUpper());

            Console.WriteLine("Bizi tercih etiğiniz için teşşekür ederiz cıkış için herhangi bir tuşa basbilirsiniz...");
        }


        Console.ReadLine(); 
    }
}

