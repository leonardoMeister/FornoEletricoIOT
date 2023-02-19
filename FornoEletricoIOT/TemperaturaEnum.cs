using System.ComponentModel;

namespace FornoEletricoIOT
{
    public enum TemperaturaEnum
    {
        [Description("300ºC")]
        Maxima = 300,

        [Description("270ºC")]
        MuitoAlta = 270,

        [Description("240ºC")]
        Alta = 240,

        [Description("210ºC")]
        Bolo = 210,

        [Description("180ºC")]
        Media = 180,

        [Description("150ºC")]
        Baixa = 150,

        [Description("110ºC")]
        MuitoBaixa = 110,

        [Description("80ºC")]
        Preaquecer = 80
    }
    
}