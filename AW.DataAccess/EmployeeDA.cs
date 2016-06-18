using AW.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AW.DataAccess
{
    public class EmployeeDA
    {
        private string strConnection = "Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=true;";
        public List<Employee> GetEmployees()
        {
            var sql = "select BusinessEntityID,NationalIDNumber,LoginID,JobTitle,BirthDate,VacationHours from HumanResources.Employee with(nolock)";
            //var
            List<Employee> listado = new List<Employee>();
            //cn.close manera explicita
            //SqlConnection cn;
            using (SqlConnection cn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(sql,cn);
                cn.Open();

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var emp = new Employee();
                    var indice = 0;
                    indice = reader.GetOrdinal("BusinessEntityID");
                    //no es optimo reader["BusinessEntityID"]
                    emp.BusinessEntityID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NationalIDNumber");
                    emp.NationalIDNumber = reader.GetString(indice);

                    //emp.NationalIDNumber=reader.GetString()
                    indice = reader.GetOrdinal("LoginID");
                    emp.LoginID = reader.GetString(indice);                 

                    indice = reader.GetOrdinal("JobTitle");
                    emp.JobTitle = reader.GetString(indice);

                    indice = reader.GetOrdinal("BirthDate");
                    emp.BirthDate = reader.IsDBNull(indice)? new Nullable<DateTime>() : reader.GetDateTime(indice);

                    indice = reader.GetOrdinal("VacationHours");
                    emp.VacationHours = reader.GetInt16(indice);
                    listado.Add(emp);
                }

            }
            return listado;
        }
        public List<Employee> GetEmployeesWithParam(string JobTitle)
        {
            //JobTitle = string.Concat("%",JobTitle,"%");
            var sql = "select BusinessEntityID,NationalIDNumber,LoginID,JobTitle,BirthDate,VacationHours " +
            "from HumanResources.Employee with(nolock) where JobTitle like '%'+ @JobTitle +'%'";
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@JobTitle";
            param1.SqlDbType = System.Data.SqlDbType.NVarChar;
            param1.Value = JobTitle;

            List <Employee> listado = new List<Employee>();
            //cn.close manera explicita
            //SqlConnection cn;
            using (SqlConnection cn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add(param1);
                cn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var emp = new Employee();
                    var indice = 0;
                    indice = reader.GetOrdinal("BusinessEntityID");
                    //no es optimo reader["BusinessEntityID"]
                    emp.BusinessEntityID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NationalIDNumber");
                    emp.NationalIDNumber = reader.GetString(indice);

                    //emp.NationalIDNumber=reader.GetString()
                    indice = reader.GetOrdinal("LoginID");
                    emp.LoginID = reader.GetString(indice);

                    indice = reader.GetOrdinal("JobTitle");
                    emp.JobTitle = reader.GetString(indice);

                    indice = reader.GetOrdinal("BirthDate");
                    emp.BirthDate = reader.IsDBNull(indice) ? new Nullable<DateTime>() : reader.GetDateTime(indice);

                    indice = reader.GetOrdinal("VacationHours");
                    emp.VacationHours = reader.GetInt16(indice);
                    listado.Add(emp);
                }

            }
            return listado;
        }

        public List<Employee> GetEmployeesWithParamSP(string JobTitle)
        {
            //JobTitle = string.Concat("%",JobTitle,"%");
            var sql = "usp_GetEmployee";
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@JobTitle";
            param1.SqlDbType = System.Data.SqlDbType.NVarChar;
            param1.Value = JobTitle;

            List<Employee> listado = new List<Employee>();
            //cn.close manera explicita
            //SqlConnection cn;
            using (SqlConnection cn = new SqlConnection(strConnection))
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(param1);
                cn.Open();

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var emp = new Employee();
                    var indice = 0;
                    indice = reader.GetOrdinal("BusinessEntityID");
                    //no es optimo reader["BusinessEntityID"]
                    emp.BusinessEntityID = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("NationalIDNumber");
                    emp.NationalIDNumber = reader.GetString(indice);

                    //emp.NationalIDNumber=reader.GetString()
                    indice = reader.GetOrdinal("LoginID");
                    emp.LoginID = reader.GetString(indice);

                    indice = reader.GetOrdinal("JobTitle");
                    emp.JobTitle = reader.GetString(indice);

                    indice = reader.GetOrdinal("BirthDate");
                    emp.BirthDate = reader.IsDBNull(indice) ? new Nullable<DateTime>() : reader.GetDateTime(indice);

                    indice = reader.GetOrdinal("VacationHours");
                    emp.VacationHours = reader.GetInt16(indice);
                    listado.Add(emp);
                }

            }
            return listado;
        }


    }
}
