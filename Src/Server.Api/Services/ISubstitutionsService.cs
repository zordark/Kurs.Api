using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface ISubstitutionsService : IKursApiService
    {
        IEnumerable<ISubstitution> Substitutions { get; }

        /// <summary>
        /// Найти подстановку по Id
        /// </summary>
        /// <param name="substitutionId"></param>
        /// <returns></returns>
        ISubstitution Find( int substitutionId );

        /// <summary>
        /// Удалить подстановку по Id
        /// </summary>
        void Delete( int substitutionId );

        /// <summary>
        /// Создать новую подстановку
        /// </summary>
        ISubstitution Create( Substitution substitution );

        /// <summary>
        /// Обновить подстановку
        /// </summary>
        ISubstitution Update( Substitution substitution );

        /// <summary>
        /// Набор всех описателей атрибутов событий доступных для выбора в качестве входных аргументов для подстановок, сгруппированных по событию.
        /// </summary>
        /// <returns></returns>
        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowInputAgrumentDescriptors();

        /// <summary>
        /// Набор всех описателей атрибутов команд доступных для выбора в качестве выходных аргументов для подстановок, сгруппированных по команде.
        /// </summary>
        /// <returns></returns>
        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowOutputAgrumentDescriptors();

        /// <summary>
        /// Набор значений, допустимых для выбора в качестве значения аргумента триггера>
        /// </summary>
        /// <param name="argumentDescriptorId">Id-дескриптора аргумента подстановки</param>
        /// <param name="parentArgumentKeyOfValue">Значение ключа родительского аргумента. Необходим для корректного определения допустимых значений зависимого аргумента. 
        /// Например, если надо выбрать "Пресет камеры", то надо передать значение выбранное для аргумента "Камера"</param>
        /// <returns>Набор элементов (значение, отображаемое значение). Если ограничений на выбор значения аргумента нет, то null</returns>
        Dictionary<string, string> GetAllowArgumentValues( int argumentDescriptorId, string parentArgumentKeyOfValue );
    }
}