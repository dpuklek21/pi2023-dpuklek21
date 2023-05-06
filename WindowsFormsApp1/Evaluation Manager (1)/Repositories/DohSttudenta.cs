using DBLayer;
using Evaluation_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories {
    public static List<Student> GetStudents() {
        List<Student> students = new List<Student>();
        string sql = "SELECT * FROM Students";
        DB.OpenConnection();
 var reader = DB.GetDataReader(sql);
 while (reader.Read())
 {
 Student student = CreateObject(reader);
        students.Add(student);
 }
    reader.Close();
 DB.CloseConnection();
 return students;
    }
}
