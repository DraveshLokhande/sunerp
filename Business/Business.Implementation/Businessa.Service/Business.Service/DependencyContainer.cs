using Business.Entities;
using Business.Interface;
using Business.Interface.Dynamic;
using Business.Interface.Marketing;
using Business.Service.Dynamic;
using Business.Service.Marketing;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Business.Interface.IPartyTypeService;
using Business.Interface.Department;
using Business.Service.Department;
using Business.Interface.Designation;
using Business.Service.Designation;
using Business.Interface.ProductImages;
using Business.Interface.Marketing.CommunicatonLog;
using Business.Service.Marketing.CommunicationLogService;
using Business.Interface.Marketing.IVisitingDetailService;
using Business.Service.Marketing.VisitingDetailService;
using Business.Interface.Marketing.IMeeting;
using Business.Service.Marketing.Meeting;
using Business.Service.Marketing.CompanySales;
using Business.Interface.Marketing.ICompanyTarget;
using Business.Service.Master.MarketingCompanyFinanicalYearMaster;
using Business.Interface.IMaster.IMarketingCompanyFinanicalYearMaster;
using Business.Service.Marketing.SalesTarget;
using Business.Interface.Marketing.ISalesTarger;
using Business.Interface.Marketing.IEmployeeSalesTargetSummary;
using Business.Service.Marketing.EmployeeSalesTargetSummary;
using Business.Interface.Marketing.IPackage;
using Business.Service.Master.PackageService;
using Business.Interface.IEmployee;
using Business.Interface.IFormMaster;
using Business.Interface.ICustomer;
using Business.Service.Customer;
using Business.Interface.IOurProduct;
using Business.Interface.IMachineryService;
using Business.Service.MachineryService;
using Business.Interface.IMachineryMasterService;
using Business.Service.MachineryMService;
using Business.Interface.IMaster.IEmployeeCategory;
using Business.Interface.IMaster.IEmployementType;
using Business.Service.Master.EmployeeCategoryService;
using Business.Service.Master.EmployementTypeService;
using Business.Interface.ILeaveMaster;
using Business.Interface.ISalaryFormula;
using Business.Service.LeaveMaster;
using Business.Interface.IContractor;
using Business.Service.Contractor;
using Business.Service.HR;
using Business.Interface.HR;
using Business.Interface.CanteenCharges;
using Business.Interface.IEmployeeAttendanceSummary;
using Business.Interface.ILoanAdvanceService;
using Business.Interface.IWagesConfig;
using Business.Service.EmployeeAttendanceSummary;
using Business.Interface.IPositiveNoteService;
using Business.Service.SPositiveNote;
using Business.Interface.IGatePassService;
using Business.Service.GatePass;
using Business.Interface.IWorkingDaysService;
using Business.Service.SWorkingDays;
using Business.Interface.IOtherDeductionService;
using Business.Service.SOtherDeduction;
using Business.Service.DevelopmentArea.DynamicFormService;
using Business.Interface.DevelopmentArea.IDynamicFormService;
using Business.Interface.NotificationStatusI;
using Business.Service.NotificationStatusS;
using Business.Service.Party;
using Business.Interface.IParty;
using Business.Interface.IUserMapToEmployeeService;
using Business.Service.SHR.UserMapToEmployee;
using Business.Interface.IUserActivityLogService;
using Business.Service.SAdmin.UserActivityLog;
using Business.Interface.Marketing.IConversationActivities;
using Business.Service.Marketing.ConversationActivitiesService;
using Business.Interface.Marketing.IPartiesListbyNote;
using Business.Service.Marketing.SPartiesListbyNote;
using Business.Interface.Marketing.ISAPItemCollection;
using Business.Service.Marketing.SSAPItemCollection;
using Business.Interface.IEndUserTypeMasterService;
using Business.Service.SAdmin.EndUserTypeMaster;
using Business.Interface.IIconMasterService;
using Business.Service.SAdmin.IconMaster;
using Business.Interface.IMaster.UserPermissionInterface;
using Business.Service.Master.SUserPermission;
using Business.Interface.IProductCategoryMasterService;
using Business.Service.SAdmin.ProductCategoryMaster;
using Business.Interface.IEmployeeChildrenService;
using Business.Service.SHR.EmployeeChildren;
using Business.Service.SActivityOnMap;
using Business.Interface.IActivityOnMap;


