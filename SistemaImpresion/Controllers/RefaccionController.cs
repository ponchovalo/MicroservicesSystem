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
    public class RefaccionController : ControllerBase
    {
        //Contructor del controlador
        private readonly IMongoRepository<RefaccionEntity> _refaccionRepository;

        public RefaccionController(IMongoRepository<RefaccionEntity> refaccionRepository)
        {
            _refaccionRepository = refaccionRepository;
        }

        //Obtiene todos los registros de Impresoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefaccionEntity>>> Get()
        {
            return Ok(await _refaccionRepository.GetAll());
        }

        //Insertar una Refaccion
        [HttpPost]
        public async Task Post(RefaccionEntity refaccion)
        {
            await _refaccionRepository.InsertDocument(refaccion);
        }
        //Edita una refaccion
        [HttpPut("{id}")]
        public async Task Put(string Id, RefaccionEntity refaccion)
        {
            refaccion.Id = Id;
            await _refaccionRepository.UpdateDocument(refaccion);
        }
    }
}
