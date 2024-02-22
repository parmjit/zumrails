namespace Backend.Models
{
    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {
            Data = Activator.CreateInstance<T>();
        }
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }
}
