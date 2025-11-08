using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkNotes.Models;
using MongoDB.Driver;

namespace AkNotes.Services
{
    internal class BDConnector
    {
        private static BDConnector? _BDConnector = null;
        private MongoClient? _mongoClient;
        protected IMongoDatabase db;

        protected BDConnector() 
        {
            string? MongoDBConn = Program.Configuration?["MongoDB:ConnectionString"];
            string? dbName = Program.Configuration?["MongoDB:DatabaseName"];
            _mongoClient = new MongoClient(MongoDBConn);
            db = _mongoClient.GetDatabase(dbName);
        }
        public static BDConnector GetInstancia()
        {
            if ( _BDConnector == null)
            {
                _BDConnector = new BDConnector();
            }
            return _BDConnector;
        }
        public IMongoCollection<T> GetCollection<T>(string nombreCollection) 
        {
            return db.GetCollection<T>(nombreCollection);   
        }
    }
    internal class AkNotesBDConnector
    {
        private static AkNotesBDConnector? _AkNotesBDConnector = null;
        private static IMongoCollection<Nota> collectionNotas => BDConnector.GetInstancia().GetCollection<Nota>("Notas");
        private static IMongoCollection<Usuario> collectionUsuario => BDConnector.GetInstancia().GetCollection<Usuario>("Usuarios");
        private AkNotesBDConnector() { }
        public static AkNotesBDConnector GetInstancia()
        {
            if (_AkNotesBDConnector == null)
            {
                _AkNotesBDConnector = new AkNotesBDConnector();
            }
            return _AkNotesBDConnector;
        }
        //CRUD Nota
        public void InsertarNota(Nota nota)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            collectionNotas.InsertOne(nota);
        }
        public List<Nota> GetListaDeNotas(Usuario usuario)
        {
            return collectionNotas.Find(n => n.UsuarioId == usuario.Id).ToList();
        }
        public Nota GetNotaPorID(string ID)
        {
            return collectionNotas.Find(n => n.UsuarioId == ID).FirstOrDefault();
        }
        public List<Nota> GetListaDeNotasMasImportantes(Usuario usuario)
        {
            return collectionNotas.Find(n => n.UsuarioId == usuario.Id && n.Preferencia == true).ToList();
        }
        public List<Nota> GetListaDeNotasPorTag(Usuario usuario,List<string> tags)
        {
            return collectionNotas.Find(n => n.UsuarioId == usuario.Id && n.Tags.Any(tag => tags.Contains(tag))).ToList();
        }
        public void ActualizarNota(Nota nota)//Como siempre que se crea una nota ya se guarda, pues entonces ya tiene ID
        {
            collectionNotas.ReplaceOne(x => x.ID == nota.ID,nota);
        }
        public void BorrarNota(Nota nota)
        {
            collectionNotas.DeleteOne(x=>x.ID == nota.ID);
        }
        //CRUD Usuario
        public bool InsertarUsuario(Usuario usuario)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            if (UsuarioExistePassword(usuario.Username,usuario.Password)) return false; 
            collectionUsuario.InsertOne(usuario);
            return true;
        }
        public bool UsuarioExistePassword(string Username, string password)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            if (collectionUsuario.Find(n => n.Username == Username &&n.Password == password ).ToList().Count() != 0) return true;
            return false;
        }
        public bool UsuarioExisteNombre(string Username)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            if (collectionUsuario.Find(n => n.Username == Username).ToList().Count() != 0) return true;
            return false;
        }
        public Usuario GetUsuario(string _Nombre,string _PasswordSha256)
        {
            return collectionUsuario.Find(x => x.Username == _Nombre && x.Password == _PasswordSha256).FirstOrDefault();
        }
    }
}
