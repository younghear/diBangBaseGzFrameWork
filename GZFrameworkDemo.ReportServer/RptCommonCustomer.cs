using FastReport;
using GZDBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GZFrameworkDemo.ReportServer
{
    /// <summary>
    /// ����׼���������Զ�������Դ
    /// </summary>
    public class RptCommonCustomer : RptCommonBase
    {

        public delegate void BindDataSourceHandle(Report report, DataSet Data);
        /// <summary>
        /// ����Դ
        /// </summary>
        private DataSet DataSource { get; set; }

        /// <summary>
        /// �洢��������
        /// </summary>
        private string SPName { get; set; }

        /// <summary>
        /// �洢���̲���
        /// </summary>
        private IDbParms Parms { get; set; }

        private bool ISSP { get; set; } = false;

        public void PrepareDataSource()
        {
            if (ISSP == true)
                DataSource = db.GetDataSet(SPName, Parms);
        }

        /// <summary>
        /// �Զ��屨��׼��
        /// </summary>

        public event Action<Report> BeforePrepare;

        /// <summary>
        /// �������ݱ��� ֱ���ṩ����Դ
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="RptFileName"></param>
        /// <param name="DataSource"></param>
        public RptCommonCustomer(Form owner, string RptFileName, DataSet DataSource)
            : base(owner, RptFileName)
        {
            this.DataSource = DataSource;
            ISSP = false;
        }
        /// <summary>
        /// �������ݱ��� �洢���̻������Դ
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="RptFileName"></param>
        /// <param name="SPName"></param>
        /// <param name="Parms"></param>
        public RptCommonCustomer(Form owner, string RptFileName, string SPName, IDbParms Parms)
            : base(owner, RptFileName)
        {
            this.SPName = SPName;
            this.Parms = Parms;
            ISSP = true;
        }

        public event BindDataSourceHandle BindDataSource;

        public override Report PrepareReport()
        {
            Report rpt = null;
            try
            {
                GZFramework.UI.Dev.WaiteServer.ShowWaite(Owner);
                rpt = LoadReport(RptFileName);

                PrepareDataSource();

                BindDataSource?.Invoke(rpt, DataSource);

                //rpt.RegisterData(DataSource, "D");

                //DataBand dataBandD1 = rpt.FindObject("Data1") as DataBand;
                //dataBandD1.DataSource = rpt.GetDataSource("D");

                UpdateRptCommandData(rpt);

                BeforePrepare?.Invoke(rpt);
            }

            catch (Exception ex)
            {
                RptSuccess = false;
                RptException = ex;
            }
            finally
            {
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
                if (RptSuccess == false)
                {
                    GZFramework.UI.Dev.Common.Msg.ShowError(RptException.Message);
                    //rpt = null;
                }
                //else
                //{
                //    rpt.Prepare();//׼������     
                //}
            }
            return rpt;
        }
    }
}
