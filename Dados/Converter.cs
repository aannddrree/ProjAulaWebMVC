using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Converter
    {

        public static Equipamento ConvertToEquipamento(EquipamentoVO equipamentoVO)
        {
            return new Equipamento()
            {
                Id = equipamentoVO.Id,
                Nome = equipamentoVO.Nome,
                Valor = equipamentoVO.Valor,
                DataCadastro = equipamentoVO.DataCadastro
            };
        }

        public static EquipamentoVO ConvertToEquipamentoVO(Equipamento equipamento)
        {
            return new EquipamentoVO()
            {
                Id = equipamento.Id,
                Nome = equipamento.Nome,
                Valor = (decimal) equipamento.Valor,
                DataCadastro = (DateTime) equipamento.DataCadastro
            };
        }

        public static List<EquipamentoVO> ConvertListEquipamentoVO(List<Equipamento> lstEquipamento)
        {
            List<EquipamentoVO> lstEquipamentoVO = new List<EquipamentoVO>();

            foreach (var item in lstEquipamento)
            {
                lstEquipamentoVO.Add(ConvertToEquipamentoVO(item));
            }
            return lstEquipamentoVO;
        }
    }
}
