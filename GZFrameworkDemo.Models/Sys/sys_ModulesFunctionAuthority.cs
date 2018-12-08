using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORMģ��, ���ݱ�:sys_ModulesFunctionAuthority
    /// GZFrameworkCodeGenerate�����������Զ�����
    /// ʱ�䣺2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_ModulesFunctionAuthority._TableName)]
    public sealed class sys_ModulesFunctionAuthority
    {
        public const string _TableName = "sys_ModulesFunctionAuthority";

        /// <summary>
        /// ����ID
        /// </summary>
        [ModelEditField(true, true, false)]
        public const string FunctionID = "FunctionID";

        /// <summary>
        /// Ȩ��ֵ
        /// </summary>
        [ModelPrimaryKey]
        public const string AuthorityID = "AuthorityID";
       
        /// <summary>
        /// Ȩ������
        /// </summary>
        [ModelEditField]
        public const string AuthorityName = "AuthorityName";

    }
}
