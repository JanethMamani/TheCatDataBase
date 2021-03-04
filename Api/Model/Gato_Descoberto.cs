using System;

namespace Api.Models
{
    public class Gato_Descoberto
    {
        public DateTime DataDescoberta { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}