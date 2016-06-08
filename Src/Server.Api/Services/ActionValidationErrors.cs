using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class ActionValidationErrors
    {
        /// <summary>
        /// Набор ошибок валидации триггера. В качестве ключа служит имя валидирумого свойства, а в случае со свойством-коллекцией "name#index"
        /// </summary>
        public Dictionary<string, ErrorCodes> Errors { get; } = new Dictionary<string, ErrorCodes>();

        public enum ErrorCodes
        {
            /// <summary>
            /// Указанный дескриптор триггера не существует
            /// </summary>
            TriggerDescriptorNotExist,

            /// <summary>
            /// Указан адаптер не существует
            /// </summary>
            AdapterNotExist,

            /// <summary>
            /// Указанный дескриптор события триггера не существует
            /// </summary>
            DescriptorNotExist,

            /// <summary>
            /// Указан недопустимый дескриптор команды триггера
            /// </summary>
            DescriptorInvalid,

            /// <summary>
            /// Указанная подстановка не существует
            /// </summary>
            SubstitutionNotExist,

            /// <summary>
            /// Указанная подстановка не применима
            /// </summary>
            SubstitutionInvalid,

            /// <summary>
            /// Дескриптор для аргумента триггера не существует
            /// </summary>
            ArgumentDescriptorNotExist,

            /// <summary>
            /// Аргумент триггера включен, но для него не задан фильтр по значению
            /// </summary>
            ArgumentInvalidValue,

            
        }
    }
}