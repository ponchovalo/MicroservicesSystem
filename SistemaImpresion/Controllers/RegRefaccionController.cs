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
    public class RegRefaccionController : ControllerBase
    {
        //Contructor del controlador
        private readonly IMongoRepository<RegRefaccionEntity> _regRefaccionRepository;
        //Contructor del controlador
        private readonly IMongoRepository<RefaccionEntity> _refaccionRepository;

        public RegRefaccionController(  IMongoRepository<RegRefaccionEntity> regRefaccionRepository, 
                                        IMongoRepository<RefaccionEntity> refaccionRepository)
        {
            _regRefaccionRepository = regRefaccionRepository;
            _refaccionRepository = refaccionRepository;
        }

        //Obtiene todos los registros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegRefaccionEntity>>> Get()
        {
            return Ok(await _regRefaccionRepository.GetAll());
        }

        //Insertar una registro
        [HttpPost]
        public async Task Post(RegRefaccionEntity registro)
        {
            registro.Refaccion.Cantidad = registro.Refaccion.Cantidad - registro.cantidad;
            await _regRefaccionRepository.InsertDocument(registro);
            await _refaccionRepository.UpdateDocument(registro.Refaccion);
        }
 


    }
}
