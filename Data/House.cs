using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Immobilien.Data
{
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Titel { get; set; }
        public string Kurzbeschreibung { get; set; }
        [Required]
        public string Ort { get; set; }
        [Required]
        public bool Kauf { get; set; }
        [Required]
        [Column(TypeName = "varchar(MAX)")]
        public string Beschreibung { get; set; }
        public double Grund { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Keller { get; set; }
        public double Wohnflaeche { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Geschossbeschreibung { get; set; }
        public string Heizung { get; set; }
        public double Hwb { get; set; }
        public double Preis { get; set; }
        public double Miete { get; set; }
        public double Kaution { get; set; }
        public double Abloese { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Schlusstext { get; set; }
        public byte[] Titelbild { get; set; }
    }
}
