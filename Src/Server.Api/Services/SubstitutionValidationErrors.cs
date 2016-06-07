using System.Collections.Generic;

namespace Kurs.Api.Server.Services
{
    public class SubstitutionValidationErrors
    {
        public bool IsHaveErrors { get; set; }
        public string InputArgumentsError { get; set; }
        public string NameError { get; set; }
        public string OutputArgumentsError { get; set; }
        public string AutoMappingError { get; set; }
        public Dictionary<int, string> ArgumentValuesErrors { get; set; } = new Dictionary<int, string>();
    }
}