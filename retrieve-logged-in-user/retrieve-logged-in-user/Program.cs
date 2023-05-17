using Projeto.Data.Modelo;
using Projeto.Data.Repositorio;

namespace Projeto.Aplicacao.Models
{
    public class LoginModel
    {
        /// <summary>
        /// Método para recuperar o usuário logado no sistema
        /// </summary>
        /// <returns></returns>
        public BVC_Projeto GetUsuarioLogado(string strLogin)
        {
            Repositorio<BVC_Projeto> objUsuarioRep = new Repositorio<BVC_Projeto>();
            return objUsuarioRep.Find(x => x.Login == strLogin);
        }
    }
}