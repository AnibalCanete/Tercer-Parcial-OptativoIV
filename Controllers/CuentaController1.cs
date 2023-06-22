using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TercerParcialOptativoIV.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class CuentaController1 : Controller
    {
        private cuentaService servicio;
        string cadenaConexion = "Server=127.0.0.1;Port=8080;Database=OptativoIV;User Id=psotgres;Password=admin";

        public CuentaController1()
        {
            servicio = new cuentaService(cadenaConexion);
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        [HttpGet("consultar/{cuenta}")]
        public infraestructure.Models.cuentaModel Get(string cuenta)
        {
            var result = servicio.consultarCuenta(cuenta);
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: CuentaController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaController1/Create
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

        // GET: CuentaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentaController1/Edit/5
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

        // GET: CuentaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentaController1/Delete/5
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
