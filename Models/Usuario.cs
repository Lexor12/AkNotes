using System.Security.Cryptography;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkNotes.Services;

namespace AkNotes.Models
{//Mady by Lexor_12 || kennygamer17 on github
    internal class Usuario
    {//Mady by Lexor_12 || kennygamer17 on github
        //Atributos
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Username")]//Mady by Lexor_12 || kennygamer17 on github
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        //Metodos
        //Constructor//Mady by Lexor_12 || kennygamer17 on github
        public Usuario() { }
            public Usuario(string _Username, string _Password, DateTime _FechaRegistro) 
            {
                Username = _Username;//Mady by Lexor_12 || kennygamer17 on github
            Password = _Password;
                FechaRegistro = _FechaRegistro;
            }
        //Metodos

    }//Mady by Lexor_12 || kennygamer17 on github
    internal class UsuarioDBManager
    {
        public static bool CrearUsuario(string _Username, string Password)
        {
            Usuario usuario = new Usuario(ConvertirASha256(_Username), ConvertirASha256(Password), DateTime.Now);
            return AkNotesBDConnector.GetInstancia().InsertarUsuario(usuario);//Mady by Lexor_12 || kennygamer17 on github
        }
        public static Usuario IniciarSesion(string _Username, string Password)
        {
            Usuario usuario = AkNotesBDConnector.GetInstancia().GetUsuario(ConvertirASha256(_Username), ConvertirASha256(Password));
            return usuario;
        }//Mady by Lexor_12 || kennygamer17 on github
        public static bool UsuarioYaExiste(string _Username,string _Password)
        {
            return AkNotesBDConnector.GetInstancia().UsuarioExistePassword(ConvertirASha256(_Username),ConvertirASha256(_Password));
        }//Mady by Lexor_12 || kennygamer17 on github
        public static bool UsuarioYaExisteNombre(string _Username)
        {
            return AkNotesBDConnector.GetInstancia().UsuarioExisteNombre(ConvertirASha256(_Username));
        }//Mady by Lexor_12 || kennygamer17 on github
        public static string ConvertirASha256(string ingreso)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(ingreso));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }//Mady by Lexor_12 || kennygamer17 on github
        }
    }
}
