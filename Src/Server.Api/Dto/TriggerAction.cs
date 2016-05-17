using System.Collections.Generic;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// Реакция на событие, определяется в триггере.
    /// После создания, позволяется редактировать значения аргументов и коллекцию подстановок
    /// </summary>
    public class TriggerAction
    {
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на описатель команды адаптера, которую необходимо выполнить
        /// <see cref="IAttributeDescriptor"/>
        /// </summary>
        public int DescriptorId { get; set; }

        /// <summary>
        /// Адаптер, которому будет отправлена команда
        /// <see cref="IAdapter"/>
        /// </summary>
        public int AdapterId { get; set; }

        /// <summary>
        /// Редактируемая коллекция подстановок для автоматического формирования аргументов команды
        /// </summary>
        public IEnumerable<int> SubstitutionIds { get; set; }

        /// <summary>
        /// Пользовательские аргументы команды
        /// </summary>
        public IEnumerable<TriggerActionArgument> Arguments { get; set; }
    }
}