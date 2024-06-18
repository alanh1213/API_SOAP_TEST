using System.Runtime.Serialization;

namespace API_SOAP.Dto
{
    [DataContract]
    public class AuthorDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string? FirstName { get; set; }
        [DataMember]
        public string? LastName { get; set; }
        [DataMember]
        public string? Address { get; set; }
    }
}
