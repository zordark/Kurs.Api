using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    public interface IAttributeDescriptor
    {
        int Id { get; }

        /// <summary>
        /// Глобальный идентификатор атрибута
        /// </summary>
        string Uid { get; }

        /// <summary>
        /// Системное имя атрибута
        /// </summary>
        string SystemName { get; }

        /// <summary>
        /// Отображаемое имя атрибута
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Тип значения, например "string", "int", "json"
        /// </summary>
        AttributeDescriptorValueTypes ValueType { get; }

        /// <summary>
        /// Для простых типов содержит список допустимых значений
        /// </summary>
        IEnumerable<AttributeDescriptorEnumValue> AllowValues { get; }

        /// <summary>
        /// Для JSON-типа содержит его описание
        /// </summary>
        string JsonDescription { get; }

        /// <summary>
        /// Флаг, который указывает что данный атрибут является глобальным, тоесть может принадлежать любому типу
        /// </summary>
        bool IsGlobal { get; }

        /// <summary>
        /// Используется при описании аргументов команд и событий.
        /// Задает ссылку на описатель атрибута объекта адаптера.
        /// То есть при заданиии значения для этого аргумента нельзя задать произвольное значение, 
        /// а необходимо указать объект, из соответствующего атрибута которого и будет взято значение для аргумента
        /// </summary>
        IAttributeDescriptor RefValue { get; }

        /// <summary>
        /// Используется при описании аргументов команд и событий. 
        /// Задает ссылку на другой аргумент команды/события, от которого зависит этот атрибут.
        /// Например, аргумент команды "ptz-камеры", зависит от аргумента "камера"
        /// </summary>
        IAttributeDescriptor ParentAttribute { get; }
    }
}