using System.ComponentModel;

namespace FornoEletricoIOT
{
    public enum DistanciaSensorEnum
    {
        [Description("3 Metros")]
        Alta = 3,

        [Description("2 Metros")]
        Media = 2,

        [Description("1 Metros")]
        Baixa = 1,

        [Description("Sensor Desligado")]
        Desligado = 0
    }
}