using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TercerParcialOptativoIV.Models;

namespace TercerParcialOptativoIV.Controllers
{
    public class PersonaController : Controller
    {
        [HttpPost("ConsultarPersona/{id}")]

        public ActionResult<PersonaModel> ConsultarPersona(int id)
        {
            var resultado = this.personaService.consultarpersona(id);
            return Ok(resultado);
        }

        [HttpPost("InsertarPersona")]

        public ActionResult<string> insertarPersona(PersonaModel modelo)
        {
            var resultado = this.Personaservice.insertarPersona(new infraestructure.Models.PersonaModel)
            {
                id = modelo.id,
                nombre = modelo.nombre,
                apellido = modelo.apellido,
                tipodocumento = modelo.tipodocumento,
                documento = modelo.documento,
                direccion = modelo.direccion,
                telefono = modelo.telefono,
                mail = modelo.mail,
                estado = modelo.estado,
            });
            return Ok(resultado);
        }

        [HttpPost("eliminarPersona/{id}")]

        public ActionResult<string> eliminarPersona(int id)
        {
            var resultado = this.personaService.eliminarPersona(id);
            return Ok(resultado);
        }
        // GET: ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
