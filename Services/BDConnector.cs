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
        public event Action ErrorAlConectar = delegate { };
        private MongoClient? _mongoClient;
        protected IMongoDatabase db;
        //Mady by Lexor_12 || kennygamer17 on github
        protected BDConnector() 
        {
            try
            {
                string? MongoDBConn = Program.Configuration?["MongoDB:ConnectionString"];
                string? dbName = Program.Configuration?["MongoDB:DatabaseName"];
                _mongoClient = new MongoClient(MongoDBConn);
                db = _mongoClient.GetDatabase(dbName);
            }
            catch (Exception ex) 
            {
                ErrorAlConectar.Invoke();  
                MessageBox.Show("Error al conectar con la Base de datos:"+ex.Message);
            }
            
        }//Mady by Lexor_12 || kennygamer17 on github
        public static BDConnector GetInstancia()
        {
            if ( _BDConnector == null)
            {
                _BDConnector = new BDConnector();
            }//Mady by Lexor_12 || kennygamer17 on github
            return _BDConnector;
        }
        public IMongoCollection<T> GetCollection<T>(string nombreCollection) 
        {
            ErrorAlConectar.Invoke();
            return db.GetCollection<T>(nombreCollection);   
        }
    }
    internal class AkNotesBDConnector//Mady by Lexor_12 || kennygamer17 on github
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
            }//Mady by Lexor_12 || kennygamer17 on github
            return _AkNotesBDConnector;
        }
        //CRUD Nota
        public void InsertarNota(Nota nota)//Siempre que vayamos a agregar una nota se guarda aqui
        {//Mady by Lexor_12 || kennygamer17 on github
            try
            {
                collectionNotas.InsertOne(nota);
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
            }
        }
        public List<Nota> GetListaDeNotas(Usuario usuario)
        {
            try
            {
                return collectionNotas.Find(n => n.UsuarioId == usuario.Id).ToList();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return new List<Nota>();
            }
        }
        public List<Nota> GetListaDeNotasPublicas()
        {
            try
            {
                return collectionNotas.Find(n => n.Compartir == Compartir.Publico).ToList();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return new List<Nota>();
            }
        }
        public List<Nota> GetListaDeNotasCompartidas(Usuario usuario)
        {
            try
            {


                List<Nota> todasNotas = new List<Nota>();
                foreach (var item in collectionNotas.Find(_ => _.Compartir == Compartir.Compartir).ToList()) 
                {
                    if(item.UsuariosUsername.Contains(usuario.Username)) todasNotas.Add(item);
                }
                return todasNotas;
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return new List<Nota>();
            }
        }
        public Nota GetNotaPorID(string ID)
        {
            try
            {
                return collectionNotas.Find(n => n.UsuarioId == ID).FirstOrDefault();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return null;
            }
        }
        public Nota GetNotaPorIDNota(string ID)
        {
            try
            {
                return collectionNotas.Find(n => n.ID == ID && n.Compartir == Compartir.Codigo).FirstOrDefault();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return null;
            }
        }
        public List<Nota> GetListaDeNotasMasImportantes(Usuario usuario)
        {
            try
            {
                return collectionNotas.Find(n => n.UsuarioId == usuario.Id && n.Preferencia == true).ToList();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return new List<Nota>();
            }
        }
        public List<Nota> GetListaDeNotasPorTag(Usuario usuario,List<string> tags)
        {
            try
            {
                return collectionNotas.Find(n => n.UsuarioId == usuario.Id && n.Tags.Any(tag => tags.Contains(tag))).ToList();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return new List<Nota>();
            }
        }
        public void ActualizarNota(Nota nota)//Como siempre que se crea una nota ya se guarda, pues entonces ya tiene ID
        {
            try
            {
                collectionNotas.ReplaceOne(x => x.ID == nota.ID,nota);
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
            }
        }
        public void BorrarNota(Nota nota)
        {
            try
            {
                collectionNotas.DeleteOne(x=>x.ID == nota.ID);
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
            }
        }
        //CRUD Usuario//Mady by Lexor_12 || kennygamer17 on github
        public bool InsertarUsuario(Usuario usuario)//Siempre que vayamos a agregar una nota se guarda aqui//Mady by Lexor_12 || kennygamer17 on github
        {
            try
            {
                if (UsuarioExistePassword(usuario.Username,usuario.Password)) return false; 
                collectionUsuario.InsertOne(usuario);
                return true;
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return false;
            }
        }
        public bool UsuarioExistePassword(string Username, string password)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            try
            {
                if (collectionUsuario.Find(n => n.Username == Username &&n.Password == password ).ToList().Count() != 0) return true;
                return false;
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return false;
            }
        }
        public bool UsuarioExisteNombre(string Username)//Siempre que vayamos a agregar una nota se guarda aqui
        {
            try
            {
                if (collectionUsuario.Find(n => n.Username == Username).ToList().Count() != 0) return true;
                return false;//Mady by Lexor_12 || kennygamer17 on github
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return false;
            }
        }
        public Usuario GetUsuario(string _Nombre,string _PasswordSha256)
        {
            try
            {
                return collectionUsuario.Find(x => x.Username == _Nombre && x.Password == _PasswordSha256).FirstOrDefault();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return null;
            }
        }
        public Usuario GetUsuarioID(string id)
        {
            try
            {
                return collectionUsuario.Find(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la base de datos, verifica tu conexión a internet y/o intentalo más tarde");
                return null;
            }
        }
    }//Mady by Lexor_12 || kennygamer17 on github
}
