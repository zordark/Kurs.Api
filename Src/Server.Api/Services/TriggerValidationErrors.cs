using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class TriggerValidationErrors
    {
        /// <summary>
        /// Набор ошибок валидации триггера. В качестве ключа служит имя валидирумого свойства, а в случае со свойством-коллекцией "name#index"
        /// </summary>
        public Dictionary<string, ErrorCodes> Errors { get; } = new Dictionary<string, ErrorCodes>();

        /// <summary>
        /// ошибки валидации реакций
        /// </summary>
        public Dictionary<string, ActionValidationErrors> Actions { get; } = new Dictionary<string, ActionValidationErrors>();

        public enum ErrorCodes
        {
            /// <summary>
            /// Триггер не существует
            /// </summary>
            TriggerNotExist,

            /// <summary>
            /// Триггер с указанным именем уже существует
            /// </summary>
            NameAlreadyExist,

            /// <summary>
            /// Указанный дескриптор события триггера не существует
            /// </summary>
            DescriptorNotExist,

            /// <summary>
            /// Указан недопустимый дескриптор события триггера
            /// </summary>
            DescriptorInvalid,

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