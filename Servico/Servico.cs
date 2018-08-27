using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dados;
using Entidade;

namespace Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servico" in both code and config file together.
    public class Servico : IServico
    {
        public bool Inserir(EquipamentoVO equipamento)
        {
            return new Dados.Dados().Inserir(equipamento);
        }

        public List<EquipamentoVO> Selecionar()
        {
            return new Dados.Dados().Selecionar();
        }
    }
}
