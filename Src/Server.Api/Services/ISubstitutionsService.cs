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
        /// Ќайти подстановку по Id
        /// </summary>
        /// <param name="substitutionId"></param>
        /// <returns></returns>
        ISubstitution Find( int substitutionId );

        /// <summary>
        /// ”далить подстановку по Id
        /// </summary>
        void Delete( int substitutionId );

        /// <summary>
        /// —оздать новую подстановку
        /// </summary>
        OperationResult<ISubstitution, SubstitutionValidationErrors> Create( Substitution substitution );

        /// <summary>
        /// ќбновить подстановку
        /// </summary>
        OperationResult<ISubstitution, SubstitutionValidationErrors> Update( Substitution substitution );

        /// <summary>
        /// Ќабор всех описателей атрибутов событий/команд, доступных дл€ выбора в качестве входных/выходных аргументов дл€ подстановок
        /// </summary>
        /// <param name="isInput">true - требуютс€ входные, false - выходные аргументы</param>
        /// <returns></returns>
        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowAgrumentDescriptors( bool isInput );

        //        /// <summary>
        //        /// Ќабор всех описателей атрибутов команд доступных дл€ выбора в качестве выходных аргументов дл€ подстановок, сгруппированных по команде.
        //        /// </summary>
        //        /// <returns></returns>
        //        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowOutputAgrumentDescriptors( IEnumerable<int> attributeDescriptorIds );

        /// <summary>
        /// Ќабор значений, допустимых дл€ выбора в качестве значени€ аргумента триггера>
        /// </summary>
        /// <param name="argumentDescriptorId">Id-дескриптора аргумента подстановки</param>
        /// <param name="parentArgumentKeyOfValue">«начение ключа родительского аргумента. Ќеобходим дл€ корректного определени€ допустимых значений зависимого аргумента. 
        /// Ќапример, если надо выбрать "ѕресет камеры", то надо передать значение выбранное дл€ аргумента " амера"</param>
        /// <returns>Ќабор элементов (значение, отображаемое значение). ≈сли ограничений на выбор значени€ аргумента нет, то null</returns>
        Dictionary<string, string> GetAllowArgumentValues( int argumentDescriptorId, string parentArgumentKeyOfValue );
    }
}