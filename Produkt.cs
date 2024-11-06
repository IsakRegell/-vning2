namespace GeneriskRepo
{
    public class Produkt : IIdentifiable
    {
        public int Id { get; set; }
        public string? Namn {  get; set; }
        public int Pris { get; set; }

        public Produkt(int id, string namn, int pris)
        {
            Id = id;
            Namn = namn;
            Pris = pris;
        }
        public override string ToString()
        {
            return $"Produkt: Id={Id}, Namn={Namn}, Pris={Pris}";
        }
    }

}
