using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_SQLite : IDB
    {

        public string ProviderName
        {
            get;
            set;
        }
        public string DataSource { get; set; }

        private bool _Pooling = true;
        public DB_SQLite()
        {
            ProviderName = "System.Data.SQLite";
        }

        public bool Pooling
        {
            get { return _Pooling; }
            set { _Pooling = value; }
        }
        public string password { get; set; }


        //�����ַ����ο�
        //string strCon = "Datasource=Test.db3;Pooling=true;FailIfMissing=false";
        //"NorthwindEF (SQLite)" connectionString="provider=System.Data.SQLite;metadata=Schemas\NorthwindEFModel.csdl|Schemas\NorthwindEFModel.msl|Schemas\NorthwindEFModel.SQLite.ssdl;Provider Connection String='Data Source=DB\northwindEF.db'"
        public string GetConnectionStr()
        {
            return String.Format("Data Source={0};Pooling=true;password={1}", DataSource, password);
        }


        /*
Basic�������ģ�
    Data Source=filename;Version=3;
Using UTF16��ʹ��UTF16���룩
    Data Source=filename;Version=3;UseUTF16Encoding=True;
With password��������ģ�
    Data Source=filename;Version=3;Password=myPassword;
Using the pre 3.3x database format��ʹ��3.3xǰ���ݿ��ʽ��
    Data Source=filename;Version=3;Legacy Format=True;
Read only connection��ֻ�����ӣ�
    Data Source=filename;Version=3;Read Only=True;
With connection pooling���������ӳأ�
    Data Source=filename;Version=3;Pooling=False;Max Pool Size=100;
Using DateTime.Ticks as datetime format����
    Data Source=filename;Version=3;DateTimeFormat=Ticks;

Store GUID as text����Guid��Ϊ�ı��洢��Ĭ����Binary��
    Data Source=filename;Version=3;BinaryGUID=False;
�����Guid��Ϊ�ı��洢��Ҫ����Ĵ洢�ռ�

Specify cache size��ָ��Cache��С��
    Data Source=filename;Version=3;Cache Size=2000;

    Cache Size ��λ���ֽ�

Specify page size��ָ��ҳ��С��
    Data Source=filename;Version=3;Page Size=1024;
    Page Size ��λ���ֽ�

Disable enlistment in distributed transactions
    Data Source=filename;Version=3;Enlist=N;
Disable create database behaviour�����ô������ݿ���Ϊ��
    Data Source=filename;Version=3;FailIfMissing=True;

Ĭ������£�������ݿ��ļ������ڣ����Զ�����һ���µģ�ʹ����������������ᴴ���������׳��쳣��Ϣ

Limit the size of database���������ݿ��С��
    Data Source=filename;Version=3;Max Page Count=5000;
    The Max Page Count is measured in pages. This parameter limits the maximum number of pages of the database.
Disable the Journal File ��������־�ع���
    Data Source=filename;Version=3;Journal Mode=Off;
    This one disables the rollback journal entirely.

Persist the Journal File���־ã�
    Data Source=filename;Version=3;Journal Mode=Persist;


��������Sqlite���ݿ⣺
    Data Source=mydb.db;Version=3;
    --"Version" �Ŀ���ֵ�� "2�� ָ SQLite 2.x (default)��"3�� ָ SQLite 3.x


����ͬʱ����һ���µ�Sqlite���ݿ⣺
    Data Source=mydb.db;Version=3;New=True;

����ѹ������Sqlite���ݿ⣺
    Data Source=mydb.db;Version=3;Compress=True;

ָ������Sqlite���ݿ�Ļ����С��
    Data Source=mydb.db;Version=3;Cache Size=3000;
*/
    }
}
