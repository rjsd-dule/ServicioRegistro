namespace ProyectUTP.Aplication.Models.Identity
{
    public class AllResponseMessage<T> :ResponseMessage
    {
        public List<T> DataResult { get; set; }
    }
}
