﻿using System;

namespace Kurs.Api
{
    public class SystemDescriptor
    {
        /// <summary>
        /// Наименование системы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Базовый адрес головного сайта
        /// </summary>
        public Uri IISBaseAddress { get; set; }
    }
}