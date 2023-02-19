using System;

namespace FornoEletricoIOT
{
    public class OvenMib : Mib, IConfigure
    {
        private Oven _oven;

        public OvenMib(Oven oven)
        {
            _oven = oven;
            ConfigureAplication();            
        }

        public void ConfigureAplication()
        {            
            var result = SendRequestIOT(_oven);            
        }

        /// <summary>
        /// Configura o lado superior e inferior do Forno para ligado ou desligado
        /// </summary>
        /// <param name="down">Define se o lado inferior vai estar ligado ou não</param>
        /// <param name="up">Define se o lado superior vai estar ligado ou não</param>
        public void ConfigureSidesOn(bool down = false, bool up = false)
        {
            _oven.DownSide = down;
            _oven.UpSide = up;
            ConfigureAplication();
        }

        /// <summary>
        /// Configura a intensidade da luz, tempo que vai permanecer ligada e a distancia do sensor para ligar a luz
        /// </summary>
        /// <param name="intensidade">Enum correspondente a intensidade que a luz vai ser ligada</param>
        /// <param name="tempoDuracao">Int correspondente ao tempo de duracao em Segundos que a luz permanece ligada</param>
        /// <param name="distancia">Enum correspondente a distancia que o sensor capta movimentos para ativacao da luz</param>
        public void ConfigureLight(IntensidadeEnum intensidade, int tempoDuracao, DistanciaSensorEnum distancia)
        {
            _oven.IntensidadeLuz = (int)intensidade;
            _oven.TempoDuracaoLuz = tempoDuracao;
            _oven.DistanciaAtividadeSensorLuz = (int)distancia;
            
            ConfigureAplication();
        }
        /// <summary>
        /// Configura uma data para ligar e desligar o forno automaticamente. 
        /// </summary>
        /// <param name="initialize">Data usada para configuar o inicio do forno</param>
        /// <param name="finish">Data usada para configurar a finalização do forno</param>
        /// <returns>Retorna uma string correspondente a validação das datas.</returns>
        public  string ConfigureWhenInitialize(DateTime initialize, DateTime finish)
        {
            _oven.DataInicio = initialize;
            _oven.DataTermino = finish;

            bool validate = _oven.ValidateData();

            if (validate) ConfigureAplication();
            else return "Datas inválidas, favor tente novamente!";
            return "Datas Válidas!";
        }

        /// <summary>
        /// Configura o estado de ligado e desligado do forno com base em um operador logico bool
        /// </summary>
        /// <param name="powerState">Define se o forno vai estar ligado TRUE ou desligado False</param>
        public void ConfigureOnOff(bool powerState= false)
        {
            _oven.PowerState = powerState;
            
            ConfigureAplication();
        }

        /// <summary>
        /// Configura a temperatura desejada do forno com base enum
        /// </summary>
        /// <param name="temp">Enumerador para controle das temperaturas escolhidas</param>
        public void ConfigureTemperature(TemperaturaEnum temp) 
        {            
            _oven.Temperatura = (int)temp;
            _oven.TipoTemperatura = temp;
            _oven.Description = temp.ObterDescricao();
            ConfigureAplication();
        }
    }
}