using Business.Interface.HR.ITestHTMLForm2;
using Business.Service.HR.STestHTMLForm2;
using Business.Interface.HR.IEmployeeFacility;
using Business.Service.HR.SEmployeeFacility;
using Business.Interface.HR.IExpenseTypeMaster;
using Business.Service.HR.SExpenseTypeMaster;
using Business.Interface.HR.IExpensesTxn;
using Business.Service.HR.SExpensesTxn;
using Business.Interface.Production.IMachineOperatingStatus;
using Business.Service.Production.SMachineOperatingStatus;
using Business.Interface.Production.IMachinery;
using Business.Service.Production.SMachinery;
using Business.Interface.Production.IDepreciationMethod;
using Business.Service.Production.SDepreciationMethod;
using Business.Interface.Production.IShiftMaster;
using Business.Service.Production.SShiftMaster;
using Business.Interface.Production.IMachineryPurchaseDetail;
using Business.Service.Production.SMachineryPurchaseDetail;
using Business.Interface.Production.IMachinerySalesDetail;
using Business.Service.Production.SMachinerySalesDetail;
using Business.Interface.Production.IMachineCategoryMaster;
using Business.Service.Production.SMachineCategoryMaster;
using Business.Interface.Production.IMachineryEquippedDetail;
using Business.Service.Production.SMachineryEquippedDetail;
using Business.Interface.Production.IMachineryMaintenanceTxn;
using Business.Service.Production.SMachineryMaintenanceTxn;
using Business.Interface.Production.IMachineryDepreciationTxn;
using Business.Service.Production.SMachineryDepreciationTxn;
using Business.Interface.Production.IMachineryShutDownTxn;
using Business.Service.Production.SMachineryShutDownTxn;
using Business.Interface.Production.IUtilityMaster;
using Business.Service.Production.SUtilityMaster;
using Business.Interface.Production.IMachineryOperationDetail;
using Business.Service.Production.SMachineryOperationDetail;
using Business.Interface.Production.IMachineryDailyMISEntry;
using Business.Service.Production.SMachineryDailyMISEntry;
using Business.Interface.DevelopmentArea.IReportMaster;
using Business.Interface.DevelopmentArea.IReportParametersTxn;
using Business.Interface.DevelopmentArea.IFormReportTxn;
using Business.Service.DevelopmentArea.SReportMaster;
using Business.Service.DevelopmentArea.SReportParametersTxn;
using Business.Service.DevelopmentArea.SFormReportTxn;
using Business.Interface.Marketing.IDashboard;
using Business.Service.Marketing.SDashboard;
using Business.Interface.SalesDistribution.ISalesOrderMaster;
using Business.Service.SalesDistribution.SSalesOrderMaster;
using Business.Interface.HR.ISalaryFormulaTypeMaster;
using Business.Service.HR.SSalaryFormulaTypeMaster;
using Business.Interface.DevelopmentArea.IFormDatabaseTable;
using Business.Service.DevelopmentArea.SFormDatabaseTable;
using Business.Interface.HR.IMachineryResourceAllocation;
using Business.Service.HR.SMachineryResourceAllocation;
using Business.Interface.Production.IItemQRCodeDetail;
using Business.Service.Production.SItemQRCodeDetail;
using Business.Interface.HR.IMachineResourceSummary;
using Business.Service.HR.SMachineResourceSummary;
using Business.Interface.SalesDistribution.IOpportunityLossMaster;
using Business.Service.SalesDistribution.SOpportunityLossMaster;

using Business.Interface.Production.IMasterPacking;
using Business.Service.Production.SMasterPacking;
using Business.Interface.Marketing.IRequestForQuotMaster;
using Business.Service.Marketing.SRequestForQuotMaster;
using Business.Interface.Marketing.IQuotationMaster;
using Business.Service.Marketing.SQuotationMaster;
using Business.Interface.Marketing.IOfferAcceptedMaster;
using Business.Service.Marketing.SOfferAcceptedMaster;
using Business.Interface.Marketing.IPurchaseOrderMaster;
using Business.Service.Marketing.SPurchaseOrderMaster;
using Business.Interface.Marketing.IRequestForQuotTypeMaster;
using Business.Service.Marketing.SRequestForQuotTypeMaster;
 //$UsingInterFace$;
 //$UsingService$;

