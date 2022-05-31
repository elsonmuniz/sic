using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIC.Modelo;
using SIC.DAO;
using System.Data;
using System.Windows.Forms;
using SIC.DAO;

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
            
            if(usuarioExternoModelo.email.Length !=0 )
            {
                usuarioExternoDAO = new UsuarioExternoDAO();
                dtusuario = new DataTable();

                return usuarioExternoDAO.PesquisarUsuarioExterno(usuarioExternoModelo);
            }
            else
            {
                MessageBox.Show("Informe o usuário ou e-mail.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuarioExternoDAO.PesquisarUsuarioExterno(usuarioExternoModelo);
        }

    }
}
