using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorios;
using System.Runtime.InteropServices.ComTypes;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
