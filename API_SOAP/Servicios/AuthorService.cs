using System.Diagnostics;
using System.Xml.Linq;

namespace API_SOAP.Servicios
{
    public class AuthorService : IAuthorService
    {
        public void MySoapMethod(XElement xml)
        {
            Trace.WriteLine(xml.ToString());
        }
    }
}
