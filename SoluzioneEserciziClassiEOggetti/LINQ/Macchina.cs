namespace LINQ
{
    class Macchina
    {
        public int MacchinaId { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public double Prezzo { get; set; }

        public override string ToString() // metodo di default richiamato da un oggetto.
        {
            return $"{this.MacchinaId} - {this.Marca} {this.Modello} ({this.Anno}) Prezzo = {this.Prezzo:C}";
        }
    }
}
