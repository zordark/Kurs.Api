namespace Kurs.Api.Server.Services
{
    public class OperationResult<TSuccessResult, TErrorResult>
    {
        public bool IsSuccess { get; set; }
        public TSuccessResult Success { get; set; }
        public TErrorResult Error { get; set; }
    }
}