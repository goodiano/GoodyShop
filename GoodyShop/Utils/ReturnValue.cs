namespace GoodyShop.Utils
{
    public class ReturnValue
    {
        public Message Message { get; set; }
        public List<string> Data { get; set; }
        public int HttpStatusCode { get; set; }
    }
}
