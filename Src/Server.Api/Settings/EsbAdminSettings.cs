using System;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// Настройки управления шиной сообщений RabbitMQ
    /// </summary>
    public class EsbAdminSettings
    {
        /// <summary>
        /// URL HTTP API RabbitMq.
        /// Формат: amqp://сервер-RabbitMQ:Порт
        /// </summary>
        public Uri ConnectionUri { get; set; }

        /// <summary>
        /// Имя пользователя (администратора) для управления шиной
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль администратора
        /// </summary>
        public string Password { get; set; }
    }
}