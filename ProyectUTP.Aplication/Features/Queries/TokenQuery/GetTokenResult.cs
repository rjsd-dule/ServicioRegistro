namespace ProyectUTP.Application.Features.Queries.TokenQuery
{
    public class GetTokenResult
    {
        public int? TokenId { get; set; }
        public string? NombreCultivo { get; set; }
        public string? TokenValue { get; set; }
        public DateTime? Expira {  get; set; }
    }
}
