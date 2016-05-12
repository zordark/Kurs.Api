using System.Collections.Generic;
using Kurs.Api.Data;

namespace Kurs.Api
{
    /// <summary>
    /// Сервис для работы с описателями атрибутов
    /// </summary>
    public interface IAttributeDescriptorService
    {
        IEnumerable<AttributeDescriptor> ReadAll();

        AttributeDescriptor Read(int id);
    }
}