using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class SubstitutionValidationErrors
    {
        /// <summary>
        /// Есть ли ошибки валидации
        /// </summary>
        public bool IsHaveErrors { get; set; }

        /// <summary>
        /// Ошибка в имени подстановки
        /// </summary>
        public string NameError { get; set; }

        /// <summary>
        /// Ошибка применения режима автомаппинга
        /// </summary>
        public string AutoMappingError { get; set; }

        /// <summary>
        /// Ошибки во входных аргументах
        /// </summary>
        public string InputArgumentsError { get; set; }

        /// <summary>
        /// Ошибки в выходных аргументах
        /// </summary>
        public string OutputArgumentsError { get; set; }

        /// <summary>
        /// набор ошибок в коллекции значений подстановки
        /// </summary>
        public Dictionary<int, string> ArgumentValuesErrors { get; set; } = new Dictionary<int, string>();
    }

//    public class SubstitutionValidationErrors
//    {
//        /// <summary>
//        /// Есть ли ошибки валидации
//        /// </summary>
//        public bool IsHaveErrors { get; set; }
//
//        /// <summary>
//        /// Ошибка в имени подстановки
//        /// </summary>
//        
//
//        /// <summary>
//        /// набор ошибок в коллекции значений подстановки
//        /// </summary>
//        public Dictionary<int, string> ArgumentValuesErrors { get; set; } = new Dictionary<int, string>();
//
//        public enum ErrorCodes
//        {
//            NameAlreadyExist,
//            NameIsNull,
//
//        }
//    }
}