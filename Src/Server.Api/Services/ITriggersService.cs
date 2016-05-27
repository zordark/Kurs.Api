using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;

namespace Kurs.Api.Server.Services
{
    public interface ITriggersService
    {
        IEnumerable<ITrigger> Triggers { get; }

        /// <summary>
        /// Найти триггер по Id
        /// </summary>
        /// <param name="triggerId"></param>
        /// <returns></returns>
        ITrigger Find( int triggerId );

        /// <summary>
        /// Удалить триггер
        /// </summary>
        void Delete( int triggerId );

        /// <summary>
        /// Создать новый триггер
        /// </summary>
        ITrigger Create( Trigger trigger );

        /// <summary>
        /// Обновить триггер
        /// </summary>
        ITrigger Update( Trigger trigger );

        /// <summary>
        /// Набор описателей событий адаптеров доступных для выбора в качестве EventDescriptor триггера <see cref="ITrigger"/>>
        /// </summary>
        /// <returns></returns>
        IEnumerable<ITypeDescriptor> GetAllowTriggerDescriptors();

        /// <summary>
        /// Набор подстановок, допустимых для добавления в <see cref="TriggerAction.SubstitutionIds"/> >
        /// </summary>
        /// <param name="triggerDescriptorId">Id-дескриптора триггера</param>
        /// <param name="actionDescriptorId">Id-дескриптора реакции</param>
        /// <returns></returns>
        IEnumerable<ISubstitution> GetAllowActionSubstitutions( int triggerDescriptorId, int actionDescriptorId);

        /// <summary>
        /// Набор значений, допустимых для выбора в качестве значения аргумента триггера>
        /// </summary>
        /// <param name="triggerArgumentDescriptorId">Id-дескриптора аргумента триггера <see cref="TriggerArgument.DescriptorId"/>> </param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        IEnumerable<KeyValuePair<string, string>> GetAllowTriggerArgumentValues( int triggerArgumentDescriptorId );

        /// <summary>
        /// Набор значений, допустимых для выбора в качестве значения аргумента команды триггера>
        /// </summary>
        /// <param name="triggerActionArgumentDescriptorId">Id-дескриптора аргумента реакции триггера <see cref="TriggerActionArgument.DescriptorId"/>> </param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        IEnumerable<KeyValuePair<string, string>> GetAllowTriggerActionArgumentValues( int triggerActionArgumentDescriptorId );

        /// <summary>
        /// Набор команд, которые можно отправить адаптеру
        /// </summary>
        /// <param name="adapterId">Id-адаптера</param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        IEnumerable<ITypeDescriptor> GetAdapterCommands( int adapterId );
    }
}