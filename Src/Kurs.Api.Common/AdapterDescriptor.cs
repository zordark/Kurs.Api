using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Api
{
    /// <summary>
    /// Класс описывает систему (адаптер) в составе ПАК КУРС
    /// </summary>
    public class AdapterDescriptor
    {
        /// <summary>
        /// Название адаптера
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отображаемое имя адаптера
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Базовый адрес WebApi адаптера
        /// </summary>
        public Uri WebApiBaseAddress { get; set; }

        /// <summary>
        /// Базовый адрес сайта адаптера
        /// </summary>
        public Uri IISBaseAddress { get; set; }
    }
}
