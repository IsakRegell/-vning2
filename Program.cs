namespace GeneriskRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produktRepository = new Repository<Produkt>();
            var kategoriRepository = new Repository<Kategori>();

            produktRepository.Add(new Produkt(1, "Äpple", 50));
            produktRepository.Add(new Produkt(2, "Banan", 60));

            kategoriRepository.Add(new Kategori(1, "Frukt"));
            kategoriRepository.Add(new Kategori(2, "Grönsaker"));

            //var kategori = kategoriRepository.GetById(1);
            //Console.WriteLine(kategori);

            //var produkt = produktRepository.GetById(1);
            //Console.WriteLine(produkt);

            SkrivUtListan(produktRepository, kategoriRepository);
        }







        private static void SkrivUtListan(Repository<Produkt> produktRepository, Repository<Kategori> kategoriRepository)
        {
            foreach (var p in produktRepository.GetAll())
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("* * * * * * * * * * * *");
            foreach (var k in kategoriRepository.GetAll())
            {
                Console.WriteLine(k);
            }
        }
    }
    public interface IIdentifiable
    {
        int Id { get; }
    }
    public class Repository<T> where T : IIdentifiable
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
        public void Delete(int id)
        {
            items.RemoveAll(i => i.Id == id);
        }
        public T GetById(int id)
        {
            return items.FirstOrDefault(i => i.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return items;
        }
        public void Update(T item)
        {
            var index = items.FindIndex(i => i.Id == item.Id);
            if (index >= 0)
            {
                items[index] = item;
            }
        }

        

    }
}
