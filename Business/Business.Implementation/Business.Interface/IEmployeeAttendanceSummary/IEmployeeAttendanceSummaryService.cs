﻿using Business.Entities.HR.ReportsHR;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Business.Interface.IEmployeeAttendanceSummary
{
    public interface IEmployeeAttendanceSummaryService
    {
        Task<int> ApproveSaveEmployeeSalaryAsync(EmployeeFinalSalaryCalculationModel employeeFinalSalaryCalculationModel, DataTable dataTable);
        public Task<DataSet> GetEmployeeAllAttendanceSummary(int employeeCategoryId = 0, int userId = 0, int month = 0, int year = 0, int departmentId = 0, string searchString = "");
        Task<DataSet> GetEmployeeAllDetailSummary(int employeecategoryId = 0, int departmentId = 0, string searchstring = null);
        Task<DataSet> GetEmployeeSalaryDetail(int year, int month, int companyId, int employeeId, int employeeCategoryId, int userId);
        Task<DataSet> GetEmployeeSalarySummary(int employeeCategoryId = 0, int userId = 0, int companyId = 0, int month = 0, int year = 0, int employeeId = 0);
        Task<DataTable> GetEmployeeSalarySummaryEdit(int employeeId, int year, int month, int companyId);
         
        Task<DataSet> GetVerifiedEmployeeSalarySummary(int employeeCategoryId = 0, int userId = 0, int companyId = 0, int month = 0, int year = 0, int employeeId = 0, int employementTypeId = 0, int departmentID = 0);
        Task<DataSet> ProcesSalary(int year, int month, int companyId, int employmentTypeId, int employeeCategoryId, int userId, DateTime salaryDate);
        Task<int> VerifyEmplyeeSalary(int year, int month, int companyId, int employeeId, int employeeCategoryId, int userId);
        //Task<DataSet> GetEmployeeSalarySummaryEdit(int employeeId = 0);
    }
}
