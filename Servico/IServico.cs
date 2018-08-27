using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServico" in both code and config file together.
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        bool Inserir(EquipamentoVO equipamento);

        [OperationContract]
        List<EquipamentoVO> Selecionar();
    }
}
