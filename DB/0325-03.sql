
CREATE TABLE [dbo].[dt_Data_Supplier](
	[isid] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SupplierID] [varchar](20) NOT NULL,
	[SupplierName] [nvarchar](200) NULL,
	[ZJM] [varchar](20) NULL,
	[SupplierAddress] [nvarchar](200) NULL,
	[Contacts] [nvarchar](20) NULL,
	[Phone] [varchar](20) NULL,
	[Remark] [nvarchar](500) NULL,
	[Status] [int] NULL,
	[CreateUser] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateUser] [varchar](20) NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_DT_DATA_SUPPLIER] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'isid'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ӧ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'SupplierID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ӧ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'SupplierName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'ZJM'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ӧ�̵�ַ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'SupplierAddress'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ϵ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'Contacts'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ϵ�绰' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'Phone'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'Remark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'Status'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'CreateUser'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'LastUpdateUser'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier', @level2type=N'COLUMN',@level2name=N'LastUpdateDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������-��Ӧ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_Supplier'
GO

