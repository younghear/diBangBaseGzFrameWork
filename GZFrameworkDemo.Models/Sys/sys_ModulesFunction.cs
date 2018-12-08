using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORMģ��, ���ݱ�:sys_ModulesFunction
    /// GZFrameworkCodeGenerate�����������Զ�����
    /// ʱ�䣺2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_ModulesFunction._TableName)]
    public sealed class sys_ModulesFunction
    {
        public const string _TableName = "sys_ModulesFunction";

        /// <summary>
        /// ģ��ID
        /// </summary>
        [ModelForeignKey]
        public const string ModuleID = "ModuleID";

        /// <summary>
        /// ����ID
        /// </summary>
        [ModelPrimaryKey]
        public const string FunctionID = "FunctionID";



        /// <summary>
        /// ��������
        /// </summary>
        [ModelEditField]
        public const string FunctionName = "FunctionName";

        [ModelEditField]
        public const string Image = "Image";

        [ModelEditField]
        public const string Sort = "Sort";


    }
}
