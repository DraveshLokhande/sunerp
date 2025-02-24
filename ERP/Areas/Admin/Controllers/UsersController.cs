﻿using Business.Entities;
using Business.Entities.Master.MarketingCompanyFinancialYearMaster;
using Business.Interface;
using Business.Interface.IMaster.IMarketingCompanyFinanicalYearMaster;
using Business.SQL;
using DocumentFormat.OpenXml.Office2010.Excel;
using ERP.Controllers;
using GridCore.Server;
using GridShared;
using GridShared.Sorting;
using Kinfo.JsonStore.Builder;
using Kinfo.JsonStore.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    [DisplayName("Users")]
    public class UsersController : SettingsController
    {
        #region "Variable and Properties"
        private readonly UserManager<UserMasterMetadata> _userManager;
        private readonly SignInManager<UserMasterMetadata> _signInManager;
        private readonly ISiteUserService _usersService;
        private readonly ISiteRoleRepository _roleService;
        public UsersController(ISiteRoleRepository roleService, ISiteUserService users, UserManager<UserMasterMetadata> userManager, SignInManager<UserMasterMetadata> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._usersService = users;
            this._roleService = roleService;
        }
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
        #endregion

        #region "User Get All"
        [DisplayName("View All")]
        public ActionResult Index([FromQuery(Name = "grid-page")] string gridpage = "1", [FromQuery(Name = "grid-column")] string orderby = "", [FromQuery(Name = "grid-dir")] string sortby = "0", [FromQuery(Name = "grid-filter")] string gridfilter = "", [FromQuery(Name = "grid-search")] string search = "")
        {
            int userid = USERID;
            IQueryCollection query = Request.Query;

            Action<IGridColumnCollection<UserMasterMetadata>> columns = c =>
            {
                c.Add(o => o.Forename)
                    .Titled("Name")
                    .SortInitialDirection(GridSortDirection.Ascending)
                    .SetWidth(250)
                    .Encoded(false)
                    .Sanitized(false)
                    .Sortable(true)
                    .RenderValueAs(o => $"<a class='btn' href='Users/Edit/{o.UserID}' >{string.Format("{0} {1}", o.Forename, o.Surname)}</a>");


                c.Add(o => o.Email)
                    .Titled("Email")
                    .SetWidth(250).Sortable(true)
                    .Filterable(true);

                c.Add(o => o.IsActive)
                 .RenderValueAs(o => $"{o.IsActive.ToActiveOrDeactive()}")
                   .Titled("Status")
                   .SetWidth(250)
                    .Filterable(true);

                c.Add()
                  .Titled("Edit")
                  .Encoded(false)
                  .Sanitized(false)
                  .SetWidth(60).Sortable(false)
                  //.Css("hidden-xs") //hide on phones
                  //.RenderValueAs(o => $"<a class='btn' href='Users/Edit/{o.UserID}' ><i class='bx bx-edit'></i></a> <a class='btn'href='Users/ManageRole/{o.UserID}' ><i class='bx bx-lock'></i></a>");
                  .RenderValueAs(o => $"<a class='btn' href='Users/Edit/{o.UserID}' ><i class='bx bx-edit'></i></a>");

                c.Add()
                    .Titled("Edit")
                    .Encoded(false)
                    .Sanitized(false)
                    .SetWidth(60)
                    .Css("hidden-xs")
                    .RenderValueAs(o => $"<a class='btn IndexPagebtnEidtPadding' onclick='fnManageUser(this)' href='javascript:void(0)' data-id='{o.UserID}' data-bs-toggle='offcanvas' data-bs-target='#canvas_ManageUser' aria-controls='canvas_ManageUser'><i class='bx bx-edit'></a>");
                //"<a class='btn btn-primary px-5' onclick='fnManageUser(this)' href='javascript:void(0)' data-key='{o.UserID}' data-bs-toggle='offcanvas' data-bs-target='#canvas_ManageUser' aria-controls='canvas_ManageUser'><i class='bx bx-edit'></a>"
            };
            PagedDataTable<UserMasterMetadata> pds = (PagedDataTable<UserMasterMetadata>)_usersService.GetAllUser(COMPANYID, gridpage.ToInt(), PAGESIZE, orderby, sortby == "0" ? "ASC" : "DESC", search);
            var server = new GridCoreServer<UserMasterMetadata>(pds, query, false, "Users",
                columns, PAGESIZE, pds.TotalItemCount)
                .Sortable()
                .Filterable(false)
                .Searchable(false, false)
                .WithGridItemsCount()
                .WithPaging(PAGESIZE, pds.TotalItemCount, PAGESIZE, "grid-page")
                .EmptyText("No record found")
                ;
            return View(server.Grid);
        }
        #endregion

        #region "User Edit and Create"
        [DisplayName("User Create")]
        public IActionResult Create()
        {
            return View("Create", new RegisterViewModel());
        }


        [HttpPost]
        public PartialViewResult Get(int id)
        {
            try
            {
                RegisterViewModel model = new RegisterViewModel();

                if (id > 0)
                {
                    //string Id = id.ToString();
                    //model = _userManager.FindByIdAsync(Id).Result;
                    // model = _iMarketingCompanyFinancialYear.GetFinancialYearAsync(id).Result;
                    model = _usersService.GetUserDetailAsync(id).Result;
                    return PartialView("Create", model);
                }
                else
                {
                    return PartialView("Create", model);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            var userCheck = await _userManager.FindByEmailAsync(model.Email);
            if (userCheck == null)
            {
                var user = new UserMasterMetadata
                {
                    Forename = model.FirstName,
                    Surname = model.LastName,
                    Username = model.Email,
                    NormalizedUserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.Mobile,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    CompanyID = COMPANYID == 0 ? 1 : COMPANYID,
                    IsActive = model.IsActive

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    RoleMasterMetadata roleitem = _roleService.FindByIdAsync(model.RoleID.ToString()).Result;
                    if (roleitem != null)
                    {
                        await _userManager.AddToRoleAsync(user, roleitem.Name);
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    if (result.Errors.Count() > 0)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("message", error.Description);
                        }
                    }
                    return View(model);
                }
            }
            else
            {
                bool isValid = false;
                try
                {
                    if (userCheck.UserID == model.UserID)
                    {
                        isValid = true;
                    }
                    if (isValid)
                    {
                        var user = new UserMasterMetadata
                        {
                            Forename = model.FirstName,
                            Surname = model.LastName,
                            Username = model.Email,
                            NormalizedUserName = model.Email,
                            Email = model.Email,
                            PhoneNumber = model.Mobile,
                            EmailConfirmed = true,
                            PhoneNumberConfirmed = true,
                            CompanyID = COMPANYID,
                            IsActive = model.IsActive,
                            UserID = model.UserID,
                            //PasswordHash = model.Password,
                            RoleID = model.RoleID

                        };
                        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                        //var result = await _userManager.ChangePasswordAsync(user,model.Password,model.Password);
                        var result = await _userManager.UpdateAsync(user);
                        //var result = await _userManager.ValidatePasswordAsync(user, model.PasswordHash);
                        if (result.Succeeded)
                        {
                            //RoleMasterMetadata roleitem = _roleService.FindByIdAsync(model.RoleID.ToString()).Result;
                            //if (roleitem != null)
                            //{
                            //    await _userManager.AddToRoleAsync(user, roleitem.Name);
                            //}
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch
                {
                    throw;
                }

            }
            return RedirectToAction("Index");
            //return View(model);
        }

        [DisplayName("User Edit")]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                UserMasterMetadata user = await _userManager.FindByIdAsync(id);
                RegisterViewModel model = new RegisterViewModel();
                model.FirstName = user.Forename;
                model.LastName = user.Surname;
                model.Email = user.Email;
                model.Mobile = user.PhoneNumber;
                model.IsActive = user.IsActive;
                model.UserID = user.UserID;
                return View("Edit", model);
            }
            catch
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RegisterViewModel model)
        {
            bool isValid = false;
            try
            {
                var userCheck = await _userManager.FindByEmailAsync(model.Email);
                if (userCheck != null)
                {
                    if (userCheck.UserID == model.UserID)
                    {
                        isValid = true;
                    }
                }
                if (isValid)
                {
                    var user = new UserMasterMetadata
                    {
                        Forename = model.FirstName,
                        Surname = model.LastName,
                        Username = model.Email,
                        NormalizedUserName = model.Email,
                        Email = model.Email,
                        PhoneNumber = model.Mobile,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        CompanyID = COMPANYID,
                        IsActive = model.IsActive,
                        UserID = model.UserID
                    };
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        //RoleMasterMetadata roleitem = _roleService.FindByIdAsync(model.RoleID.ToString()).Result;
                        //if (roleitem != null)
                        //{
                        //    await _userManager.AddToRoleAsync(user, roleitem.Name);
                        //}
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        if (result.Errors.Count() > 0)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("message", error.Description);
                            }
                        }
                        return View(model);
                    }
                }
                return View(model);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region "Manage Roles"
        [DisplayName("Manage User Role")]
        public async Task<IActionResult> ManageRole(string id)
        {
            try
            {
                UserRolesMetadata userRole = new UserRolesMetadata();
                userRole.UserID = id.ToInt();
                UserMasterMetadata user = await _userManager.FindByIdAsync(id);
                var selectedRoles = await _userManager.GetRolesAsync(user);
                PagedDataTable<RoleMasterMetadata> roleList = await _roleService.GetAllRolesAsync(COMPANYID);
                foreach (var actions in roleList)
                {
                    if (selectedRoles.Any(a => a.Contains(actions.Name)))
                    {
                        actions.IsSelectedRole = true;
                    }
                    else
                    {
                        actions.IsSelectedRole = false;
                    }
                }
                userRole.SelectedRole = roleList;
                return View("ManageRole", userRole);
            }
            catch
            {
                throw;
            }
        }
        [DisplayName("Update User Role")]
        public async Task<IActionResult> UpdateRole(UserRolesMetadata model)
        {
            try
            {
                var Roles = model.SelectedRole;
                UserMasterMetadata user = await _userManager.FindByIdAsync(model.UserID.ToString());
                foreach (var rol in Roles)
                {
                    if (rol.IsSelectedRole)
                    {
                        RoleMasterMetadata roleitem = _roleService.FindByIdAsync(rol.RoleID.ToString()).Result;
                        if (roleitem != null)
                        {
                            await _userManager.AddToRoleAsync(user, roleitem.Name);
                        }
                    }
                    else
                    {
                        await _userManager.RemoveFromRoleAsync(user, rol.Name);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region "Change Password"
        [CustomAuthorize(FilterConstraint.Ignore)]
        public IActionResult ChangePassword()
        {
            return View("Create", new RegisterViewModel());
        }
        #endregion
    }
}

