using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models.DocSN
{
    public enum GenerateDocSNRule
    {
        //�� = 0,
        //��_�� = 1,
        //��_��_�� = 2,
        //ֱ�ӵ��� = 3,
        //�Զ������ɱ�� = 4
        Year = 0,
        Year_Month = 1,
        Year_Month_Day = 2,
        Up = 3,
        Custom = 4
    }
}
