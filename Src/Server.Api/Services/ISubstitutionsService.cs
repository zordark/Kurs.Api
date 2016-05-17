using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;

namespace Kurs.Api.Server.Services
{
    public interface ISubstitutionsService
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
        ISubstitution Create( Substitution substitution );

        /// <summary>
        /// ќбновить подстановку
        /// </summary>
        ISubstitution Update( Substitution substitution );

        /// <summary>
        /// —писок всех описателей атрибутов событий доступных дл€ выбора в качестве входных аргументов дл€ подстановок.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetAllowInputAgrumentDescriptors();

        /// <summary>
        /// —писок всех описателей атрибутов команд доступных дл€ выбора в качестве выходных аргументов дл€ подстановок.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetAllowOutputAgrumentDescriptors();
    }
}