using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORMģ��, ���ݱ�:dt_MyRoleAuthority
    /// GZFrameworkCodeGenerate�����������Զ�����
    /// ʱ�䣺2015-10-21 10:34
    /// </summary>
    [ModelStruct(dt_MyRoleAuthority._TableName)]
    public sealed class dt_MyRoleAuthority
    {
        public const string _TableName = "dt_MyRoleAuthority";


        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// ��ɫ���
        /// </summary>
        [ModelForeignKey]
        public const string RoleID = "RoleID";

        /// <summary>
        /// Ȩ�޲˵�
        /// </summary>
        [ModelEditField]
        public const string FunctionID = "FunctionID";

        /// <summary>
        /// Ȩ��ֵ
        /// </summary>
        [ModelEditField]
        public const string Authority = "Authority";

        /// <summary>
        /// CreateUser
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// CreateDate
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// LastUpdateUser
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// LastUpdateDate
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }
}
