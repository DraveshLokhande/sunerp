﻿using Business.Entities;
using Business.Entities.Employee;
using Business.Entities.EmployeeAttendanceSummary;
using Business.Entities.HR.UserMapToEmployeeModel;
using Business.Interface;
using Business.SQL;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;

namespace Business.Service
{
    public class SiteUserRepository : ISiteUserService
    {
        private IConfiguration _config { get; set; }
        private string connection = string.Empty;
        public SiteUserRepository(IConfiguration config)
        {
            _config = config;
            connection = _config.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Retrieve all users from the database
        /// </summary>
        /// <returns>List of Users (SiteUser)</returns>
        public PagedDataTable<UserMasterMetadata> GetAllUser(int companyID, int pageNo = 1, int pageSize = 0, string orderBy = "UserID", string sortBy = "ASC", string searchString = "")
        {
            DataTable table = new DataTable();
            int totalItemCount = 0;
            try
            {
                SqlParameter[] param = {new SqlParameter("@CompanyID",companyID)
                        ,new SqlParameter("@PageNo",pageNo)
                        ,new SqlParameter("@PageSize",pageSize)
                        ,new SqlParameter("@SearchString",searchString)
                        ,new SqlParameter("@OrderBy",orderBy)
                        ,new SqlParameter("@SortBy",sortBy=="ASC"?0:1)
                        };

                using (DataSet ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "Usp_GetAll_UserMaster", param))
                {
                    if (ds.Tables.Count > 0)
                    {
                        table = ds.Tables[0];
                        if (table.Rows.Count > 0)
                        {
                            if (table.ContainColumn("TotalCount"))
                                totalItemCount = Convert.ToInt32(table.Rows[0]["TotalCount"]);
                            else
                                totalItemCount = table.Rows.Count;
                        }
                    }
                    PagedDataTable<UserMasterMetadata> lst = table.ToPagedDataTableList<UserMasterMetadata>
                        (pageNo, pageSize, totalItemCount, searchString, orderBy, sortBy);
                    return lst;
                }
            }
            catch 
            {
                throw ;
            }
            finally
            {
                if (table != null)
                    table.Dispose();
            }
        }

        /// <summary>
        /// Create new SiteUser
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Success or Fail</returns>
        public async Task<int> CreateUser(UserMasterMetadata user, CancellationToken cancellationToken)
        {
            try
            {
                SqlParameter[] param = {
                 new SqlParameter("@CompanyID", user.CompanyID)
                ,new SqlParameter("@Username", user.Username)
                ,new SqlParameter("@NormalizedUserName", user.NormalizedUserName)
                ,new SqlParameter("@Forename", user.Forename ?? "")
                ,new SqlParameter("@Surname", user.Surname ?? "")
                ,new SqlParameter("@Email", user.Email)
                ,new SqlParameter("@NormalizedEmail", user.NormalizedEmail)
                ,new SqlParameter("@EmailConfirmed", user.EmailConfirmed)
                ,new SqlParameter("@PasswordHash", user.PasswordHash ?? "")
                ,new SqlParameter("@PhoneNumber", user.PhoneNumber ?? "")
                ,new SqlParameter("@PhoneNumberConfirmed", user.PhoneNumberConfirmed)
                ,new SqlParameter("@TwoFactorEnabled", user.TwoFactorEnabled)
                ,new SqlParameter("@Created", DateTime.Now)
                };

                var obj = await SqlHelper.ExecuteScalarAsync(connection, CommandType.StoredProcedure, "Usp_IU_UserMaster", param);

                return obj != null ? Convert.ToInt32(obj) : 0;

            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// Update Existing User Details
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> UpdateUser(UserMasterMetadata user, CancellationToken cancellationToken)
        {
            try
            {
                SqlParameter[] param = {
                 new SqlParameter("@UserID", user.UserID)
                ,new SqlParameter("@Username", user.Username)
                ,new SqlParameter("@NormalizedUserName", user.NormalizedUserName)
                ,new SqlParameter("@Forename", user.Forename ?? "")
                ,new SqlParameter("@Surname", user.Surname ?? "")
                ,new SqlParameter("@Email", user.Email)
                ,new SqlParameter("@NormalizedEmail", user.NormalizedEmail)
                ,new SqlParameter("@EmailConfirmed", user.EmailConfirmed)
                ,new SqlParameter("@PasswordHash", user.PasswordHash ?? "")
                ,new SqlParameter("@PhoneNumber", user.PhoneNumber ?? "")
                ,new SqlParameter("@PhoneNumberConfirmed", user.PhoneNumberConfirmed)
                ,new SqlParameter("@TwoFactorEnabled", user.TwoFactorEnabled)
                ,new SqlParameter("@IsActive", user.IsActive)
                };

                await SqlHelper.ExecuteScalarAsync(connection, CommandType.StoredProcedure, "Usp_U_UserMaster", param);

                return IdentityResult.Success;

            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError { Code = ex.HResult.ToString(), Description = ex.Message });
            }

        }

        /// <summary>
        /// Find user by provided ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>SiteUser</returns>
        public async Task<UserMasterMetadata> FindById(string userId, CancellationToken cancellationToken)
        {

            var user = new UserMasterMetadata();

            try
            {
                SqlParameter[] param = { new SqlParameter("@UserID", userId) };
                DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_UserMaster", param);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            user = dr.ToPagedDataTableList<UserMasterMetadata>();
                        }
                    }
                }
                return user;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Find user by provided Normalized Email
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>SiteUser</returns>
        public async Task<UserMasterMetadata> FindByEmail(string normalizedEmail, CancellationToken cancellationToken)
        {
            try
            {
                UserMasterMetadata user = null;

                try
                {
                    SqlParameter[] param = { new SqlParameter("@UserEmail", normalizedEmail) };
                    DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_UserMaster_ByEmail", param);
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow dr = ds.Tables[0].Rows[0];
                                user = dr.ToPagedDataTableList<UserMasterMetadata>();
                            }
                        }
                    }
                    return user;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Adds a user by ID to role by ID
        /// Checks should be performed to ensure role exists before removing user
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> AddUserToRoleAsync(int UserId, int RoleId, CancellationToken cancellationToken)
        {
            try
            {
                SqlParameter[] param = {new SqlParameter("@RoleId", RoleId),
                    new SqlParameter("@UserId", UserId)
                };

                await SqlHelper.ExecuteScalarAsync(connection, CommandType.StoredProcedure, "Usp_I_UserToRole", param);

                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError { Code = ex.HResult.ToString(), Description = ex.Message });
            }
        }

