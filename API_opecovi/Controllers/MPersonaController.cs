using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_opecovi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MPersonasController : ControllerBase
    {
        _dbContext _db = new _dbContext();

        [HttpGet]
        public IActionResult ListarTodo()
        {
            //select * from m_persona

            return Ok(_db.MPersonas.ToList());

        }


        [HttpGet("{id}")]
        public IActionResult ObtenerPorID(int id)
        {
            //select * from MPersonas where id = {id}
            return Ok(_db.MPersonas.Find(id));
        }


        [HttpPost]
        public IActionResult Insertar([FromBody] MPersona request)
        {
            //insert into MPersonas(declaro todos los campos) ===> ingreso los valores

            _db.MPersonas.Add(request);
            _db.SaveChanges();
            return Ok(request);
        }



        [HttpPut]
        public IActionResult Update([FromBody] MPersona request)
        {

            //update MPersona set id_empresa = request,cod_empresa = request.apellidoPaterno where id=request.id

            _db.MPersonas.Update(request);
            _db.SaveChanges();
            return Ok(request);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int rowAffected = 0;
            MPersona per = _db.MPersonas.Find(id);
            if (per != null)
            {
                _db.MPersonas.Remove(per);
                rowAffected = _db.SaveChanges();
                return Ok(new { message = $"Nro de Registro Eliminados: {rowAffected}" });
            }
            return NotFound();
        }


    }

}

