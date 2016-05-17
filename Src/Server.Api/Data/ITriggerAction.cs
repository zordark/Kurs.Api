using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// Реакция на событие, определяется в триггере.
    /// После создания, позволяется редактировать значения аргументов и коллекцию подстановок
    /// </summary>
    public interface ITriggerAction
    {
        int Id { get; }

        /// <summary>
        /// Триггер, в котором определено это действие
        /// </summary>
        ITrigger Trigger { get; }

        /// <summary>
        /// Ссылка на описатель команды адаптера, которую необходимо выполнить
        /// </summary>
        ITypeDescriptor Descriptor { get; }

        /// <summary>
        /// Адаптер, которому будет отправлена команда
        /// </summary>
        IAdapter Adapter { get; }

        /// <summary>
        /// Редактируемая коллекция подстановок для автоматического формирования аргументов команды
        /// </summary>
        IEnumerable<ISubstitution> Substitutions { get; }

        /// <summary>
        /// Пользовательские аргументы команды
        /// </summary>
        IEnumerable<ITriggerActionArgument> Arguments { get; }
    }
}