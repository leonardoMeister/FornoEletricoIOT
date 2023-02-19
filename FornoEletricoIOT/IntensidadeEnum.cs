using System.ComponentModel;

namespace FornoEletricoIOT
{
    public enum IntensidadeEnum
    {
        [Description("Luz Alta")]
        Alta = 3,

        [Description("Luz Media")]
        Media= 2,

        [Description("Luz Baixa")]
        Baixa = 1,
    }
}