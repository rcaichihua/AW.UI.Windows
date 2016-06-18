using AW.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace AW.DataAccess
{
    public class EmployeeDA
    {
        //private string strConnection = "Data Source=(local);Initial Catalog=AdventureWorks2014;Integrated Security=true;";
        //public List<Employee> GetEmployees()
        //{
        //    var sql = "select BusinessEntityID,NationalIDNumber,LoginID,JobTitle,BirthDate,VacationHours from HumanResources.Employee with(nolock)";
        //    //var
        //    List<Employee> listado = new List<Employee>();
        //    //cn.close manera explicita
        //    //SqlConnection cn;
        //    using (SqlConnection cn = new SqlConnection(strConnection))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql,cn);
        //        cn.Open();

        //        var reader = cmd.ExecuteReader();
        //        while(reader.Read())
        //        {
        //            var emp = new Employee();
        //            var indice = 0;
        //            indice = reader.GetOrdinal("BusinessEntityID");
        //            //no es optimo reader["BusinessEntityID"]
        //            emp.BusinessEntityID = reader.GetInt32(indice);

        //            indice = reader.GetOrdinal("NationalIDNumber");
        //            emp.NationalIDNumber = reader.GetString(indice);

        //            //emp.NationalIDNumber=reader.GetString()
        //            indice = reader.GetOrdinal("LoginID");
        //            emp.LoginID = reader.GetString(indice);                 

        //            indice = reader.GetOrdinal("JobTitle");
        //            emp.JobTitle = reader.GetString(indice);

        //            indice = reader.GetOrdinal("BirthDate");
        //            emp.BirthDate = reader.IsDBNull(indice)? new Nullable<DateTime>() : reader.GetDateTime(indice);

        //            indice = reader.GetOrdinal("VacationHours");
        //            emp.VacationHours = reader.GetInt16(indice);
        //            listado.Add(emp);
        //        }

        //    }
        //    return listado;
        //}
        //public List<Employee> GetEmployeesWithParam(string JobTitle)
        //{
        //    //JobTitle = string.Concat("%",JobTitle,"%");
        //    var sql = "select BusinessEntityID,NationalIDNumber,LoginID,JobTitle,BirthDate,VacationHours " +
        //    "from HumanResources.Employee with(nolock) where JobTitle like '%'+ @JobTitle +'%'";
        //    SqlParameter param1 = new SqlParameter();
        //    param1.ParameterName = "@JobTitle";
        //    param1.SqlDbType = System.Data.SqlDbType.NVarChar;
        //    param1.Value = JobTitle;

        //    List <Employee> listado = new List<Employee>();
        //    //cn.close manera explicita
        //    //SqlConnection cn;
        //    using (SqlConnection cn = new SqlConnection(strConnection))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cmd.Parameters.Add(param1);
        //        cn.Open();

        //        var reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            var emp = new Employee();
        //            var indice = 0;
        //            indice = reader.GetOrdinal("BusinessEntityID");
        //            //no es optimo reader["BusinessEntityID"]
        //            emp.BusinessEntityID = reader.GetInt32(indice);

        //            indice = reader.GetOrdinal("NationalIDNumber");
        //            emp.NationalIDNumber = reader.GetString(indice);

        //            //emp.NationalIDNumber=reader.GetString()
        //            indice = reader.GetOrdinal("LoginID");
        //            emp.LoginID = reader.GetString(indice);

        //            indice = reader.GetOrdinal("JobTitle");
        //            emp.JobTitle = reader.GetString(indice);

        //            indice = reader.GetOrdinal("BirthDate");
        //            emp.BirthDate = reader.IsDBNull(indice) ? new Nullable<DateTime>() : reader.GetDateTime(indice);

        //            indice = reader.GetOrdinal("VacationHours");
        //            emp.VacationHours = reader.GetInt16(indice);
        //            listado.Add(emp);
        //        }

        //    }
        //    return listado;
        //}
        //public List<Employee> GetEmployeesWithParamSP(string JobTitle)
        //{
        //    //JobTitle = string.Concat("%",JobTitle,"%");
        //    var sql = "usp_GetEmployee";
        //    SqlParameter param1 = new SqlParameter();
        //    param1.ParameterName = "@JobTitle";
        //    param1.SqlDbType = System.Data.SqlDbType.NVarChar;
        //    param1.Value = JobTitle;

        //    List<Employee> listado = new List<Employee>();
        //    //cn.close manera explicita
        //    //SqlConnection cn;
        //    using (SqlConnection cn = new SqlConnection(strConnection))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql, cn);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //        cmd.Parameters.Add(param1);
        //        cn.Open();

        //        var reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            var emp = new Employee();
        //            var indice = 0;
        //            indice = reader.GetOrdinal("BusinessEntityID");
        //            //no es optimo reader["BusinessEntityID"]
        //            emp.BusinessEntityID = reader.GetInt32(indice);

        //            indice = reader.GetOrdinal("NationalIDNumber");
        //            emp.NationalIDNumber = reader.GetString(indice);

        //            //emp.NationalIDNumber=reader.GetString()
        //            indice = reader.GetOrdinal("LoginID");
        //            emp.LoginID = reader.GetString(indice);

        //            indice = reader.GetOrdinal("JobTitle");
        //            emp.JobTitle = reader.GetString(indice);

        //            indice = reader.GetOrdinal("BirthDate");
        //            emp.BirthDate = reader.IsDBNull(indice) ? new Nullable<DateTime>() : reader.GetDateTime(indice);

        //            indice = reader.GetOrdinal("VacationHours");
        //            emp.VacationHours = reader.GetInt16(indice);
        //            listado.Add(emp);
        //        }

        //    }
        //    return listado;
        //}

        //public int InsertEmployee(Employee empleado, Person person)
        //{
        //    var be = new BusinessEntities();
        //    be.rowguid = Guid.NewGuid();
        //    be.ModifiedDate = DateTime.Now;
        //    int businessEntityID = 0;

        //    using (SqlConnection cn = new SqlConnection(strConnection))
        //    {
        //        //configurando el comando
        //        //insert BUSINESS
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        else
        //        {
        //            cn.Open();
        //        }

        //        SqlCommand cmd = new SqlCommand("usp_InsertBusinessEntity", cn);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //        //cn.Open();
        //        SqlParameter param1 = new SqlParameter();
        //        param1.ParameterName = "@rowguid";
        //        param1.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
        //        param1.Direction = System.Data.ParameterDirection.Input;
        //        param1.Value = be.rowguid;
        //        cmd.Parameters.Add(param1);

        //        SqlParameter param2 = new SqlParameter();
        //        param2.ParameterName = "@ModifiedDate";
        //        param2.SqlDbType = System.Data.SqlDbType.DateTime;
        //        param2.Direction = System.Data.ParameterDirection.Input;
        //        param2.Value = be.ModifiedDate;
        //        cmd.Parameters.Add(param2);

        //        SqlParameter paramOut1 = new SqlParameter();
        //        paramOut1.ParameterName = "@BusinessEntityID";
        //        paramOut1.SqlDbType = System.Data.SqlDbType.Int;
        //        paramOut1.Direction = System.Data.ParameterDirection.Output;

        //        cmd.Parameters.Add(paramOut1);

        //        cmd.ExecuteNonQuery();
        //        //casteo a int
        //        businessEntityID = (int)paramOut1.Value;

        //        /*iNSERT PERSONA*/

        //        SqlCommand cmd2 = new SqlCommand("usp_InsertPerson", cn);
        //        cmd2.CommandType = CommandType.StoredProcedure;

        //        SqlParameter param21 = new SqlParameter();
        //        param21.ParameterName = "@BusinessEntityID";
        //        param21.SqlDbType = System.Data.SqlDbType.Int;
        //        param21.Direction = System.Data.ParameterDirection.Input;
        //        param21.Value = businessEntityID;
        //        cmd2.Parameters.Add(param21);


        //        SqlParameter param22 = new SqlParameter();
        //        param22.ParameterName = "@PersonType";
        //        param22.SqlDbType = System.Data.SqlDbType.NChar;
        //        param22.Direction = System.Data.ParameterDirection.Input;
        //        param22.Value = person.PersonType;
        //        cmd2.Parameters.Add(param22);

        //        SqlParameter param23 = new SqlParameter();
        //        param23.ParameterName = "@NameStyle";
        //        param23.SqlDbType = System.Data.SqlDbType.Bit;
        //        param23.Direction = System.Data.ParameterDirection.Input;
        //        param23.Value = person.NameStyle;
        //        cmd2.Parameters.Add(param23);

        //        SqlParameter param24 = new SqlParameter();
        //        param24.ParameterName = "@Title";
        //        param24.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param24.Direction = System.Data.ParameterDirection.Input;
        //        param24.Value = person.Title;
        //        cmd2.Parameters.Add(param24);

        //        SqlParameter param25 = new SqlParameter();
        //        param25.ParameterName = "@FirstName";
        //        param25.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param25.Direction = System.Data.ParameterDirection.Input;
        //        param25.Value = person.FirstName;
        //        cmd2.Parameters.Add(param25);

        //        SqlParameter param26 = new SqlParameter();
        //        param26.ParameterName = "@MiddleName";
        //        param26.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param26.Direction = System.Data.ParameterDirection.Input;
        //        param26.Value = person.MiddleName;
        //        cmd2.Parameters.Add(param26);


        //        SqlParameter param27 = new SqlParameter();
        //        param27.ParameterName = "@LastName";
        //        param27.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param27.Direction = System.Data.ParameterDirection.Input;
        //        param27.Value = person.LastName;
        //        cmd2.Parameters.Add(param27);


        //        SqlParameter param28 = new SqlParameter();
        //        param28.ParameterName = "@Suffix";
        //        param28.SqlDbType = System.Data.SqlDbType.NVarChar;
        //        param28.Direction = System.Data.ParameterDirection.Input;
        //        param28.Value = person.Suffix;
        //        cmd2.Parameters.Add(param28);

        //        SqlParameter param29 = new SqlParameter();
        //        param29.ParameterName = "@EmailPromotion";
        //        param29.SqlDbType = System.Data.SqlDbType.Int;
        //        param29.Direction = System.Data.ParameterDirection.Input;
        //        param29.Value = person.EmailPromotion;
        //        cmd2.Parameters.Add(param29);

        //        SqlParameter param210 = new SqlParameter();
        //        param210.ParameterName = "@rowguid";
        //        param210.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
        //        param210.Direction = System.Data.ParameterDirection.Input;
        //        param210.Value = person.rowguid;
        //        cmd2.Parameters.Add(param210);

        //        SqlParameter param211 = new SqlParameter();
        //        param211.ParameterName = "@ModifiedDate";
        //        param211.SqlDbType = System.Data.SqlDbType.DateTime;
        //        param211.Direction = System.Data.ParameterDirection.Input;
        //        param211.Value = person.ModifiedDate;
        //        cmd2.Parameters.Add(param211);

        //        cmd2.ExecuteNonQuery();
        //    }
        //    return businessEntityID;
       // }

    }
}
