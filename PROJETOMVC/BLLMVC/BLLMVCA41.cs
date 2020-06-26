using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJETOMVCA41.DALMVC;

namespace PROJETOMVCA41.BLLMVC
{
    class BLLMVCA41
    {

        private DALMVCA41 DaoBanco = new DALMVCA41();
        public Boolean Autenticar(string cpf, string nome, string mae)
        {
            string consulta = string.Format($"select * from tbl_clientea27 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{mae}';");
            DataTable dt = DaoBanco.executarConsulta(consulta);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
