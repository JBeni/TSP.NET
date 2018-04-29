using System.Collections.Generic;


namespace Library.Services.Models
{
    public class Response
    {
        public Response()
        {
            Error = false;
            Messages = new List<string>();
            Id = 0;
        }

        public bool Error { get; set; }
        public List<string> Messages { get; set; }
        public int Id { get; set; }
    }
}
