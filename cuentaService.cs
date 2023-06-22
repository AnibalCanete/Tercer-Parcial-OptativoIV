namespace TercerParcialOptativoIV
{
    public class cuentaService
    {
        private cuentaRepository repository;

        public cuentaService(string cadenaConexion)
        {
            repository = new cuentaRepository(cadenaConexion);
        }

        public bool insertarCuenta()
        {
            return true;
        }

        public bool modificarCuenta()
        {
            return true;
        }

        public bool eliminarCuenta()
        {
            return true;
        }

        public infraestructure.Models.cuentaModel consultarCuenta(string numeroCuenta)
        {
            return repository.consultarCuenta(numeroCuenta);
        }

        public List<String> listarCuentas()
        {
            return null;
        }
    }
}
