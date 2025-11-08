using AkNotes.Services;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkNotes.Models
{
    internal class Nota
    {
        [BsonId]  // Le dice a Mongo que este es el campo _id
        [BsonRepresentation(BsonType.ObjectId)] // Convierte el ObjectId al string automáticamente
        //Atributos
        public string ID {  get; set; }//Este esta dado por MongoDB
        [BsonElement("Titulo")]
        public string Titulo {  get; set; }
        [BsonElement("Contenido")]
        public string Contenido { get; set; }
        [BsonElement("Nota")]
        public string _Nota { get; set; }
        [BsonElement("FechaCreacion")]
        public string FechaCreacion { get; set; } = DateTime.Now.ToString();
        [BsonElement("Tags")]
        public List<string> Tags { get; set; }
        [BsonElement("Preferencia")]
        public bool Preferencia { get; set; } // true = importante, false = no importante

        [BsonElement("UsuarioId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioId { get; set; } // Referencia al usuario

        [BsonElement("FechaModificacion")]
        public string FechaModificacion { get; set; } = DateTime.Now.ToString();
        //METODOS
        //Constructor
        public Nota() { }
        public Nota(string _Titulo,string _Contenido,string _Nota,List<string> _Tags,bool _Preferencia,string _UsuarioId)
            {
                Titulo = _Titulo;
                Contenido = _Contenido;
                this._Nota = _Nota;
                FechaCreacion = DateTime.Now.ToString();
                FechaModificacion = DateTime.Now.ToString();
                Tags = _Tags;
                Preferencia = _Preferencia;
                UsuarioId = _UsuarioId; 
            }
    }
    internal class NotasManager
    {
        //Atributos
        Usuario? Usuario;

        //Metodos
            //Constructor
            public NotasManager(Usuario? usuario)
            {
                Usuario = usuario;
            }
        public List<Nota> GetNotasImportantes()
        {
            return AkNotesBDConnector.GetInstancia().GetListaDeNotasMasImportantes(Usuario);
        }
        public List<Nota> GetTodasLasNotas()
        {
            return AkNotesBDConnector.GetInstancia().GetListaDeNotas(Usuario);
        }
        public List<Nota> GetNotasTags(List<string> Tags)
        {
            return AkNotesBDConnector.GetInstancia().GetListaDeNotasPorTag(Usuario, Tags);
        }
        public void CrearNota(string _Titulo, string _Contenido, string _Nota, List<string> _Tags= null, bool _Preferencia = false)
        {
            Nota nota = new Nota(_Titulo,_Contenido, _Nota, _Tags,_Preferencia,Usuario.Id);
            AkNotesBDConnector.GetInstancia().InsertarNota(nota);
        }
        public void ModificarNota(Nota nota)
        {
            AkNotesBDConnector.GetInstancia().ActualizarNota(nota);
        }
        public void EliminarNota(Nota nota)
        {
            AkNotesBDConnector.GetInstancia().BorrarNota(nota);
        }
        public Nota GetNota(string noteID) 
        {
            return AkNotesBDConnector.GetInstancia().GetNotaPorID(noteID);
        }
    }
}
