using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    public interface ITrigger
    {
        /// <summary>
        /// Идентификатор триггера
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Включить триггер в работу
        /// </summary>
        bool Enable { get; set; }

        /// <summary>
        /// Название триггера
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Описание триггера
        /// </summary>
        string Hint { get; set; }

        /// <summary>
        /// Описатель события адаптера, с которым связан триггер. После создания триггера изменен быть не может
        /// </summary>
        ITypeDescriptor EventDescriptor { get; }

        /// <summary>
        /// Входные аргументы триггера (все аргументы события EventDescriptor).
        /// Необходимо только назначить SimpleCompare или RegexCompare
        /// </summary>
        IEnumerable<ITriggerArgument> Arguments { get; }

        /// <summary>
        /// Набор действий, выполняемых при сработке триггера
        /// </summary>
        IEnumerable<ITriggerAction> Actions { get; }
    }
}