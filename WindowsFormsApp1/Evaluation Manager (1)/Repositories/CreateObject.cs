using Evaluation_Manager.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories {
    private static Student CreateObject(SqlDataReader reader) 
        {
        int id = int.Parse(reader["Id"].ToString());
        string firstName = reader["FirstName"].ToString();
        string lastName = reader["LastName"].ToString();
        int.TryParse(reader["Grade"].ToString(), out int grade);
        var student = new Student {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            Grade = grade
        };
 return student;
    }
}
