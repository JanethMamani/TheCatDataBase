using Microsoft.AspNetCore.Mvc;
using Api.Data.Collections;
using Api.Models;
using MongoDB.Driver;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<TheCat> _TheCatsCollection;

        public GatoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _TheCatsCollection = _mongoDB.DB.GetCollection<TheCat>(typeof(TheCat).Name.ToLower());
        }
        
        [HttpPost]
        public ActionResult SalvarTheCat([FromBody] Gato_Descoberto dto)
        {
            var theCat = new TheCat(dto.DataDescoberta, dto.Sexo, dto.Latitude, dto.Longitude);

            _TheCatsCollection.InsertOne(theCat);

            return StatusCode(201, "TheCat adicionado com sucesso");

        }

        [HttpGet] 
        public ActionResult ObterGatos()
        {
            var Gatos = _TheCatsCollection.Find(Builders<TheCat>.Filter.Empty).ToList();

            return Ok(Gatos);
        }

    }
}