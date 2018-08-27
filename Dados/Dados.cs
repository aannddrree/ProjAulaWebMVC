using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Dados
    {
        public bool Inserir(EquipamentoVO equipamento)
        {
            EquipamentoEntities context = new EquipamentoEntities();
            context.Equipamento.Add(Converter.ConvertToEquipamento(equipamento));
            int retorno = context.SaveChanges();

            if (retorno == 1)
                return true;
            return false;
        }

        public List<EquipamentoVO> Selecionar()
        {
            EquipamentoEntities context = new EquipamentoEntities();
            var lstEquipamento = context.Equipamento.ToList<Equipamento>();
            return Converter.ConvertListEquipamentoVO(lstEquipamento);
        }
    }
}
