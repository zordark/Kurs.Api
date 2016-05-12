using System;

namespace Kurs.Api.Data
{
    public class AdapterInfo
    {
        /// <summary>
        /// Идентифкатор адаптера
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Наименование адаптера 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Текущая версия адаптера
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Номер последней загруженной версии (может отличаться от текущей, т.к. обновление применяется по команде)
        /// </summary>
        public string UploadedVersion { get; set; }

        /// <summary>
        /// Описание текущего состояния применения обновления
        /// </summary>
        public AdapterUpdateDescription UpdateDescription { get; set; }
    }
}