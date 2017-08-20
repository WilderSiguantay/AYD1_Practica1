using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Tests
{
    [TestClass()]
    public class VerificarTests
    {
        [TestMethod()]
        public void TestIngresos()
        {
            //Arrange
            Verificar instancia = new Verificar();
            string nombre = "Diego";
            string apellido = "Maradona";
            string edad = "30";
            string sexo = "0";
            string ingresos = "7000";
            bool esperado = true;
            // Act
            bool resultado = instancia.VerificarMetodo(nombre,apellido,edad,sexo,ingresos);
            //Assert
            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod()]

        public void TestConexion()
        {
            //Arrange
            Conexion con = new Conexion();
            bool esperado = true;
            // Act 
            bool resultado = con.ConectarServer();
            //Assert
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod()]
        public void TestInsertarDatos()
        {
            //Arrange 
            Conexion con = new Conexion();
            bool esperado = false;

            //Act 
            bool resultado = con.Crear("Persona", "Sin Campos", "Sin valores");

            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestEdad()
        {
            //Arrange
            Verificar instancia = new Verificar();
            string nombre = "Diego";
            string apellido = "Maradona";
            string edad = "19";
            string sexo = "0";
            string ingresos = "9000";
            bool esperado = true;
            // Act
            bool resultado = instancia.VerificarMetodo(nombre, apellido, edad, sexo, ingresos);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TestNombre()
        {
            //Arrange 
            Verificar vr = new Verificar();
            string esperado = ("Wilder Siguantay");
            //Act
            String resultado = vr.NombreCompleto("Wilder", "Siguantay");

            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}