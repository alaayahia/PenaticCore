namespace PenaticCore.Infrastructure.Helpers
{
    public class ResponseModel<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public IList<string>? Errors { get; set; }
        public Dictionary<string, string> Extras { get; set; } = new Dictionary<string, string>();
        public ResponseModel(T? data = default, bool success = true, string message = "", IList<string>? errors = null)
        {
            Data = data;
            Success = success;
            Message = message;
            Errors = errors;
        }
    }
}
