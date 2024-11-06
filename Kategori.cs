namespace GeneriskRepo
{
    public class Kategori : IIdentifiable
    {
        public int Id { get; set; }
        public string Namn { get; set; }

        public Kategori(int id, string namn)
        {
            Id = id;
            Namn = namn;
        }
        public override string ToString()
        {
            return $"Kategori: Id={Id}, Namn={Namn}";
        }
    }
}