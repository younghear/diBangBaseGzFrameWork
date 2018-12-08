
CREATE TABLE [dbo].[dt_Data_StoragePosition](
	[isid] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SPID] [varchar](20) NOT NULL,
	[Storage] [varchar](20) NULL,
	[Position] [varchar](20) NULL,
	[Remark] [varchar](20) NULL,
	[CreateUser] [varchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateUser] [varchar](20) NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_DT_DATA_STORAGEPOSITION] PRIMARY KEY CLUSTERED 
(
	[SPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'isid'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ϱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'SPID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ֿ��ʶ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'Storage'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��λ��ʶ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'Position'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'Remark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'CreateUser'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'LastUpdateUser'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition', @level2type=N'COLUMN',@level2name=N'LastUpdateDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������-�ֿ��λ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dt_Data_StoragePosition'
GO

