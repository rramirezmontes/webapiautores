using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebAPIAutores.Tests.PruebasUnitarias
{
    [TestClass]
    public class PrimeraLetraMayusculaAttributeTest
    {
        [TestMethod]
        public void PrimeraLetraMiniscula_DevuelveError()
        {
            //Preparacion

            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            var valor = "raul";
            var valContext = new ValidationContext(new { Nombre = valor });

            //Ejecucion

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);


            //Verificacion

            Assert.AreEqual("La primera letra debe ser mayuscula",resultado.ErrorMessage);
        }

        [TestMethod]
        public void ValorNulo_NoDevuelveError()
        {
            //Preparacion

            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = null;
            var valContext = new ValidationContext(new { Nombre = valor });

            //Ejecucion

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);


            //Verificacion

            Assert.IsNull(resultado);
        }


        [TestMethod]
        public void ValorConPrimeraLetraMayuscula_NoDevuelveError()
        {
            //Preparacion

            var primeraLetraMayuscula = new PrimeraLetraMayusculaAttribute();
            string valor = "Felipon";
            var valContext = new ValidationContext(new { Nombre = valor });

            //Ejecucion

            var resultado = primeraLetraMayuscula.GetValidationResult(valor, valContext);


            //Verificacion

            Assert.IsNull(resultado);
        }

    }
}