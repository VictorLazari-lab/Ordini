

namespace Core.Controllers
{
    public class Prodotto
    {
        public int ProdottoID { get; set; }
        public string DescrizioneProdotto { get; set; }

        public decimal PrezzoPublico { get; set; }

        public ushort IVA { get; set; }
        public decimal PrezzoPublicoNoIva { get; set; }
        public decimal PrezzoNetto { get; set; }

        public decimal Sconto { get; set; }

        public ushort Listino { get; set; }

        public decimal ScontoMax { get; set; }

        public ushort PezziMin { get; set; }

        public ushort PezziMax { get; set; }

        public string CollegamentoImmagine { get; set; }

        public string Attivo { get; set; }



    }
}