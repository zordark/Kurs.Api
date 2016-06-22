namespace Kurs.Api.Services
{
    public class ServiceOperationResult<TSuccessResult, TValidationResult>
    {
        public ServiceOperationResult( bool isSuccess, TSuccessResult successResult, TValidationResult validationResult )
        {
            IsSuccess = isSuccess;
            SuccessResult = successResult;
            ValidationResult = validationResult;
        }

        public bool IsSuccess { get; }

        public TSuccessResult SuccessResult { get; }

        public TValidationResult ValidationResult { get; }
    }
}