        /// <summary>
        /// Remove user from specified role
        /// Ensure role exists before removal
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IdentityResult> RemoveUserFromRole(int UserId, int RoleId, CancellationToken cancellationToken)
        {
            try
            {
                SqlParameter[] param = {new SqlParameter("@RoleId", RoleId),
                    new SqlParameter("@UserId", UserId)
                };

                await SqlHelper.ExecuteNonQueryAsync(connection, CommandType.StoredProcedure, "Usp_Delete_UserToRole", param);
                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError { Code = ex.HResult.ToString(), Description = ex.Message });
            }
        }

        /// <summary>
        /// Check if user is in the supplied role
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> IsUserInRoleAsync(int UserId, int RoleId)
        {
            try
            {
                SqlParameter[] param = {new SqlParameter("@RoleId", RoleId),
                    new SqlParameter("@UserId", UserId)
                };
                var value = await SqlHelper.ExecuteScalarAsync(connection, CommandType.StoredProcedure, "Usp_Get_IsUserInRole", param);
                var cnt = Convert.ToInt32(value);

                if (cnt > 0)
                {
                    // Yes, in that role
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Find user by provided Normalized Username
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>SiteUser</returns>
        public async Task<UserMasterMetadata> FindByName(string normalizedUserName, CancellationToken cancellationToken)
        {
            try
            {
                UserMasterMetadata user = null;

                try
                {
                    SqlParameter[] param = { new SqlParameter("@NormalizedUserName", normalizedUserName) };
                    DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "usp_Get_UserMaster_Name", param);
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow dr = ds.Tables[0].Rows[0];
                                user = dr.ToPagedDataTableList<UserMasterMetadata>();
                            }
                        }
                    }
                    return user;
                }
                catch 
                {

                    throw ;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PagedDataTable<UserClaimsMetadata> GetAllUserClaimAuth(int companyID, int userID)
        {
            DataTable table = new DataTable();
            int totalItemCount = 0;
            try
            {
                SqlParameter[] param = {new SqlParameter("@CompanyID",companyID)
                        ,new SqlParameter("@UserID",userID)
                        
                        };

                using (DataSet ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "usp_GetAll_UserClaim_Auth", param))
                {
                    if (ds.Tables.Count > 0)
                    {
                        table = ds.Tables[0];
                        if (table.Rows.Count > 0)
                        {
                            if (table.ContainColumn("TotalCount"))
                                totalItemCount = Convert.ToInt32(table.Rows[0]["TotalCount"]);
                            else
                                totalItemCount = table.Rows.Count;
                        }
                    }
                    PagedDataTable<UserClaimsMetadata> lst = table.ToPagedDataTableList<UserClaimsMetadata>();
                    return lst;
                }
            }
            catch 
            {
                throw ;
            }
            finally
            {
                if (table != null)
                    table.Dispose();
            }
        }

        #region User List For Dropdown
        public async Task<PagedDataTable<UserMasterMetadata>> GetAllUsersForDropDown()
        {
            DataTable table = new DataTable();
            int totalItemCount = 0;
            try
            {
                //SqlParameter[] param = {
                //        new SqlParameter("@PageNo",pageNo)
                //        ,new SqlParameter("@PageSize",pageSize)
                //        ,new SqlParameter("@SearchString",searchString)
                //        ,new SqlParameter("@OrderBy",orderBy)
                //        ,new SqlParameter("@SortBy",sortBy=="ASC"?0:1)
                //        };

                using (DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_GetAll_UserMasterForDropDown"))
                {
                    if (ds.Tables.Count > 0)
                    {
                        table = ds.Tables[0];
                        if (table.Rows.Count > 0)
                        {
                            if (table.ContainColumn("TotalCount"))
                                totalItemCount = Convert.ToInt32(table.Rows[0]["TotalCount"]);
                            else
                                totalItemCount = table.Rows.Count;
                        }
                    }
                    PagedDataTable<UserMasterMetadata> lst = table.ToPagedDataTableList<UserMasterMetadata>
                        (1, 10, totalItemCount, "", "", "");
                    return lst;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (table != null)
                    table.Dispose();
            }
        }

        #endregion User List For Dropdown

        #region Login User Department Name

        public async Task<string> LoginUserGetDepartmentName(int userID) {
            try
            {
                string departmentName = string.Empty;
                SqlParameter[] param = { new SqlParameter("@UserID", userID) };
                DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_LoginUserDepartment", param);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            var userMapToEmployee = dr.ToPagedDataTableList<UserMapToEmployee>();
                            departmentName = userMapToEmployee.DepartmentName;
                        }
                    }
                }
                return departmentName;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion Login User Department Name
        #region Login User Designation Name
        public async Task<string> LoginUserGetDesignationName(int userID)
        {
            try
            {
                string designationName = string.Empty;
                SqlParameter[] param = { new SqlParameter("@UserID", userID) };
                DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_LoginUserDepartment", param);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            var userMapToEmployee = dr.ToPagedDataTableList<UserMapToEmployee>();
                            designationName = userMapToEmployee.DesignationName;
                        }
                    }
                }
                return designationName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion Login User Designation Name

        #region Login User Type Name, E.g. Admin,HR,HOD and etc.
        public async Task<string> LoginUserTypeName(int userID)
        {
            try
            {
                string userTypeName = string.Empty;
                SqlParameter[] param = { new SqlParameter("@UserID", userID) };
                DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_LoginUserTypeName", param);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            var userMapToEmployee = dr.ToPagedDataTableList<UserMapToEmployee>();
                            userTypeName = userMapToEmployee.UserType;
                        }
                    }
                }
                return userTypeName;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion Login User Type Name, E.g. Admin,HR,HOD and etc.

        #region Get User Detail Async        
        public async Task<RegisterViewModel> GetUserDetailAsync(int UserID) 
        { RegisterViewModel result = null;
            try { 
                SqlParameter[] param = { new SqlParameter("@UserID", UserID) }; DataSet ds = await SqlHelper.ExecuteDatasetAsync(connection, CommandType.StoredProcedure, "Usp_Get_UserMaster", param); if (ds != null) { if (ds.Tables.Count > 0) { if (ds.Tables[0].Rows.Count > 0) { DataRow dr = ds.Tables[0].Rows[0]; result = dr.ToPagedDataTableList<RegisterViewModel>(); } } } return result; } catch (Exception ex) { throw ex; }
        }

        #endregion Get User Detail Async

        #region Save User Login history
        public async Task<string> LoginUserHistory(int userid, string emailId, string inTime, string outTime, string location, string latitude, string longitude, string DeviceIP, string BrowserName)
        {

            try
            {
                inTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                string userTypeName = string.Empty;
                SqlParameter[] param = {
                new SqlParameter("@UserID", userid),
                new SqlParameter("@EmailID", emailId) ,
                new SqlParameter("@InTime", inTime),
                //new SqlParameter("@OutTime", !string.IsNullOrEmpty(outTime) ? Convert.ToDecimal(outTime) : string.Empty) ,
                new SqlParameter("@Location", location) ,
                new SqlParameter("@Latitude", !string.IsNullOrEmpty(latitude) ? Convert.ToDecimal(latitude) : "0") ,
                new SqlParameter("@longitude", !string.IsNullOrEmpty(longitude) ? Convert.ToDecimal(longitude) : "0"),
                new SqlParameter("@DeviceIP", DeviceIP),
                new SqlParameter("@BrowserName", BrowserName),
                };

                var obj = await SqlHelper.ExecuteScalarAsync(connection, CommandType.StoredProcedure, "Usp_IU_UserLogin", param);

                return obj != null ? Convert.ToString(obj) : "0";

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion Save User Login history

    }
}
