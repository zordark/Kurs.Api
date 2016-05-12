using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Api.Data
{
    /// <summary>
    /// Описание некоторого атрибута объекта системы
    /// </summary>
    public class AttributeDescriptor
    {
        public int Id { get; set; }

        /// <summary>
        /// Глобальный идентификатор атрибута
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Системное имя атрибута
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Отображаемое имя атрибута
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Тип значения
        /// </summary>
        public AttributeDescriptorValueTypes ValueType { get; set; }

        /// <summary>
        /// Для enum типов - его допустимые значения
        /// </summary>
        public IEnumerable<AttributeDescriptorEnumValue> EnumValues { get; set; }

        /// <summary>
        /// Глобальный атрибут - может принадлежать любому мета-типу
        /// </summary>
        public bool IsGlobal { get; set; }

        /// Надо уточнить что это 
        /// <summary>
        /// Ссылка на другой описатель атрибута, который оптеделяет значение этого экземпляра атрибута
        /// </summary>
        //public int? RefValueAttributeId { get; set; }

        /// <summary>
        /// Связанный (родительский) атрибут 
        /// </summary>
        public AttributeDescriptor ParentAttribute { get; set; }
    }
}
