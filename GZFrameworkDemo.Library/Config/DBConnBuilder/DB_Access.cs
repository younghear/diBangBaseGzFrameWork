using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_Access :IDB
    {
        /*
 ���ö�ռ��ʽ�������ӣ�

    "Driver={Microsoft Access Driver (*.mdb)}; DBQ=C:\App1\������ݿ���.mdb; Exclusive=1; Uid=����û���; Pwd=�������;"

    MS ACCESS OLEDB & OleDbConnection ��.NET�µ�OleDb�ӿڣ���������

    ��ͨ��ʽ����ã�����ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; User Id=admin; Password="

    ʹ�ù����鷽ʽ��ϵͳ���ݿ⣩����ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; Jet OLEDB:System Database=c:\App1\���ϵͳ���ݿ���.mdw"

    ���ӵ����������ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; Jet OLEDB:Database Password=�������"

    ���ӵ����ھ����������ϵ�ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\Server_Name\Share_Name\Share_Path\������ݿ���.mdb"

    ���ӵ�����Զ�̷������ϵ�ACCESS���ݿ⣺

    "Provider=MS Remote; Remote Server=http://Զ�̷�����IP; Remote Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb"

    MS ACCESS ODBC����ʽ�ӿ������ַ���

    ��׼���ӣ�

    "Driver= {MicrosoftAccessDriver(*.mdb)};DBQ=C:\App1\������ݿ���.mdb;Uid=����û���;Pwd=�������;"

    ���ACCESS���ݿ�δ�����û��������룬�����ա���ͬ��

    WorkGroup��ʽ�������鷽ʽ�����ӣ�

    "Driver={Microsoft Access Driver (*.mdb)}; Dbq=C:\App1\������ݿ���.mdb; SystemDB=C:\App1\������ݿ���.mdw;"

    ���ö�ռ��ʽ�������ӣ�

    "Driver={Microsoft Access Driver (*.mdb)}; DBQ=C:\App1\������ݿ���.mdb; Exclusive=1; Uid=����û���; Pwd=�������;"

    MS ACCESS OLEDB & OleDbConnection ��.NET�µ�OleDb�ӿڣ���������

    ��ͨ��ʽ����ã�����ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; User Id=admin; Password="

    ʹ�ù����鷽ʽ��ϵͳ���ݿ⣩����ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; Jet OLEDB:System Database=c:\App1\���ϵͳ���ݿ���.mdw"

    ���ӵ����������ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; Jet OLEDB:Database Password=�������"

    ���ӵ����ھ����������ϵ�ACCESS���ݿ⣺

    "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=\\Server_Name\Share_Name\Share_Path\������ݿ���.mdb"

    ���ӵ�����Զ�̷������ϵ�ACCESS���ݿ⣺

    "Provider=MS Remote; Remote Server=http://Զ�̷�����IP; Remote Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb"

     

    ___________________________________

    ���_Access�ķ�ʽ
    Access�Ĵ��_��ʽ�Ѓ���,һ�����Ԫ�ռʽ��ʽ���_,��һ�ֹ���ʽ,����Ԫ�ռʽʽ���_,��ô�����ĳ�ʽ�ھ�ֻ���x�@���ļ�,������update��delete.����O���˔��ݎ��ܴa,C#���B������.Ĭ�J�����Թ���ʽ���_��.
    �O��Access���ܴa
    Access���ܴa��2��,�քe�����·�ʽ�O��,
    (1)"���ߡ�->"��ȫ"->"�������ݿ�����"
    (2)"����"->"��ȫ"->"�û�������˻�"
    �քӴ��_Access�ļ��r,��������ʾݔ���Ñ������ܴa,Ȼ������ʾݔ�딵�ݎ��ܴa.
    C#�B��Access�ķ�ʽ
    (1)�o���ݎ��ܴa�r(�Л]���Ñ��ܴaԓ����������),�@�ַ�ʽ�Թ���ʽ���_.
    OleDbConnection dbconn=new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data source=D:\Testdb.mdb;");
    (2)�Д��ݎ��ܴa�r(�Л]���Ñ��ܴaԓ����������),�@�ַ�ʽ�Ԫ�ռʽ��ʽ���_.
    OleDbConnection   dbconn   =   new   OleDbConnection(@"Provider=Microsoft.Jet.OleDB.4.0;Data Source=D:\Testdb.mdb;Jet OleDb:DataBase Password=12345");  
    (3)�ڔ��ݎ��ܴa���Ñ��ܴa���Еr,������ԓ����,���Ñ��ܴa̎�����O���ܴaҲ��횞��,�@�ַ�ʽҲ���Ԫ�ռʽ��ʽ���_.
    OleDbConnection   dbconn   =   new   OleDbConnection(@"Provider=Microsoft.Jet.OleDB.4.0;Data Source=D:\Testdb.mdb;Jet OleDb:DataBase Password=12345;Persist Security Info=true;password=;user id=Admin");
 */
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "Ա����Ϣ.mdb" + ";Persist Security Info=False
        public string ProviderName
        {
            get;
            set;
        }

        public string DataSource { get; set; }

        public string UserID { get; set; }
        public string Password { get; set; }
        
        public DB_Access()
        {
            ProviderName = "System.Data.OleDb";
        }

        public string GetConnectionStr()
        {
            //"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=c:\App1\������ݿ���.mdb; User Id=admin; Password="
            return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};User Id={1}; Password={2}", DataSource, UserID, Password);
        }
    }
}
