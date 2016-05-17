using System;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// Настройки брокера
    /// </summary>
    public class EsbPrivateSettings
    {
        /// <summary>
        /// URL для подключения адаптеров к брокеру. 
        /// Формат: amqp://брокер:Порт/Путь
        /// </summary>
        public Uri ConnectionUri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}