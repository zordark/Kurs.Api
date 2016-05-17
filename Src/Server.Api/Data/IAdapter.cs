using System;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Описатель адаптера
    /// </summary>
    public interface IAdapter
    {
        int Id { get; }

        /// <summary>
        /// Наименование адаптера 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Базовый адрес WebApi адаптера
        /// </summary>
        Uri WebApiAddress { get; }

        /// <summary>
        /// Базовый адрес сайта адаптера
        /// </summary>
        Uri WebUiAddress { get; }

        /// <summary>
        /// Текущая версия адаптера
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Версия последней загруженной версии (может отличаться от текущей, т.к. обновление применяется по команде)
        /// </summary>
        string UploadedVersion { get; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        DateTime UpdateDate { get; }

        /// <summary>
        /// Описание текущего состояния применения обновления
        /// </summary>
        AdapterUpdateDescription UpdateDescription { get; }
    }
}