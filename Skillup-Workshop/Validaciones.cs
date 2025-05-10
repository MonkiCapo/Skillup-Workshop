using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Skillup_Workshop
{
    public class Validaciones
    {
        public static void Nombre_Apellido(string cadena){
            if(cadena.Length>35){
                throw new ArgumentException("Sobrepasa el límite de 35 caracteres");
            }
        }
        public static void Descripción(string descripción){
            if(descripción.Length>355){
                throw new ArgumentException("");
            }
        }

        public static void Correo(string Correo){
            if(Correo.Contains('@')){
                string Usuario=Correo.Remove(Correo.IndexOf('@'));
                string Dominio=Correo.Remove(0, Correo.IndexOf('@')+1);
                if(Usuario.Length>64 || Dominio.Length>255 || Dominio.Contains('@') || !Dominio.Contains('.')){
                    throw new Exception("\tCorreo Inválido. Posibles razónes:\n1. El nombre de usuario supera los 64 caracteres o el dominio supera los 255 caracteres.\n2. El dominio contiene otro separador(@) o no un (.).");
                }
            }else{
                throw  new Exception("No cumple con un separador(@) o un (.) ");
            }
        }
        
        
        public static void DNI(string DNI){
            if( !int.TryParse(DNI, out _)||DNI.Length>8){
                throw new Exception("El DNI posee otro tipo de caracteres a parte de números o supera los 8 caracteres.");
            }
        }
        public static void Teléfono(string Teléfono){
            
            if(!int.TryParse(Teléfono,out _) || Teléfono.Length>10){
                throw new ArgumentException("");
            }
        }
        public static void Dirección(string Dirección){
            if(Dirección.Length>28){
                throw new ArgumentException("");
            }
        }
        public static void Nacimiento(DateTime Nacimiento){
            if(Nacimiento ==DateTime.Now ){
                throw new ArgumentException("");
            }
        }
        public static void Instructor(bool Disponible){
            if(!Disponible){
                
            }
        }
    }
    
}