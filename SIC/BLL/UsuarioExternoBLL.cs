using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;
using System.Data;
using System.Windows.Forms;

namespace SIC.BLL
{

    public class UsuarioExternoBLL
    {
        //DAO
        UsuarioExternoDAO usuarioExternoDAO;

        //DataTable
        DataTable dtusuario;

        public UsuarioExternoModelo PesquisarUsuarioExterno(UsuarioExternoModelo usuarioExternoModelo)
        {
            try
            {
                if (usuarioExternoModelo.email != null)
                {
                    usuarioExternoDAO = new UsuarioExternoDAO();
                    dtusuario = new DataTable();

                    return usuarioExternoDAO.PesquisarUsuarioExterno(usuarioExternoModelo);
                }
                
                if (usuarioExternoModelo.usuario != null)
                {
                    usuarioExternoDAO = new UsuarioExternoDAO();
                    dtusuario = new DataTable();

                    return usuarioExternoDAO.PesquisarUsuarioExterno(usuarioExternoModelo);
                }
                else
                {
                    MessageBox.Show("Informe o usuário ou e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }

            }
            catch (Exception)
            {

                throw;
            }
            

            
        }

        public async void IncluirUsuarioExternoTeste(UsuarioExternoModelo listUsuarioExternoModelo)
        {
            Boolean incluido = false;

            usuarioExternoDAO = new UsuarioExternoDAO();

            //string _id = (string)listUsuarioExternoModelo._id;

            if (listUsuarioExternoModelo._id.ToString() == null)
            {
                incluido = usuarioExternoDAO.IncluirUsuarioExternoTeste(listUsuarioExternoModelo);
            }
            else
            {
                incluido = await usuarioExternoDAO.AlterarDadosUsuarioExterno(listUsuarioExternoModelo);
            }

            if (incluido == true)
            {
                MessageBox.Show("Cadastro do usuário " + listUsuarioExternoModelo.usuario + " alterado com sucesso! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

    }
}
