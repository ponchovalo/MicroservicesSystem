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

        //Insertar una Impresora
        [HttpPost]
        public async Task Post (ImpresoraEntity impresora)
        {
            await _impresoraRepository.InsertDocument(impresora);
        }

        //Edita una impresora
        [HttpPut("{id}")]
        public async Task Put(string Id, ImpresoraEntity impresora)
        {
            impresora.Id = Id;
            await _impresoraRepository.UpdateDocument(impresora);
        }

        //Obtiene una Impresora por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<ImpresoraEntity>> GetById(string id)
        {
            var libro = await _impresoraRepository.GetById(id);
            return Ok(libro);
        }

        //Registros por paginacion
        [HttpPost("pagination")]
        public async Task<ActionResult<IEnumerable<ImpresoraEntity>>> PostPagination(PaginationEntity<ImpresoraEntity> pagination)
        {
            var resultados = await _impresoraRepository.PaginationByFilter(pagination);
            return Ok(resultados);
        }

        //Elimina una impresora
        [HttpDelete("{id}")]
        public async Task Delete(string Id)
        {
            await _impresoraRepository.DeleteById(Id);
        }
    }
}
