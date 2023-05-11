using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaImpresion.Core.Entities;
using SistemaImpresion.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaImpresion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpresoraController : ControllerBase
    {
        private readonly IMongoRepository<ImpresoraEntity> _impresoraRepository;

        public ImpresoraController(IMongoRepository<ImpresoraEntity> impresoraRepository)
        {
            _impresoraRepository = impresoraRepository;
        }
        //Obtiene todos los registros de Impresoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImpresoraEntity>>> Get()
        {
            return Ok(await _impresoraRepository.GetAll());
        }

        //Insertar una Impresoras
        [HttpPost]
        public async Task Post (ImpresoraEntity impresora)
        {
            await _impresoraRepository.InsertDocument(impresora);
        }





    }
}
