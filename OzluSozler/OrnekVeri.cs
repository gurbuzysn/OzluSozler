using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzluSozler
{
    // static sınıflarda sınıfın örneğin oluşturamazsınız
    // static metotları ismi doğrudan sınıfın ismi üzerinden kullanabilirsiniz
    public static class OrnekVeri
    {
        public static List<OzluSoz> Getir()
        {
            List<OzluSoz> ozluSozler = new List<OzluSoz>()
            {
                new OzluSoz() { Soz = "Hayatta en büyük zafer, korkularının üstesinden gelmektir.", Yazar = "Nelson Mandela", Derece = 5 },
                new OzluSoz() { Soz = "İçimizdeki en karanlık korkular, en büyük ışıklarımızı da ortaya çıkarabilir.", Yazar = "Marianne Williamson", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta her şey mümkündür, ancak her şeyi yapmak mümkün değildir.", Yazar = "Dan Millman", Derece = 3 },
                new OzluSoz() { Soz = "Bir şeyi yapmaya cesaret edemiyorsanız, o zaman onu yapmanız gerektiği işte budur.", Yazar = "Neil Gaiman", Derece = 4 },
                new OzluSoz() { Soz = "Bir insanın hayatındaki en büyük engel, kendisidir.", Yazar = "Ralph Waldo Emerson", Derece = 5 },
                new OzluSoz() { Soz = "Başarının sırrı, başarısızlıktan sonra tekrar kalkıp denemekte yatar.", Yazar = "Winston Churchill", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta başarı, ne kadar zorlu bir yolculuk olduğuna bağlı değil, ne kadar çok kez düşüp tekrar kalktığına bağlıdır.", Yazar = "A.P.J. Abdul Kalam", Derece = 4 },
                new OzluSoz() { Soz = "Her şeyin bir zamanı vardır, zamanı gelince de her şey gerçekleşir.", Yazar = "Victor Hugo", Derece = 3 },
                new OzluSoz() { Soz = "Bir insanın başarısı, ne kadar büyük bir engelle karşılaştığından değil, ne kadar sıkı çalıştığından ölçülür.", Yazar = "Booker T. Washington", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta en güçlü insanlar, hayatta en zorlu yolları yürümüş olanlardır.", Yazar = "Robert Louis Stevenson", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta birçok şey mümkündür, ancak hiçbir şey kolay değildir.", Yazar = "Thomas A. Edison", Derece = 4 },
                new OzluSoz() { Soz = "Her zaman yapabileceğinizin en iyisini yapın. İnanın bana, gerisi kendiliğinden gelir.", Yazar = "Harry S. Truman", Derece = 3 },
                new OzluSoz() { Soz = "Hayatta en önemli şey, yaptığınız işi sevmektir. Eğer sevmezseniz, hiçbir zaman başarılı olamazsınız.", Yazar = "Steve Jobs", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta başarının anahtarı, cesareti yitirmemekte yatar.", Yazar = "Maya Angelou", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta başarılı olmak istiyorsanız, önce kendinize inanın. Kendinize inanmadan, hiçbir şey başaramazsınız.", Yazar = "Muhammad Ali", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta her şeyi bilmek mümkün değildir, ama sürekli öğrenmek her zaman mümkündür.", Yazar = "John Wooden", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta karşınıza çıkan engeller, sizi hedefinize ulaştırmanın en iyi yollarıdır.", Yazar = "Barbara Sher", Derece = 3 },
                new OzluSoz() { Soz = "Hayatta ne kadar sıkı çalışırsanız, şansınız da o kadar artar.", Yazar = "Thomas Jefferson", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta sadece bir kez yaşıyorsunuz, ama doğru yaparsanız, bir kez yeterlidir.", Yazar = "Mae West", Derece = 3 },
                new OzluSoz() { Soz = "Hayatta her şeyin bir bedeli vardır, ancak başarısızlık, hiçbir şey yapmamanın bedelinden daha pahalı değildir.", Yazar = "Brian Tracy", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta herkes hata yapar, önemli olan hatalarımızdan ders çıkarmaktır.", Yazar = "John C. Maxwell", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta en büyük başarı, diğer insanların hayatlarında bir fark yaratmaktır.", Yazar = "Melinda Gates", Derece = 4 },
                new OzluSoz() { Soz = "Başarı, küçük adımların bir araya gelmesiyle elde edilir.", Yazar = "Anonymous", Derece = 2 },
                new OzluSoz() { Soz = "Hayatta yapmanız gereken şeylerden sıkılmayın, yapmanız istediğiniz şeyleri yapmak için o şeyleri yapın.", Yazar = "John Wooden", Derece = 3 },
                new OzluSoz() { Soz = "Başarılı olmak için, yapmak zorunda olduğunuz şeyleri yapmakla kalmayın, yapmak istediğiniz şeyleri de yapın.", Yazar = "Anonymous", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta bir şeyi değiştirmek istiyorsanız, önce kendinizde değişiklik yapın.", Yazar = "Mahatma Gandhi", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta en güçlü insanlar, hayatta en zorlu yolları yürümüş olanlardır.", Yazar = "Robert Louis Stevenson", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta yapabileceğiniz en iyi şey, yapamayacağınız şeyi yapmaktır.", Yazar = "Theodore Roosevelt", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta her zaman bir seçeneğiniz vardır, her zaman bir seçim yapabilirsiniz.", Yazar = "Katherine Center", Derece = 3 },
                new OzluSoz() { Soz = "Hayatta bir şeyi başarmak için, onu gerçekleştirebileceğinize dair bir inancınız olmalıdır.", Yazar = "Norman Vincent Peale", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta başarılı olmak için, insanların ne istediklerini bilmeli ve onlara bunu vermelisiniz.", Yazar = "Steve Jobs", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta yapabileceğiniz en önemli şey, yarının ne getireceğini tahmin etmek değil, yarınla karşılaşmanıza hazırlanmaktır.", Yazar = "Pericles", Derece = 3 },
                new OzluSoz() { Soz = "Hayatta her şeyi yavaş yavaş öğreniyoruz, ancak bazı şeylerin hızlıca öğrenilmesi gerekiyor.", Yazar = "Leo Tolstoy", Derece = 2 },
                new OzluSoz() { Soz = "Hayatta en büyük tehlike, tehlikelerin var olmadığı bir hayat sürmektir.", Yazar = "Theodore Roosevelt", Derece = 5 },
                new OzluSoz() { Soz = "Hayatta başarılı olmak için, kendinize ve başkalarına dürüst olun.", Yazar = "Dalai Lama", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta bir şeyleri başarmak istiyorsanız, önce harekete geçmelisiniz.", Yazar = "Zig Ziglar", Derece = 4 },
                new OzluSoz() { Soz = "Hayatta en zor şey, hayatın kendisidir.", Yazar = "Friedrich Nietzsche", Derece = 5 }
            };

            return ozluSozler;
        }
    }
}