namespace Business.Service
{
    public static class DependencyContainer
    {
        /// <summary>
        /// Connects our interfaces and their implementations from multiple projects 
        /// into single point of reference. That is the purpose of IoC layer.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterServices(IServiceCollection services)
        {
            // Register Repo


            services.AddScoped<IMasterService, MasterService>();
            services.AddScoped<ISiteUserService, SiteUserRepository>();
            services.AddScoped<ISiteRoleRepository, SiteRoleRepository>();
            services.AddTransient<IUserStore<UserMasterMetadata>, UserStore>();
            services.AddTransient<IRoleStore<RoleMasterMetadata>, RoleStore>();
            services.AddTransient<ISiteCompanyRepository, CompanyService>();
            services.AddTransient<ISuperAdminService, SuperAdminService>();
            services.AddTransient<IVisitorService, VisitorService>();
            services.AddTransient<IViewRenderService, ViewRenderService>();
            services.AddTransient<IMasterEntity, MasterEntity>();
            services.AddTransient<IRequestTypeControl, RequestTypeControlService>();
            services.AddTransient<IRequestTypeModule, RequestTypeModuleService>();
            services.AddTransient<IRequestTypeControlScreenMapping, RequestTypeControlScreenMappingService>();
            services.AddTransient<IRequestType, RequestTypeService>();
            services.AddTransient<IRequestService, RequestService>();
            services.AddTransient<IEntity, EntityService>();
            services.AddTransient<IMarketingFeedbackService, MarketingFeedbackService>();
            services.AddTransient<IPartyTypeService, PartyTypeService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IDepartmentGroupService, DepartmentGroupService>();
            services.AddTransient<IDesignationService, DesignationService>();
            services.AddTransient<IDesignationGroupService, DesignationGroupService>();
            services.AddTransient<IProductImages, Business.Service.ProductImages.ProductImages>();
            services.AddTransient<IMarketingCommunicationLogService, MarketingCommunicationLogService>();
            services.AddTransient<IMarketingVisitingDetailService, MarketingVisitingDetailService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ISecurityOfficerService, SecurityOfficerService>();
            services.AddTransient<IMarketingMeeting, MarketinggMeetingService>();
            services.AddTransient<IMarketingCompanyTargetService, MarketingCompanyTargetService>();
            services.AddTransient<IMarketingCompanyFinancialYear, MarketingCompanyFinancialYearService>();
            services.AddTransient<IMarketingSalesTargetService, MarketingSalesTargetService>();
            services.AddTransient<IEmployeeSalesTargetSummaryService, EmployeeSalesTargetSummaryService>();
            services.AddTransient<IPackageService, PackageService>();
            services.AddTransient<IFormMasterService, Business.Service.FormMasterService.FormMasterService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IOurProductService, Business.Service.OurProductService.OurProductService>();
            services.AddTransient<IMachineryMaintainanceService, MachineryMaintainanceService>();
            services.AddTransient<IMachineryMasterService, MachineryMasterService>();
            services.AddTransient<IEmployeeCategoryService, EmployeeCategoryService>();
            services.AddTransient<IEmployementTypeService, EmployementTypeService>();
            services.AddTransient<ISalaryFormula, SalaryFormulaService>();
            services.AddTransient<ILeaveMasterService, LeaveMasterService>();
            services.AddTransient<IContractorService, ContractorService>();
            services.AddTransient<IHRConfigService, HRConfigService>();
            services.AddTransient<IWagesConfigService, WagesConfigService.WagesConfigService>();
            services.AddTransient<ICanteenChargesService, CanteenChargesService>();
            services.AddTransient<ILoanAdvanceService, LoanAdvanceService.LoanAdvanceService>();
            services.AddTransient<IEmployeeAttendanceSummaryService, EmployeeAttendanceSummaryService>();
            services.AddTransient<IPositiveNoteService, PositiveNoteService>();
            services.AddTransient<IGatePassService, GatePassService>();
            services.AddTransient<IWorkingDaysService, WorkingDaysService>();
            services.AddTransient<IOtherDeductionService, OtherDeductionService>();
            services.AddTransient<IDynamicFormService, DynamicFormService>();
            services.AddTransient<INotificationStatus, NotificationStatusService>();
            services.AddTransient<IPartyService, PartyService>();
            services.AddTransient<IUserProfile, UserProfileService>();
            services.AddTransient<UserMapToEmployeeInterface, UserMapToEmployeeService>();
            services.AddTransient<UserActivityLogInterface, UserActivityLogService>();
            services.AddTransient<ConversationActivitiesInterface, ConversationActivitiesService>();
            services.AddTransient<PartiesListbyNoteInterface, PartiesListbyNoteService>();
            services.AddTransient<SAPItemCollectionInterface, SAPItemCollectionService>();
            services.AddTransient<EndUserTypeMasterInterface, EndUserTypeMasterService>();
            services.AddTransient<IconMasterInterface, IconMasterService>();
            services.AddTransient<UserPermissionInterface, UserPermissionService>();
            services.AddTransient<ProductCategoryMasterInterface, ProductCategoryMasterService>();
            services.AddTransient<EmployeeChildrenInterface, EmployeeChildrenService>();
            services.AddTransient<EmployeeChildrenInterface, EmployeeChildrenService>();
            services.AddTransient<ActivityOnMapInterface, SActivityOnMap.ActivityOnMapService>();
            services.AddTransient<ICommonMasterService, CommonMasterService>();

            services.AddTransient<TestHTMLForm2Interface, TestHTMLForm2Service>();
            services.AddTransient<EmployeeFacilityInterface, EmployeeFacilityService>();
            services.AddTransient<ExpenseTypeMasterInterface, ExpenseTypeMasterService>();
            services.AddTransient<ExpensesTxnInterface, ExpensesTxnService>();
            services.AddTransient<MachineOperatingStatusInterface, MachineOperatingStatusService>();
            services.AddTransient<MachineryInterface, Production.SMachinery.MachineryService>();
            services.AddTransient<DepreciationMethodInterface, DepreciationMethodService>();
            services.AddTransient<ShiftMasterInterface, ShiftMasterService>();
            services.AddTransient<MachineryPurchaseDetailInterface, MachineryPurchaseDetailService>();
            services.AddTransient<MachinerySalesDetailInterface, MachinerySalesDetailService>();
            services.AddTransient<MachineCategoryMasterInterface, MachineCategoryMasterService>();
            services.AddTransient<MachineryEquippedDetailInterface, MachineryEquippedDetailService>();
            services.AddTransient<MachineryMaintenanceTxnInterface, MachineryMaintenanceTxnService>();
            services.AddTransient<MachineryDepreciationTxnInterface, MachineryDepreciationTxnService>();
            services.AddTransient<MachineryShutDownTxnInterface, MachineryShutDownTxnService>();
            services.AddTransient<UtilityMasterInterface, UtilityMasterService>();
            services.AddTransient<MachineryOperationDetailInterface, MachineryOperationDetailService>();
            services.AddTransient<MachineryDailyMISEntryInterface, MachineryDailyMISEntryService>();
            services.AddTransient<ReportMasterInterface, ReportMasterService>();
            services.AddTransient<ReportParametersTxnInterface, ReportParametersTxnService>();
            services.AddTransient<FormReportTxnInterface, FormReportTxnService>();
            services.AddTransient<DashboardInterface, DashboardService>();
            services.AddTransient<SalesOrderMasterInterface, SalesOrderMasterService>();
            services.AddTransient<SalaryFormulaTypeMasterInterface, SalaryFormulaTypeMasterService>();
            services.AddTransient<FormDatabaseTableInterface, FormDatabaseTableService>();
            services.AddTransient<MachineryResourceAllocationInterface, MachineryResourceAllocationService>();
            services.AddTransient<MachineResourceSummaryInterface, MachineResourceSummaryService>();
            services.AddTransient<OpportunityLossMasterInterface, OpportunityLossMasterService>();

            services.AddTransient<ItemQRCodeDetailInterface, ItemQRCodeDetailService>(); 
			 services.AddTransient<MasterPackingInterface, MasterPackingService>(); 
			 services.AddTransient<RequestForQuotMasterInterface, RequestForQuotMasterService>();
			 services.AddTransient<QuotationMasterInterface, QuotationMasterService>();
			 services.AddTransient<OfferAcceptedMasterInterface, OfferAcceptedMasterService>();
			 services.AddTransient<PurchaseOrderMasterInterface, PurchaseOrderMasterService>();



            	 services.AddTransient<RequestForQuotTypeMasterInterface, RequestForQuotTypeMasterService>(); 
		//$InjectForm$


            services.AddTransient<ITestDataTable, TestDataTableService>(); // this is for testing of Jquery DataTables by Rahul Mistry.



            // Add application services.
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
