
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/20/2016 11:49:42
-- Generated from EDMX file: D:\2016.2\XAF\Demos\CS\EFDemo\ModelFirst\EFDemo.Module\Data\EFDemoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFDemo_16.2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Departments_Positions_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Departments_Positions] DROP CONSTRAINT [FK_Departments_Positions_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Departments_Positions_Position]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Departments_Positions] DROP CONSTRAINT [FK_Departments_Positions_Position];
GO
IF OBJECT_ID(N'[dbo].[FK_Contact_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Contact] DROP CONSTRAINT [FK_Contact_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Contact_Position]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Contact] DROP CONSTRAINT [FK_Contact_Position];
GO
IF OBJECT_ID(N'[dbo].[FK_PhoneNumber_Party]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhoneNumbers] DROP CONSTRAINT [FK_PhoneNumber_Party];
GO
IF OBJECT_ID(N'[dbo].[FK_HCategory_HCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCategories] DROP CONSTRAINT [FK_HCategory_HCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_Address_Country]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Addresses] DROP CONSTRAINT [FK_Address_Country];
GO
IF OBJECT_ID(N'[dbo].[FK_Events_Resources_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events_Resources] DROP CONSTRAINT [FK_Events_Resources_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Events_Resources_Resource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events_Resources] DROP CONSTRAINT [FK_Events_Resources_Resource];
GO
IF OBJECT_ID(N'[dbo].[FK_FileAttachment_FileData]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileAttachments] DROP CONSTRAINT [FK_FileAttachment_FileData];
GO
IF OBJECT_ID(N'[dbo].[FK_PortfolioFileData_Resume]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileAttachments_PortfolioFileData] DROP CONSTRAINT [FK_PortfolioFileData_Resume];
GO
IF OBJECT_ID(N'[dbo].[FK_Resume_Contact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resumes] DROP CONSTRAINT [FK_Resume_Contact];
GO
IF OBJECT_ID(N'[dbo].[FK_Party_Address1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties] DROP CONSTRAINT [FK_Party_Address1];
GO
IF OBJECT_ID(N'[dbo].[FK_Party_Address2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties] DROP CONSTRAINT [FK_Party_Address2];
GO
IF OBJECT_ID(N'[dbo].[FK_Contact_Contact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Contact] DROP CONSTRAINT [FK_Contact_Contact];
GO
IF OBJECT_ID(N'[dbo].[FK_Task_Party]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Task_Party];
GO
IF OBJECT_ID(N'[dbo].[FK_DemoTasks_Contacts_DemoTask]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemoTasks_Contacts] DROP CONSTRAINT [FK_DemoTasks_Contacts_DemoTask];
GO
IF OBJECT_ID(N'[dbo].[FK_DemoTasks_Contacts_Contact]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DemoTasks_Contacts] DROP CONSTRAINT [FK_DemoTasks_Contacts_Contact];
GO
IF OBJECT_ID(N'[dbo].[FK_Event_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_Event_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelDifferenceAspect_ModelDifference]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelDifferenceAspects] DROP CONSTRAINT [FK_ModelDifferenceAspect_ModelDifference];
GO
IF OBJECT_ID(N'[dbo].[FK_FileDataResume]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resumes] DROP CONSTRAINT [FK_FileDataResume];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser] DROP CONSTRAINT [FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyRole];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser] DROP CONSTRAINT [FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyUser];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyTypePermissionObjectPermissionPolicyRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyTypePermissionObjectSet] DROP CONSTRAINT [FK_PermissionPolicyTypePermissionObjectPermissionPolicyRole];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyMemberPermissionsObjectPermissionPolicyTypePermissionObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyMemberPermissionsObjectSet] DROP CONSTRAINT [FK_PermissionPolicyMemberPermissionsObjectPermissionPolicyTypePermissionObject];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyObjectPermissionsObjectPermissionPolicyTypePermissionObject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyObjectPermissionsObjectSet] DROP CONSTRAINT [FK_PermissionPolicyObjectPermissionsObjectPermissionPolicyTypePermissionObject];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionPolicyNavigationPermissionObjectPermissionPolicyRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermissionPolicyNavigationPermissionObjectSet] DROP CONSTRAINT [FK_PermissionPolicyNavigationPermissionObjectPermissionPolicyRole];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_inherits_Party]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Person] DROP CONSTRAINT [FK_Person_inherits_Party];
GO
IF OBJECT_ID(N'[dbo].[FK_Contact_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Contact] DROP CONSTRAINT [FK_Contact_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PortfolioFileData_inherits_FileAttachment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileAttachments_PortfolioFileData] DROP CONSTRAINT [FK_PortfolioFileData_inherits_FileAttachment];
GO
IF OBJECT_ID(N'[dbo].[FK_DemoTask_inherits_Task]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks_DemoTask] DROP CONSTRAINT [FK_DemoTask_inherits_Task];
GO
IF OBJECT_ID(N'[dbo].[FK_Organization_inherits_Party]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parties_Organization] DROP CONSTRAINT [FK_Organization_inherits_Party];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Departments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Parties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parties];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO
IF OBJECT_ID(N'[dbo].[Notes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notes];
GO
IF OBJECT_ID(N'[dbo].[PhoneNumbers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhoneNumbers];
GO
IF OBJECT_ID(N'[dbo].[States]', 'U') IS NOT NULL
    DROP TABLE [dbo].[States];
GO
IF OBJECT_ID(N'[dbo].[Payments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payments];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[HCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HCategories];
GO
IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[Resumes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Resumes];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Resources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Resources];
GO
IF OBJECT_ID(N'[dbo].[FileData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileData];
GO
IF OBJECT_ID(N'[dbo].[FileAttachments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileAttachments];
GO
IF OBJECT_ID(N'[dbo].[ReportDataV2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReportDataV2];
GO
IF OBJECT_ID(N'[dbo].[ModulesInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModulesInfo];
GO
IF OBJECT_ID(N'[dbo].[Analysis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Analysis];
GO
IF OBJECT_ID(N'[dbo].[ModelDifferences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelDifferences];
GO
IF OBJECT_ID(N'[dbo].[ModelDifferenceAspects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelDifferenceAspects];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyUserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyUserSet];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyRoleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyRoleSet];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyTypePermissionObjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyTypePermissionObjectSet];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyMemberPermissionsObjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyMemberPermissionsObjectSet];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyObjectPermissionsObjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyObjectPermissionsObjectSet];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyNavigationPermissionObjectSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyNavigationPermissionObjectSet];
GO
IF OBJECT_ID(N'[dbo].[Parties_Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parties_Person];
GO
IF OBJECT_ID(N'[dbo].[Parties_Contact]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parties_Contact];
GO
IF OBJECT_ID(N'[dbo].[FileAttachments_PortfolioFileData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileAttachments_PortfolioFileData];
GO
IF OBJECT_ID(N'[dbo].[Tasks_DemoTask]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks_DemoTask];
GO
IF OBJECT_ID(N'[dbo].[Parties_Organization]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parties_Organization];
GO
IF OBJECT_ID(N'[dbo].[Departments_Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departments_Positions];
GO
IF OBJECT_ID(N'[dbo].[Events_Resources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events_Resources];
GO
IF OBJECT_ID(N'[dbo].[DemoTasks_Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DemoTasks_Contacts];
GO
IF OBJECT_ID(N'[dbo].[PermissionPolicyRolePermissionPolicyUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NULL,
    [Office] nvarchar(max)  NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NULL
);
GO

-- Creating table 'Parties'
CREATE TABLE [dbo].[Parties] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Photo] varbinary(max)  NULL,
    [Address1_ID] int  NULL,
    [Address2_ID] int  NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DateCompleted] datetime  NULL,
    [Subject] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [DueDate] datetime  NULL,
    [StartDate] datetime  NULL,
    [Status_Int] int  NOT NULL,
    [PercentCompleted] int  NOT NULL,
    [AssignedTo_ID] int  NULL
);
GO

-- Creating table 'Notes'
CREATE TABLE [dbo].[Notes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Author] nvarchar(max)  NULL,
    [DateTime] datetime  NULL,
    [Text] nvarchar(max)  NULL
);
GO

-- Creating table 'PhoneNumbers'
CREATE TABLE [dbo].[PhoneNumbers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NULL,
    [PhoneType] nvarchar(max)  NULL,
    [Party_ID] int  NULL
);
GO

-- Creating table 'States'
CREATE TABLE [dbo].[States] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ShortName] nvarchar(max)  NULL,
    [LongName] nvarchar(max)  NULL
);
GO

-- Creating table 'Payments'
CREATE TABLE [dbo].[Payments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Rate] decimal(18,0)  NOT NULL,
    [Hours] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [PhoneCode] nvarchar(max)  NULL
);
GO

-- Creating table 'HCategories'
CREATE TABLE [dbo].[HCategories] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Parent_ID] int  NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Street] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [StateProvince] nvarchar(max)  NULL,
    [ZipPostal] nvarchar(max)  NULL,
    [Country_ID] int  NULL
);
GO

-- Creating table 'Resumes'
CREATE TABLE [dbo].[Resumes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Contact_ID] int  NULL,
    [File_ID] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Subject] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [StartOn] datetime  NULL,
    [EndOn] datetime  NULL,
    [AllDay] bit  NOT NULL,
    [Location] nvarchar(max)  NULL,
    [Label] int  NOT NULL,
    [Status] int  NOT NULL,
    [Type] int  NOT NULL,
    [RecurrenceInfoXml] nvarchar(max)  NULL,
    [AlarmTime] datetime  NULL,
    [ReminderInfoXml] nvarchar(max)  NULL,
    [RemindInSeconds] int  NOT NULL,
    [IsPostponed] bit  NOT NULL,
    [RecurrencePattern_ID] int  NULL
);
GO

-- Creating table 'Resources'
CREATE TABLE [dbo].[Resources] (
    [Key] int IDENTITY(1,1) NOT NULL,
    [Caption] nvarchar(max)  NULL,
    [Color_Int] int  NOT NULL
);
GO

-- Creating table 'FileData'
CREATE TABLE [dbo].[FileData] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Size] int  NOT NULL,
    [FileName] nvarchar(max)  NULL,
    [Content] varbinary(max)  NULL
);
GO

-- Creating table 'FileAttachments'
CREATE TABLE [dbo].[FileAttachments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [File_ID] int  NOT NULL
);
GO

-- Creating table 'ReportDataV2'
CREATE TABLE [dbo].[ReportDataV2] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsInplaceReport] bit  NOT NULL,
    [DisplayName] nvarchar(max)  NOT NULL,
    [DataTypeName] nvarchar(max)  NOT NULL,
    [PredefinedReportTypeName] nvarchar(max)  NULL,
    [Content] varbinary(max)  NULL,
    [ParametersObjectTypeName] nvarchar(max)  NULL
);
GO

-- Creating table 'ModulesInfo'
CREATE TABLE [dbo].[ModulesInfo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Version] nvarchar(max)  NULL,
    [AssemblyFileName] nvarchar(max)  NULL,
    [IsMain] bit  NOT NULL
);
GO

-- Creating table 'Analysis'
CREATE TABLE [dbo].[Analysis] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Criteria] nvarchar(max)  NULL,
    [ObjectTypeName] nvarchar(max)  NULL,
    [DimensionPropertiesString] nvarchar(max)  NULL,
    [PivotGridSettingsContent] varbinary(max)  NULL,
    [ChartSettingsContent] varbinary(max)  NULL
);
GO

-- Creating table 'ModelDifferences'
CREATE TABLE [dbo].[ModelDifferences] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(max)  NULL,
    [Version] int  NOT NULL,
    [ContextId] nvarchar(max)  NULL
);
GO

-- Creating table 'ModelDifferenceAspects'
CREATE TABLE [dbo].[ModelDifferenceAspects] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Xml] nvarchar(max)  NULL,
    [Owner_ID] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyUserSet'
CREATE TABLE [dbo].[PermissionPolicyUserSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NULL,
    [IsActive] bit  NOT NULL,
    [ChangePasswordOnFirstLogon] bit  NOT NULL,
    [StoredPassword] nvarchar(max)  NULL
);
GO

-- Creating table 'PermissionPolicyRoleSet'
CREATE TABLE [dbo].[PermissionPolicyRoleSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [IsAdministrative] bit  NOT NULL,
    [CanEditModel] bit  NOT NULL,
    [PermissionPolicy_Int] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyTypePermissionObjectSet'
CREATE TABLE [dbo].[PermissionPolicyTypePermissionObjectSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TargetTypeFullName] nvarchar(max)  NOT NULL,
    [ReadState_Int] int  NULL,
    [WriteState_Int] int  NULL,
    [CreateState_Int] int  NULL,
    [DeleteState_Int] int  NULL,
    [NavigateState_Int] int  NULL,
    [Role_ID] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyMemberPermissionsObjectSet'
CREATE TABLE [dbo].[PermissionPolicyMemberPermissionsObjectSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Criteria] nvarchar(max)  NULL,
    [ReadState_Int] int  NULL,
    [WriteState_Int] int  NULL,
    [Members] nvarchar(max)  NULL,
    [TypePermissionObject_ID] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyObjectPermissionsObjectSet'
CREATE TABLE [dbo].[PermissionPolicyObjectPermissionsObjectSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Criteria] nvarchar(max)  NULL,
    [ReadState_Int] int  NULL,
    [WriteState_Int] int  NULL,
    [DeleteState_Int] int  NULL,
    [NavigateState_Int] int  NULL,
    [TypePermissionObject_ID] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyNavigationPermissionObjectSet'
CREATE TABLE [dbo].[PermissionPolicyNavigationPermissionObjectSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ItemPath] nvarchar(max)  NULL,
    [NavigateState_Int] int  NULL,
    [Role_ID] int  NOT NULL
);
GO

-- Creating table 'Parties_Person'
CREATE TABLE [dbo].[Parties_Person] (
    [FirstName] nvarchar(max)  NULL,
    [LastName] nvarchar(max)  NULL,
    [MiddleName] nvarchar(max)  NULL,
    [Birthday] datetime  NULL,
    [Email] nvarchar(max)  NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'Parties_Contact'
CREATE TABLE [dbo].[Parties_Contact] (
    [WebPageAddress] nvarchar(max)  NULL,
    [NickName] nvarchar(max)  NULL,
    [SpouseName] nvarchar(max)  NULL,
    [TitleOfCourtesy_Int] int  NOT NULL,
    [Anniversary] datetime  NULL,
    [Notes] nvarchar(max)  NULL,
    [ID] int  NOT NULL,
    [Department_ID] int  NULL,
    [Position_ID] int  NULL,
    [Manager_ID] int  NULL
);
GO

-- Creating table 'FileAttachments_PortfolioFileData'
CREATE TABLE [dbo].[FileAttachments_PortfolioFileData] (
    [DocumentType_Int] int  NOT NULL,
    [ID] int  NOT NULL,
    [Resume_ID] int  NOT NULL
);
GO

-- Creating table 'Tasks_DemoTask'
CREATE TABLE [dbo].[Tasks_DemoTask] (
    [Priority_Int] int  NOT NULL,
    [EstimatedWork] int  NULL,
    [ActualWork] int  NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'Parties_Organization'
CREATE TABLE [dbo].[Parties_Organization] (
    [FullName] nvarchar(max)  NULL,
    [Profile] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [WebSite] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [Name] nvarchar(max)  NULL,
    [ID] int  NOT NULL
);
GO

-- Creating table 'Departments_Positions'
CREATE TABLE [dbo].[Departments_Positions] (
    [Departments_ID] int  NOT NULL,
    [Positions_ID] int  NOT NULL
);
GO

-- Creating table 'Events_Resources'
CREATE TABLE [dbo].[Events_Resources] (
    [Events_ID] int  NOT NULL,
    [Resources_Key] int  NOT NULL
);
GO

-- Creating table 'DemoTasks_Contacts'
CREATE TABLE [dbo].[DemoTasks_Contacts] (
    [Tasks_ID] int  NOT NULL,
    [Contacts_ID] int  NOT NULL
);
GO

-- Creating table 'PermissionPolicyRolePermissionPolicyUser'
CREATE TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser] (
    [Roles_ID] int  NOT NULL,
    [Users_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Parties'
ALTER TABLE [dbo].[Parties]
ADD CONSTRAINT [PK_Parties]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Notes'
ALTER TABLE [dbo].[Notes]
ADD CONSTRAINT [PK_Notes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PhoneNumbers'
ALTER TABLE [dbo].[PhoneNumbers]
ADD CONSTRAINT [PK_PhoneNumbers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [PK_States]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Payments'
ALTER TABLE [dbo].[Payments]
ADD CONSTRAINT [PK_Payments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'HCategories'
ALTER TABLE [dbo].[HCategories]
ADD CONSTRAINT [PK_HCategories]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Resumes'
ALTER TABLE [dbo].[Resumes]
ADD CONSTRAINT [PK_Resumes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Key] in table 'Resources'
ALTER TABLE [dbo].[Resources]
ADD CONSTRAINT [PK_Resources]
    PRIMARY KEY CLUSTERED ([Key] ASC);
GO

-- Creating primary key on [ID] in table 'FileData'
ALTER TABLE [dbo].[FileData]
ADD CONSTRAINT [PK_FileData]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FileAttachments'
ALTER TABLE [dbo].[FileAttachments]
ADD CONSTRAINT [PK_FileAttachments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'ReportDataV2'
ALTER TABLE [dbo].[ReportDataV2]
ADD CONSTRAINT [PK_ReportDataV2]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'ModulesInfo'
ALTER TABLE [dbo].[ModulesInfo]
ADD CONSTRAINT [PK_ModulesInfo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Analysis'
ALTER TABLE [dbo].[Analysis]
ADD CONSTRAINT [PK_Analysis]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ModelDifferences'
ALTER TABLE [dbo].[ModelDifferences]
ADD CONSTRAINT [PK_ModelDifferences]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ModelDifferenceAspects'
ALTER TABLE [dbo].[ModelDifferenceAspects]
ADD CONSTRAINT [PK_ModelDifferenceAspects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyUserSet'
ALTER TABLE [dbo].[PermissionPolicyUserSet]
ADD CONSTRAINT [PK_PermissionPolicyUserSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyRoleSet'
ALTER TABLE [dbo].[PermissionPolicyRoleSet]
ADD CONSTRAINT [PK_PermissionPolicyRoleSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyTypePermissionObjectSet'
ALTER TABLE [dbo].[PermissionPolicyTypePermissionObjectSet]
ADD CONSTRAINT [PK_PermissionPolicyTypePermissionObjectSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyMemberPermissionsObjectSet'
ALTER TABLE [dbo].[PermissionPolicyMemberPermissionsObjectSet]
ADD CONSTRAINT [PK_PermissionPolicyMemberPermissionsObjectSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyObjectPermissionsObjectSet'
ALTER TABLE [dbo].[PermissionPolicyObjectPermissionsObjectSet]
ADD CONSTRAINT [PK_PermissionPolicyObjectPermissionsObjectSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PermissionPolicyNavigationPermissionObjectSet'
ALTER TABLE [dbo].[PermissionPolicyNavigationPermissionObjectSet]
ADD CONSTRAINT [PK_PermissionPolicyNavigationPermissionObjectSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Parties_Person'
ALTER TABLE [dbo].[Parties_Person]
ADD CONSTRAINT [PK_Parties_Person]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Parties_Contact'
ALTER TABLE [dbo].[Parties_Contact]
ADD CONSTRAINT [PK_Parties_Contact]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FileAttachments_PortfolioFileData'
ALTER TABLE [dbo].[FileAttachments_PortfolioFileData]
ADD CONSTRAINT [PK_FileAttachments_PortfolioFileData]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Tasks_DemoTask'
ALTER TABLE [dbo].[Tasks_DemoTask]
ADD CONSTRAINT [PK_Tasks_DemoTask]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Parties_Organization'
ALTER TABLE [dbo].[Parties_Organization]
ADD CONSTRAINT [PK_Parties_Organization]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Departments_ID], [Positions_ID] in table 'Departments_Positions'
ALTER TABLE [dbo].[Departments_Positions]
ADD CONSTRAINT [PK_Departments_Positions]
    PRIMARY KEY CLUSTERED ([Departments_ID], [Positions_ID] ASC);
GO

-- Creating primary key on [Events_ID], [Resources_Key] in table 'Events_Resources'
ALTER TABLE [dbo].[Events_Resources]
ADD CONSTRAINT [PK_Events_Resources]
    PRIMARY KEY CLUSTERED ([Events_ID], [Resources_Key] ASC);
GO

-- Creating primary key on [Tasks_ID], [Contacts_ID] in table 'DemoTasks_Contacts'
ALTER TABLE [dbo].[DemoTasks_Contacts]
ADD CONSTRAINT [PK_DemoTasks_Contacts]
    PRIMARY KEY CLUSTERED ([Tasks_ID], [Contacts_ID] ASC);
GO

-- Creating primary key on [Roles_ID], [Users_ID] in table 'PermissionPolicyRolePermissionPolicyUser'
ALTER TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser]
ADD CONSTRAINT [PK_PermissionPolicyRolePermissionPolicyUser]
    PRIMARY KEY CLUSTERED ([Roles_ID], [Users_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Departments_ID] in table 'Departments_Positions'
ALTER TABLE [dbo].[Departments_Positions]
ADD CONSTRAINT [FK_Departments_Positions_Department]
    FOREIGN KEY ([Departments_ID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Positions_ID] in table 'Departments_Positions'
ALTER TABLE [dbo].[Departments_Positions]
ADD CONSTRAINT [FK_Departments_Positions_Position]
    FOREIGN KEY ([Positions_ID])
    REFERENCES [dbo].[Positions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Departments_Positions_Position'
CREATE INDEX [IX_FK_Departments_Positions_Position]
ON [dbo].[Departments_Positions]
    ([Positions_ID]);
GO

-- Creating foreign key on [Department_ID] in table 'Parties_Contact'
ALTER TABLE [dbo].[Parties_Contact]
ADD CONSTRAINT [FK_Contact_Department]
    FOREIGN KEY ([Department_ID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contact_Department'
CREATE INDEX [IX_FK_Contact_Department]
ON [dbo].[Parties_Contact]
    ([Department_ID]);
GO

-- Creating foreign key on [Position_ID] in table 'Parties_Contact'
ALTER TABLE [dbo].[Parties_Contact]
ADD CONSTRAINT [FK_Contact_Position]
    FOREIGN KEY ([Position_ID])
    REFERENCES [dbo].[Positions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contact_Position'
CREATE INDEX [IX_FK_Contact_Position]
ON [dbo].[Parties_Contact]
    ([Position_ID]);
GO

-- Creating foreign key on [Party_ID] in table 'PhoneNumbers'
ALTER TABLE [dbo].[PhoneNumbers]
ADD CONSTRAINT [FK_PhoneNumber_Party]
    FOREIGN KEY ([Party_ID])
    REFERENCES [dbo].[Parties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhoneNumber_Party'
CREATE INDEX [IX_FK_PhoneNumber_Party]
ON [dbo].[PhoneNumbers]
    ([Party_ID]);
GO

-- Creating foreign key on [Parent_ID] in table 'HCategories'
ALTER TABLE [dbo].[HCategories]
ADD CONSTRAINT [FK_HCategory_HCategory]
    FOREIGN KEY ([Parent_ID])
    REFERENCES [dbo].[HCategories]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCategory_HCategory'
CREATE INDEX [IX_FK_HCategory_HCategory]
ON [dbo].[HCategories]
    ([Parent_ID]);
GO

-- Creating foreign key on [Country_ID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [FK_Address_Country]
    FOREIGN KEY ([Country_ID])
    REFERENCES [dbo].[Countries]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Address_Country'
CREATE INDEX [IX_FK_Address_Country]
ON [dbo].[Addresses]
    ([Country_ID]);
GO

-- Creating foreign key on [Events_ID] in table 'Events_Resources'
ALTER TABLE [dbo].[Events_Resources]
ADD CONSTRAINT [FK_Events_Resources_Event]
    FOREIGN KEY ([Events_ID])
    REFERENCES [dbo].[Events]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Resources_Key] in table 'Events_Resources'
ALTER TABLE [dbo].[Events_Resources]
ADD CONSTRAINT [FK_Events_Resources_Resource]
    FOREIGN KEY ([Resources_Key])
    REFERENCES [dbo].[Resources]
        ([Key])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Events_Resources_Resource'
CREATE INDEX [IX_FK_Events_Resources_Resource]
ON [dbo].[Events_Resources]
    ([Resources_Key]);
GO

-- Creating foreign key on [File_ID] in table 'FileAttachments'
ALTER TABLE [dbo].[FileAttachments]
ADD CONSTRAINT [FK_FileAttachment_FileData]
    FOREIGN KEY ([File_ID])
    REFERENCES [dbo].[FileData]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileAttachment_FileData'
CREATE INDEX [IX_FK_FileAttachment_FileData]
ON [dbo].[FileAttachments]
    ([File_ID]);
GO

-- Creating foreign key on [Resume_ID] in table 'FileAttachments_PortfolioFileData'
ALTER TABLE [dbo].[FileAttachments_PortfolioFileData]
ADD CONSTRAINT [FK_PortfolioFileData_Resume]
    FOREIGN KEY ([Resume_ID])
    REFERENCES [dbo].[Resumes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PortfolioFileData_Resume'
CREATE INDEX [IX_FK_PortfolioFileData_Resume]
ON [dbo].[FileAttachments_PortfolioFileData]
    ([Resume_ID]);
GO

-- Creating foreign key on [Contact_ID] in table 'Resumes'
ALTER TABLE [dbo].[Resumes]
ADD CONSTRAINT [FK_Resume_Contact]
    FOREIGN KEY ([Contact_ID])
    REFERENCES [dbo].[Parties_Contact]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Resume_Contact'
CREATE INDEX [IX_FK_Resume_Contact]
ON [dbo].[Resumes]
    ([Contact_ID]);
GO

-- Creating foreign key on [Address1_ID] in table 'Parties'
ALTER TABLE [dbo].[Parties]
ADD CONSTRAINT [FK_Party_Address1]
    FOREIGN KEY ([Address1_ID])
    REFERENCES [dbo].[Addresses]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Party_Address1'
CREATE INDEX [IX_FK_Party_Address1]
ON [dbo].[Parties]
    ([Address1_ID]);
GO

-- Creating foreign key on [Address2_ID] in table 'Parties'
ALTER TABLE [dbo].[Parties]
ADD CONSTRAINT [FK_Party_Address2]
    FOREIGN KEY ([Address2_ID])
    REFERENCES [dbo].[Addresses]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Party_Address2'
CREATE INDEX [IX_FK_Party_Address2]
ON [dbo].[Parties]
    ([Address2_ID]);
GO

-- Creating foreign key on [Manager_ID] in table 'Parties_Contact'
ALTER TABLE [dbo].[Parties_Contact]
ADD CONSTRAINT [FK_Contact_Contact]
    FOREIGN KEY ([Manager_ID])
    REFERENCES [dbo].[Parties_Contact]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Contact_Contact'
CREATE INDEX [IX_FK_Contact_Contact]
ON [dbo].[Parties_Contact]
    ([Manager_ID]);
GO

-- Creating foreign key on [AssignedTo_ID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Task_Party]
    FOREIGN KEY ([AssignedTo_ID])
    REFERENCES [dbo].[Parties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Task_Party'
CREATE INDEX [IX_FK_Task_Party]
ON [dbo].[Tasks]
    ([AssignedTo_ID]);
GO

-- Creating foreign key on [Tasks_ID] in table 'DemoTasks_Contacts'
ALTER TABLE [dbo].[DemoTasks_Contacts]
ADD CONSTRAINT [FK_DemoTasks_Contacts_DemoTask]
    FOREIGN KEY ([Tasks_ID])
    REFERENCES [dbo].[Tasks_DemoTask]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Contacts_ID] in table 'DemoTasks_Contacts'
ALTER TABLE [dbo].[DemoTasks_Contacts]
ADD CONSTRAINT [FK_DemoTasks_Contacts_Contact]
    FOREIGN KEY ([Contacts_ID])
    REFERENCES [dbo].[Parties_Contact]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemoTasks_Contacts_Contact'
CREATE INDEX [IX_FK_DemoTasks_Contacts_Contact]
ON [dbo].[DemoTasks_Contacts]
    ([Contacts_ID]);
GO

-- Creating foreign key on [RecurrencePattern_ID] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_Event_Event]
    FOREIGN KEY ([RecurrencePattern_ID])
    REFERENCES [dbo].[Events]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Event_Event'
CREATE INDEX [IX_FK_Event_Event]
ON [dbo].[Events]
    ([RecurrencePattern_ID]);
GO

-- Creating foreign key on [Owner_ID] in table 'ModelDifferenceAspects'
ALTER TABLE [dbo].[ModelDifferenceAspects]
ADD CONSTRAINT [FK_ModelDifferenceAspect_ModelDifference]
    FOREIGN KEY ([Owner_ID])
    REFERENCES [dbo].[ModelDifferences]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelDifferenceAspect_ModelDifference'
CREATE INDEX [IX_FK_ModelDifferenceAspect_ModelDifference]
ON [dbo].[ModelDifferenceAspects]
    ([Owner_ID]);
GO

-- Creating foreign key on [File_ID] in table 'Resumes'
ALTER TABLE [dbo].[Resumes]
ADD CONSTRAINT [FK_FileDataResume]
    FOREIGN KEY ([File_ID])
    REFERENCES [dbo].[FileData]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileDataResume'
CREATE INDEX [IX_FK_FileDataResume]
ON [dbo].[Resumes]
    ([File_ID]);
GO

-- Creating foreign key on [Roles_ID] in table 'PermissionPolicyRolePermissionPolicyUser'
ALTER TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser]
ADD CONSTRAINT [FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyRole]
    FOREIGN KEY ([Roles_ID])
    REFERENCES [dbo].[PermissionPolicyRoleSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Users_ID] in table 'PermissionPolicyRolePermissionPolicyUser'
ALTER TABLE [dbo].[PermissionPolicyRolePermissionPolicyUser]
ADD CONSTRAINT [FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyUser]
    FOREIGN KEY ([Users_ID])
    REFERENCES [dbo].[PermissionPolicyUserSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyUser'
CREATE INDEX [IX_FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyUser]
ON [dbo].[PermissionPolicyRolePermissionPolicyUser]
    ([Users_ID]);
GO

-- Creating foreign key on [Role_ID] in table 'PermissionPolicyTypePermissionObjectSet'
ALTER TABLE [dbo].[PermissionPolicyTypePermissionObjectSet]
ADD CONSTRAINT [FK_PermissionPolicyTypePermissionObjectPermissionPolicyRole]
    FOREIGN KEY ([Role_ID])
    REFERENCES [dbo].[PermissionPolicyRoleSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionPolicyTypePermissionObjectPermissionPolicyRole'
CREATE INDEX [IX_FK_PermissionPolicyTypePermissionObjectPermissionPolicyRole]
ON [dbo].[PermissionPolicyTypePermissionObjectSet]
    ([Role_ID]);
GO

-- Creating foreign key on [TypePermissionObject_ID] in table 'PermissionPolicyMemberPermissionsObjectSet'
ALTER TABLE [dbo].[PermissionPolicyMemberPermissionsObjectSet]
ADD CONSTRAINT [FK_PermissionPolicyMemberPermissionsObjectPermissionPolicyTypePermissionObject]
    FOREIGN KEY ([TypePermissionObject_ID])
    REFERENCES [dbo].[PermissionPolicyTypePermissionObjectSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionPolicyMemberPermissionsObjectPermissionPolicyTypePermissionObject'
CREATE INDEX [IX_FK_PermissionPolicyMemberPermissionsObjectPermissionPolicyTypePermissionObject]
ON [dbo].[PermissionPolicyMemberPermissionsObjectSet]
    ([TypePermissionObject_ID]);
GO

-- Creating foreign key on [TypePermissionObject_ID] in table 'PermissionPolicyObjectPermissionsObjectSet'
ALTER TABLE [dbo].[PermissionPolicyObjectPermissionsObjectSet]
ADD CONSTRAINT [FK_PermissionPolicyObjectPermissionsObjectPermissionPolicyTypePermissionObject]
    FOREIGN KEY ([TypePermissionObject_ID])
    REFERENCES [dbo].[PermissionPolicyTypePermissionObjectSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionPolicyObjectPermissionsObjectPermissionPolicyTypePermissionObject'
CREATE INDEX [IX_FK_PermissionPolicyObjectPermissionsObjectPermissionPolicyTypePermissionObject]
ON [dbo].[PermissionPolicyObjectPermissionsObjectSet]
    ([TypePermissionObject_ID]);
GO

-- Creating foreign key on [Role_ID] in table 'PermissionPolicyNavigationPermissionObjectSet'
ALTER TABLE [dbo].[PermissionPolicyNavigationPermissionObjectSet]
ADD CONSTRAINT [FK_PermissionPolicyNavigationPermissionObjectPermissionPolicyRole]
    FOREIGN KEY ([Role_ID])
    REFERENCES [dbo].[PermissionPolicyRoleSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionPolicyNavigationPermissionObjectPermissionPolicyRole'
CREATE INDEX [IX_FK_PermissionPolicyNavigationPermissionObjectPermissionPolicyRole]
ON [dbo].[PermissionPolicyNavigationPermissionObjectSet]
    ([Role_ID]);
GO

-- Creating foreign key on [ID] in table 'Parties_Person'
ALTER TABLE [dbo].[Parties_Person]
ADD CONSTRAINT [FK_Person_inherits_Party]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Parties]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'Parties_Contact'
ALTER TABLE [dbo].[Parties_Contact]
ADD CONSTRAINT [FK_Contact_inherits_Person]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Parties_Person]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'FileAttachments_PortfolioFileData'
ALTER TABLE [dbo].[FileAttachments_PortfolioFileData]
ADD CONSTRAINT [FK_PortfolioFileData_inherits_FileAttachment]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[FileAttachments]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'Tasks_DemoTask'
ALTER TABLE [dbo].[Tasks_DemoTask]
ADD CONSTRAINT [FK_DemoTask_inherits_Task]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Tasks]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'Parties_Organization'
ALTER TABLE [dbo].[Parties_Organization]
ADD CONSTRAINT [FK_Organization_inherits_Party]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Parties]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------