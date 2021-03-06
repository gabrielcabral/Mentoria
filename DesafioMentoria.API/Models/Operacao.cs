using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioMentoria.API.Models
{
    [Table("tb_operacao", Schema="financeiro")]
    public class Operacao
    {
        [Column("cd_seq_operacao")]
        public int Id { get; set; }

        [Column("no_operacao")]
        public string NomeOperacao { get; set; }

        [Column("tp_movimentacao")]
        public char TipoMovimentacao { get; set; }

        [Column("st_ativo")]
        public bool Ativo { get; set; }

        // Relação com a entidade Movimentação
        public Movimentacao Movimentacao { get; set; }


    }
}
