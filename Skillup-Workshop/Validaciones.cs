using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Skillup_Workshop
{
    public class Validaciones
    {
        public static void Longitud(string cadena)
        {
            if (cadena.Length > 35 || String.IsNullOrWhiteSpace(cadena))
            {
                throw new ArgumentException("Sobrepasa el límite de 35 caracteres");
            }
        }
        public static void Descripción(string descripción)
        {
            if (descripción.Length > 355 || String.IsNullOrWhiteSpace(descripción))
            {
                throw new ArgumentException("Sobrepasa el límite de 355 caracteres");
            }
        }

        public static void Correo(string Correo)
        {
            if (Correo.Contains('@')) {
                string Usuario = Correo.Remove(Correo.IndexOf('@'));
                string Dominio = Correo.Remove(0, Correo.IndexOf('@') + 1);
                if (Usuario.Length > 64 || Dominio.Length > 255 || Dominio.Contains('@') || !Dominio.Contains('.'))
                {
                    throw new Exception("\tCorreo Inválido. Posibles razónes:\n1. El nombre de usuario supera los 64 caracteres o el dominio supera los 255 caracteres.\n2. El dominio contiene otro separador(@) o no contenga un (.).");
                }
            }
            else {
                throw new Exception("No cumple con un separador(@)");
            }
        }


        public static void DNI(string DNI)
        {
            if (!int.TryParse(DNI, out _) || DNI.Length > 8)
            {
                throw new Exception("El DNI posee otro tipo de caracteres a parte de números o supera los 8 caracteres.");
            }
        }
        public static void Teléfono(string Teléfono)
        {

            if (!int.TryParse(Teléfono, out _) || Teléfono.Length > 10)
            {
                throw new ArgumentException("El teléfono solo debe contener números y no superar los 10 caracteres.");
            }
        }
        public static void Dirección(string Dirección)
        {
            if (Dirección.Length > 28 || String.IsNullOrWhiteSpace(Dirección))
            {
                throw new ArgumentException("La dirección supera los 28 caracteres");
            }
        }
        public static void Nacimiento(DateTime Nacimiento)
        {
            if (Nacimiento >= DateTime.Now.Date.AddYears(-13))
            {
                throw new ArgumentException("Es necesario tener más de 13 años para ingresar al programa.");
            }
        }
        public static void Dificultad(string _dificultad)
        {
            string[] dificultades = { "Facil", "Intermedio", "Avanzado" };
            if (dificultades.FirstOrDefault(d => d.ToLower() == _dificultad.ToLower().Trim()) is null) throw new ArgumentException("Dificultad no encontrada");
        }
        public static void Estado(string estado, Alumno alumno)
        {
            string[] estados = { "Activo", "Cancelado", "Finalizado" };
            estado = estado.Trim().ToLower();
            if (estados.FirstOrDefault(e => e.ToLower() == estado) is null) throw new Exception("Estado no encontrado");
            else if (estados[2].ToLower() == estado)
            {
                alumno = null!;
            }
        }
        public static void valorCero(var numero){
            if(numero==0){
                throw new ArgumentException("El número ingresado debe ser mayor a 0");
            }
        }
    }
}
