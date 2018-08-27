using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAulaWebMVC
{
    public partial class CadastroEquipamento : System.Web.UI.Page
    {
        ServiceWCF.ServicoClient service;
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            EquipamentoVO equipamento = new EquipamentoVO();

            equipamento.Nome = TxtNome.Text;
            equipamento.Valor = Convert.ToDecimal(TxtValor.Text);
            equipamento.DataCadastro = Convert.ToDateTime(TxtDataCadastro.Text);

            service = new ServiceWCF.ServicoClient();
            if (service.Inserir(equipamento))
            {
                LblMSG.Text = "Registro Inserido!";
                CarregarGrid();
            }
            else
            {
                LblMSG.ForeColor = System.Drawing.Color.Red;
                LblMSG.Text = "Erro ao Inserir registro";
            }
        }

        private void CarregarGrid()
        {
            service = new ServiceWCF.ServicoClient();
            GVEquipamento.DataSource = service.Selecionar();
            GVEquipamento.DataBind();
            
        }
        
    }
}