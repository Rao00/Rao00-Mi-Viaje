
namespace Cuenta
{
    /* Clase que representa una cuenta corriente
     * Tiene el campo saldo que representa el saldo de la cuenta, en euros
     * La propiedad saldo devuelve el saldo que hay en la cuenta
     * Los metodos retirar e ingresar sirven para retirar o ingresar la cantidad indicada 
     * 
     * Este comentario se debe eliminar y usar comentarios de documentacion en su lugar
     */
    
    /// <summary>
    /// Declaracion de la clase Cuenta
    /// <remarks>Usar esta clase solo para trabajar con los datos de una cuenta</remarks>
    /// </summary>
    public class Cuenta
    {
        private decimal saldo;

        /// <summary>
        /// <para>Constructor de la clase</para>
        /// <para>Sirve para devolver el saldo de la cuenta</para>
        /// <value>Cantidad de saldo total</value>
        /// </summary>
        public decimal Saldo
        {
            get { return saldo; }
        }

        /// <summary>
        /// Añade una cantidad especificada al saldo de la cuenta
        /// </summary>
        /// <remarks>El valor tiene que ser mayor que 0</remarks>
        /// <param name="cantidad">Cantidad a ingresar</param>
        /// <example>Ejemplo de uso:
        ///     <code>ingresar(cantidadIngresar)</code>
        /// </example>
        public void ingresar(decimal cantidad)
        {
            if (cantidad > 0)
                saldo = saldo + cantidad;
        }

        /// <summary>
        /// Retira una cantidad especificada al saldo de la cuenta
        /// </summary>
        /// <remarks>
        ///     El valor  
        ///     <paramref name="cantidad"/> 
        ///     tiene que ser mayor que 0 y menor al saldo total
        /// </remarks>
        /// <param name="cantidad">Cantidad a retirar</param>
        /// <example>Ejemplo de uso:
        ///     <code>retirar(cantidadRetirar)</code>
        /// </example>
        /// <returns>Cantidad retirada</returns>
        public decimal retirar(decimal cantidad)
        {
            decimal retirado = 0; //Cantidad que se retira
            if (cantidad > 0 && cantidad <= saldo)
            {
                retirado = cantidad;
                saldo = saldo - cantidad;
            }

            return retirado;
        }
    }
}
