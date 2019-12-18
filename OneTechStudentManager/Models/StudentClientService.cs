using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace OneTechStudentManager.Models
{
    public class StudentClientService
    {
        private const string BaseUri = "http://localhost:53414/StudentManagerServices.svc";
        public List<Student> GetAllStudents()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadData(BaseUri + "/Students");
            var jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Deserialize<List<Student>>(Encoding.UTF8.GetString(content));
        }
    }
}