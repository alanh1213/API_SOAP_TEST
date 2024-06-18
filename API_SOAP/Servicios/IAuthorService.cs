using System.ServiceModel;
using System.Xml.Linq;

namespace API_SOAP.Servicios
{
    [ServiceContract]
    public interface IAuthorService
    {
        [OperationContract]
        void MySoapMethod(XElement xml);
    }
}