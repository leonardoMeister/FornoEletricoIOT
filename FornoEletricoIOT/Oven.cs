using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornoEletricoIOT
{
    public class Oven
    {        
        internal int Temperatura;
        public TemperaturaEnum TipoTemperatura { get; internal set; }
        public string Description { get; internal set; }
        public bool DownSide { get; internal set; }
        public bool UpSide { get; internal set; }
        public bool PowerState { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public int IntensidadeLuz { get; internal set; }
        public int TempoDuracaoLuz { get; internal set; }
        public int DistanciaAtividadeSensorLuz { get; internal set; }

        internal bool ValidateData()
        {
            throw new NotImplementedException();
        }
    }
}
