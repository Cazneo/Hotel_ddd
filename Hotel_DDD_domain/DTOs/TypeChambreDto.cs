namespace Hotel_DDD_domain.DTOs
{
    public class TypeChambreDto
    {
        public int TypeChambreID { get; set; }
        public string NomType { get; set; }
        public float PrixParNuit { get; set; }
        public string Lit { get; set; }
        public bool Wifi { get; set; }
        public bool TV { get; set; }
        public bool EcranPlat { get; set; }
        public bool Minibar { get; set; }
        public bool Climatiseur { get; set; }
        public bool Baignoire { get; set; }
        public bool Terrasse { get; set; }
    }
}