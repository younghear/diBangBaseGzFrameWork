using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORMģ��, ���ݱ�:sys_Modules
    /// GZFrameworkCodeGenerate�����������Զ�����
    /// ʱ�䣺2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_Modules._TableName)]
    public sealed class sys_Modules
    {
        public const string _TableName = "sys_Modules";


        /// <summary>
        /// ģ��ID
        /// </summary>
        [ModelPrimaryKey]
        public const string ModuleID = "ModuleID";


        /// <summary>
        /// ģ������
        /// </summary>
        [ModelEditField]
        public const string ModuleName = "ModuleName";

        /// <summary>
        /// ����
        /// </summary>
        [ModelEditField]
        public const string Sort = "Sort";


    }
}
