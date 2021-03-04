using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace Api.Data.Collections
{
    public class TheCat
    {
        public TheCat(DateTime dataDescoberta, string sexo, double latitude, double longitude)
        {
            this.DataDescoberta = dataDescoberta;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public DateTime DataDescoberta { get; set; }
        public string Sexo { get;set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}