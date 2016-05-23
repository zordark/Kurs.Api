using System.Collections.Generic;
using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Dto
{
    public class Trigger
    {
        /// <summary>
        /// Идентификатор триггера
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Включить триггер в работу
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// Название триггера
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание триггера
        /// </summary>
        public string Hint { get; set; }

        /// <summary>
        /// Описатель сообытия адаптера, с которым связан триггер. После создания триггера изменен быть не может
        /// <see cref="ITypeDescriptor"/>
        /// </summary>
        public int EventDescriptorId { get; set; }

        /// <summary>
        /// Входные аргументы триггера (все аргументы события EventDescriptor).
        /// Необходимо только назначить SimpleCompare или RegexCompare
        /// </summary>
        public IEnumerable<TriggerArgument> Arguments { get; set; }

        /// <summary>
        /// Набор действий, выполняемых при сработке триггера
        /// </summary>
        public IEnumerable<TriggerAction> Actions { get; set; }
    }
}