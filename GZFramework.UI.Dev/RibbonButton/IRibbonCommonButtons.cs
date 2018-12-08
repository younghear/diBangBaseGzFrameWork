using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFramework.UI.Dev.RibbonButton
{
    public interface IRibbonCommonButtons
    {
        /// <summary>
        /// �鿴
        /// </summary>
        RibbonItemButtonBase btnView { get; }
        /// <summary>
        /// ˢ��
        /// </summary>
        RibbonItemButtonBase btnRefresh { get; }
        /// <summary>
        /// ����
        /// </summary>
        RibbonItemButtonBase btnADD { get; }
        /// <summary>
        /// ɾ��
        /// </summary>
        RibbonItemButtonBase btnDelete { get; }
        /// <summary>
        /// �޸�
        /// </summary>
        RibbonItemButtonBase btnEdit { get; }
        /// <summary>
        /// ����
        /// </summary>
        RibbonItemButtonBase btnSave { get; }
        /// <summary>
        /// ���沢�ر�
        /// </summary>
        RibbonItemButtonBase btnSaveAndClose { get; }
        /// <summary>
        /// ���
        /// </summary>
        RibbonItemButtonBase btnApproval { get; }
        /// <summary>
        /// ����ȡ��
        /// </summary>
        RibbonItemButtonBase btnCancel { get; }
        /// <summary>
        /// ��ӡԤ��
        /// </summary>
        RibbonItemButtonBase btnPreview { get; }
        /// <summary>
        /// ��������
        /// </summary>
        RibbonItemButtonBase btnExport { get; }
    }
}
