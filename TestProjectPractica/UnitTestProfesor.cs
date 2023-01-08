﻿using Practica;

namespace TestProjectPractica
{
    public class UnitTestProfesor
    {
        [Fact]
        public void Impartir_Una_Materia_Dos_Veces()
        {
            // Arrange
            Profesor profesor = new Profesor();
            string materia1 = "Construcción de Software";
            string materia2 = "Laboratorio Construcción de Software";
            // Act
            profesor.Inscribir(materia1);
            profesor.Inscribir(materia2);
            // Assert
            Assert.Throws<Exception>(() => profesor.Inscribir(materia1));
        }

        [Fact]
        public void Impartir_Solo_Una_Vez()
        {
            // Arrange
            Profesor profesor = new Profesor();
            string materia1 = "Construcción de Software";
            string materia2 = "Laboratorio Construcción de Software";
            // Act
            profesor.Inscribir(materia1);
            profesor.Inscribir(materia2);
            int lenght = profesor.impartiendo.Count();
            // Assert
            Assert.Equal(2, lenght);
        }
    }
}