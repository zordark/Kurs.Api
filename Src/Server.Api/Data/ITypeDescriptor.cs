
using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Описатель типа (объектов и сообщений адаптеров)
    /// </summary>
    public interface ITypeDescriptor
    {
        int Id { get; }

        /// <summary>
        /// Глобальный идентификатор атрибута
        /// </summary>
        string Uid { get; }

        TypeDescriptorKind Kind { get; }

        string DisplayName { get; }

        /// <summary>
        /// Если это глобальный тип
        /// </summary>
        bool IsGlobal { get; }

        /// <summary>
        /// Адаптер-владелец мета-типа. Если тип глобальный - то null
        /// </summary>
        IAdapter Adapter { get; }

        /// <summary>
        /// Родительский мета-тип (например 'камера' для 'ptz')
        /// </summary>
        ITypeDescriptor ParentType { get; }

        /// <summary>
        /// Получить список атрибутов типа
        /// </summary>
        IEnumerable<IAttributeDescriptor> Attributes { get; }

        /// <summary>
        /// Дочерние мета-типы (например 'ptz' для 'камеры')
        /// </summary>
        IEnumerable<ITypeDescriptor> Childs { get; }
    }
}