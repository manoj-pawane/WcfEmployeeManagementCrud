﻿using Common.Contracts;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EmployeeMgtApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Update/{EmpId}")]
        string UpdateEmployee(EmployeeContract employeeContract, string empId);

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllEmployee/")]
        IList<EmployeeContract> GetAllEmployee();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/Add/")]
        string AddEmployee(EmployeeContract employeeContract);

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/get/{EmpId}")]
        EmployeeContract GetById(string EmpId);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/delete/{EmpId}")]
        string DeleteEmployee(string EmpId);
    }
}
