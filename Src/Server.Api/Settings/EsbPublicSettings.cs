using System;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// Настройки сервера лицензирования
    /// </summary>
    public class EsbPublicSettings
    {
        /// <summary>
        /// URL для подключения к серверу лицензирования.
        /// Формат: amqp://сервер-лицензирования:Порт/Путь
        /// </summary>
        public Uri ConnectionUri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}