using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface ITriggersService : IKursApiService
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
        OperationResult<ITrigger, TriggerValidationErrors> Create( Trigger trigger );

        /// <summary>
        /// Обновить триггер
        /// </summary>
        OperationResult<ITrigger, TriggerValidationErrors> Update( Trigger trigger );

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
        IEnumerable<ISubstitution> GetAllowActionSubstitutions( int triggerDescriptorId, int actionDescriptorId );

        /// <summary>
        /// Набор аргументов команды, которые остались неопределенными с помощью указанных подстановок>
        /// </summary>
        /// <param name="actionDescriptorId">Id-дескриптора реакции</param>
        /// <param name="substitutionIds">набор Id подстановок реакции</param>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetNotDefinedActionArguments( int actionDescriptorId, IEnumerable<int> substitutionIds );

        /// <summary>
        /// Набор значений, допустимых для выбора в качестве значения аргумента триггера>
        /// </summary>
        /// <param name="triggerArgumentDescriptorId">Id-дескриптора аргумента триггера <see cref="TriggerArgument.DescriptorId"/>> </param>
        /// <param name="parentArgumentKeyOfValue">Значение ключа родительского аргумента. Необходим для корректного определения допустимых значений зависимого аргумента. 
        /// Например, если надо выбрать "Пресет камеры", то надо передать значение выбранное для аргумента "Камера"</param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        Dictionary<string, string> GetAllowTriggerArgumentValues( int triggerArgumentDescriptorId, string parentArgumentKeyOfValue );

        /// <summary>
        /// Набор значений, допустимых для выбора в качестве значения аргумента команды триггера>
        /// </summary>
        /// <param name="triggerActionArgumentDescriptorId">Id-дескриптора аргумента реакции триггера <see cref="TriggerActionArgument.DescriptorId"/>> </param>
        /// <param name="parentArgumentKeyOfValue">Значение ключа родительского аргумента. Необходим для корректного определения допустимых значений зависимого аргумента. 
        /// Например, если надо выбрать "Пресет камеры", то надо передать значение выбранное для аргумента "Камера"</param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        Dictionary<string, string> GetAllowTriggerActionArgumentValues( int triggerActionArgumentDescriptorId, string parentArgumentKeyOfValue );

        /// <summary>
        /// Набор команд, которые можно отправить адаптеру
        /// </summary>
        /// <param name="adapterId">Id-адаптера</param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        IEnumerable<ITypeDescriptor> GetAdapterCommands( int adapterId );
    }
}