using System;

namespace Kurs.Api.Server.Settings
{
    public class EsbNodeSettings
    {
        /// <summary>
        /// ID объекта ПАК КУРС
        /// </summary>
        public string KursId { get; set; }

        /// <summary>
        /// Наименование объекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URL удаленного объекта КУРС. Формат: http://RabbitMQ-сервер:Порт/Путь
        /// </summary>
        public Uri Uri { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Положение узла КУРС в иерархии по отношению к нам
        /// </summary>
        public EsbNodePlacement Placement { get; set; }
    }
}