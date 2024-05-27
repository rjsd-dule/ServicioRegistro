namespace ProyectUTP.Aplication.Models.Identity
{
    public class ResponseMessage
    {
        public string Message { get; set; } = string.Empty;
        public bool IsError { get; set; } = false;
        public int? StatusCode { get; set; }
    }
}
