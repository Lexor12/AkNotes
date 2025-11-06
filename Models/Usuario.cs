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
{
    internal class Usuario
    {
        //Atributos
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }
        //Metodos
            //Constructor
            public Usuario() { }
            public Usuario(string _Username, string _Password, DateTime _FechaRegistro) 
            {
                Username = _Username;
                Password = _Password;
                FechaRegistro = _FechaRegistro;
            }
            //Metodos
            
    }
    internal class UsuarioDBManager
    {
        public static bool CrearUsuario(string _Username, string Password)
        {
            Usuario usuario = new Usuario(_Username,Password, DateTime.Now);
            return AkNotesBDConnector.GetInstancia().InsertarUsuario(usuario);
        }
        public static Usuario IniciarSesion(string _Username, string Password)
        {
            Usuario usuario = AkNotesBDConnector.GetInstancia().GetUsuario(_Username,Password);
            return usuario;
        }
        public static bool UsuarioYaExiste(string _Username)
        {
            return AkNotesBDConnector.GetInstancia().UsuarioExiste(_Username);
        }
        public static string ConvertirASha256(string ingreso)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(ingreso));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
