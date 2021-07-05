using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaModel.DAL
{
    class ClientesDAL
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void add(Cliente c)
        {
            clientes.Add(c);
        }


        public List<Cliente> GetAll()
        {
            return clientes;
        } 


        public void Remove(String rut)
        {
            Cliente cliente = clientes.Find(c => c.Rut == rut);
            clientes.Remove(cliente);
        }


        public List<Cliente> GetAll(Int32 nivel)
        {
            return clientes.FindAll(c => c.Nivel == nivel);
        }

    }
}
