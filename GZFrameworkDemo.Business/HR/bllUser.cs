using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.HR
{
    public class bllUser : Base.bllBase
    {
        public bllUser() 
            : base(typeof(Models.dt_MyUser)) // 设置主表ORM模型
        {
            //配置ORM模型数据库
            DBCode = Models.Loginer.CurrentLoginer.SystemDBCode;
        }
    }
}
