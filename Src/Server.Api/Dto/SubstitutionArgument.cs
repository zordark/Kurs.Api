using System;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Описание аргумента подстановки
    /// </summary>
    public class SubstitutionArgument
    {
        /// <summary>
        /// Идентификатор аргумента подстановки 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описатель атрибута, с которым связан аргумент подстановки.
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int AddributeDescriptorId { get; set; }

        /// <summary>
        /// Порядок следования агрумента
        /// </summary>
        public int Order { get; set; }
    }
}