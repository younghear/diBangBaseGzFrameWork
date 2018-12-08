using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFramework.UI.Dev.RibbonButton
{
    public interface IRibbonCommonNavButtons
    {
        /// <summary>
        /// �ƶ�����һ��
        /// </summary>
        RibbonItemButtonBase btnMoveFirst { get; }
        /// <summary>
        /// �ƶ������һ��
        /// </summary>
        RibbonItemButtonBase btnMoveLast { get; }
        /// <summary>
        /// �ƶ���ǰһ��
        /// </summary>
        RibbonItemButtonBase btnMovePrevious { get; }
        /// <summary>
        /// �ƶ�����һ��
        /// </summary>
        RibbonItemButtonBase btnMoveNext { get; }
    }
}
