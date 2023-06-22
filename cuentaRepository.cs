using TercerParcialOptativoIV.Models;

namespace TercerParcialOptativoIV
{
    public class cuentaRepository
    {
        private strinng _connectionString;
        private Npgsql.NpgsqlConnection connection;

        public cuentaRepository(string connectionSring)
        {
            this._connectionString = _connectionString;
            this.connection = new Npgsql.NpgsqlConnection(this._connectionString);
        }

        public cuentaModel consultarCuenta(String numeroCuenta)
        {
            try
            {
                return connection.QueryFirst<CuentaModel>($"SELECT * FROM cuenta WHERE numeroCuenta = {numeroCuenta}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string modificarCuenta(CuentaModel cuenta)
        {
            try
            {
                connection.Execute($"UPDATE ceunta SET " +
                "idPersona = @idPersona, " +
                "nombreCuenta = @nombreCuenta, " +
                "numeroCuenta = @numeroCuenta " +
                "saldo = @saldo " +
                "limite = @limite " +
                "moneda = @moneda " +
                "estado = @estado " +
                $"WHERE id = {cuenta.idcuenta}", cuenta);
                return "Se modificaron los datos correctamente....";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
