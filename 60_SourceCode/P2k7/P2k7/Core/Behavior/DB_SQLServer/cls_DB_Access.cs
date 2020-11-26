using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Fujinet.Common.Security.Encryption;

namespace P2k7.Core.Behavior.DB_SQLServer
{
    public class cls_DB_Access
    {
        // Token: 0x0600000F RID: 15 RVA: 0x000021B4 File Offset: 0x000003B4
        public cls_DB_Access(string iStr_ConnectionString, bool iBln_IsEncrypted)
        {
            string text = iStr_ConnectionString;
            if (iBln_IsEncrypted)
            {
                string[] array = iStr_ConnectionString.Split(new char[]
                {
                    ';'
                });
                Hashtable hashtable = new Hashtable();
                foreach (string text2 in array)
                {
                    bool flag = Operators.CompareString(text2, "", false) != 0;
                    if (flag)
                    {
                        string[] array3 = text2.Split(new char[]
                        {
                            '='
                        });
                        hashtable.Add(Strings.Trim(array3[0].ToUpper()), Strings.Trim(array3[1]));
                    }
                }
                cls_CM_Encryption cls_CM_Encryption = new cls_CM_Encryption();
                hashtable["SERVER"] = cls_CM_Encryption.fncEncrypt(Conversions.ToString(hashtable["SERVER"]));
                hashtable["DATABASE"] = cls_CM_Encryption.fncEncrypt(Conversions.ToString(hashtable["DATABASE"]));
                hashtable["UID"] = cls_CM_Encryption.fncEncrypt(Conversions.ToString(hashtable["UID"]));
                hashtable["PWD"] = cls_CM_Encryption.fncEncrypt(Conversions.ToString(hashtable["PWD"]));
                text = "";
                try
                {
                    foreach (object value in hashtable.Keys)
                    {
                        string text3 = Conversions.ToString(value);
                        text = Conversions.ToString(Operators.AddObject(text, Operators.AddObject(Operators.AddObject(text3 + "=", hashtable[text3]), ";")));
                    }
                }
                finally
                {
                    //IEnumerator enumerator;
                    //if (enumerator is IDisposable)
                    //{
                    //	(enumerator as IDisposable).Dispose();
                    //}
                    if (this is IDisposable)
                    {
                        (this as IDisposable).Dispose();
                    }
                }
            }
            this.mvObj_Params = new cls_DB_ParameterCollection();
            this.mvObj_Connection = new SqlConnection(text);
            this.mvObj_Connection.Open();
        }

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000010 RID: 16 RVA: 0x000023AC File Offset: 0x000005AC
        public int LastServerErr
        {
            get
            {
                bool flag = this.mvObj_LastServerErr == null;
                int result;
                if (flag)
                {
                    result = 0;
                }
                else
                {
                    result = this.mvObj_LastServerErr.Number;
                }
                return result;
            }
        }

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000011 RID: 17 RVA: 0x000023DC File Offset: 0x000005DC
        public string LastServerErrText
        {
            get
            {
                string result = "";
                bool flag = this.mvObj_LastServerErr != null;
                if (flag)
                {
                    result = this.mvObj_LastServerErr.Message;
                }
                return result;
            }
        }

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000012 RID: 18 RVA: 0x00002410 File Offset: 0x00000610
        // (set) Token: 0x06000013 RID: 19 RVA: 0x00002428 File Offset: 0x00000628
        public cls_DB_ParameterCollection Parameters
        {
            get
            {
                return this.mvObj_Params;
            }
            set
            {
                this.mvObj_Params = value;
            }
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00002432 File Offset: 0x00000632
        public void LastServerErrReset()
        {
            this.mvObj_LastServerErr = null;
        }

        // Token: 0x06000015 RID: 21 RVA: 0x0000243C File Offset: 0x0000063C
        public DataSet DBCreateDataSet(string iStr_SQL)
        {
            SqlCommand selectCommand = null;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            DataSet dataSet = new DataSet();
            this.mvObj_LastServerErr = null;
            selectCommand = new SqlCommand(iStr_SQL, this.mvObj_Connection);
            this.FillParamIn(ref selectCommand);
            sqlDataAdapter.SelectCommand = selectCommand;
            sqlDataAdapter.Fill(dataSet);
            this.FillParamOut(ref selectCommand);
            return dataSet;
        }

        // Token: 0x06000016 RID: 22 RVA: 0x00002494 File Offset: 0x00000694
        public DataSet DBCreateDataSet(string iStr_SQL, string iStr_Name)
        {
            SqlCommand selectCommand = null;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            DataSet dataSet = new DataSet();
            this.mvObj_LastServerErr = null;
            selectCommand = new SqlCommand(iStr_SQL, this.mvObj_Connection);
            this.FillParamIn(ref selectCommand);
            sqlDataAdapter.SelectCommand = selectCommand;
            sqlDataAdapter.Fill(dataSet, iStr_Name);
            this.FillParamOut(ref selectCommand);
            return dataSet;
        }

        // Token: 0x06000017 RID: 23 RVA: 0x000024F0 File Offset: 0x000006F0
        public cls_DB_Dynaset DBCreateDynaset(string iStr_SQL, bool iBlnStoredProcedure = false, bool iBlnFunction = false)
        {
            cls_DB_Dynaset cls_DB_Dynaset = new cls_DB_Dynaset();
            SqlCommand sqlCommand = null;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            this.mvObj_LastServerErr = null;
            sqlCommand = new SqlCommand(iStr_SQL, this.mvObj_Connection);
            sqlCommand.CommandTimeout = 0;
            bool flag = !Information.IsNothing(this.mvObj_Transaction);
            if (flag)
            {
                sqlCommand.Transaction = this.mvObj_Transaction;
            }
            if (iBlnStoredProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            if (iBlnFunction)
            {
                sqlCommand.CommandType = CommandType.Text;
            }
            this.FillParamIn(ref sqlCommand);
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(cls_DB_Dynaset.Dynaset);
            this.FillParamOut(ref sqlCommand);
            cls_DB_Dynaset.SqlCommand = sqlCommand;
            return cls_DB_Dynaset;
        }

        // Token: 0x06000018 RID: 24 RVA: 0x000025A4 File Offset: 0x000007A4
        public long DBExecuteSQL(string iStr_SQL, bool iBlnStoreProcedure = false)
        {
            this.mvObj_LastServerErr = null;
            SqlCommand sqlCommand = new SqlCommand(iStr_SQL, this.mvObj_Connection);
            if (iBlnStoreProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            bool flag = !Information.IsNothing(this.mvObj_Transaction);
            if (flag)
            {
                sqlCommand.Transaction = this.mvObj_Transaction;
            }
            this.FillParamIn(ref sqlCommand);
            int num = sqlCommand.ExecuteNonQuery();
            this.FillParamOut(ref sqlCommand);
            return (long)num;
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00002618 File Offset: 0x00000818
        public long DBExecuteSQLReturnID(string iStr_SQL, bool iBlnStoreProcedure = false)
        {
            this.mvObj_LastServerErr = null;
            SqlCommand sqlCommand = new SqlCommand(iStr_SQL, this.mvObj_Connection);
            if (iBlnStoreProcedure)
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            bool flag = !Information.IsNothing(this.mvObj_Transaction);
            if (flag)
            {
                sqlCommand.Transaction = this.mvObj_Transaction;
            }
            this.FillParamIn(ref sqlCommand);
            int num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
            this.FillParamOut(ref sqlCommand);
            return (long)num;
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00002690 File Offset: 0x00000890
        public bool DBBeginTrans(IsolationLevel level = IsolationLevel.Serializable)
        {
            bool result = true;
            bool flag = this.mvObj_Connection.State == ConnectionState.Closed;
            if (flag)
            {
                this.mvObj_Connection.Open();
            }
            this.mvObj_Transaction = this.mvObj_Connection.BeginTransaction(level);
            return result;
        }

        // Token: 0x0600001B RID: 27 RVA: 0x000026D8 File Offset: 0x000008D8
        public void DBCommitTrans()
        {
            bool flag = this.mvObj_Transaction != null;
            if (flag)
            {
                this.mvObj_Transaction.Commit();
            }
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002704 File Offset: 0x00000904
        public void DBRollBack()
        {
            bool flag = this.mvObj_Transaction != null;
            if (flag)
            {
                this.mvObj_Transaction.Rollback();
            }
            this.mvObj_Transaction = null;
        }

        // Token: 0x0600001D RID: 29 RVA: 0x00002734 File Offset: 0x00000934
        public void DBClose()
        {
            bool flag = this.mvObj_Connection != null;
            if (flag)
            {
                bool flag2 = this.mvObj_Connection.State == ConnectionState.Open;
                if (flag2)
                {
                    this.mvObj_Connection.Close();
                }
                this.mvObj_Connection = null;
            }
            this.mvObj_Params = null;
            bool flag3 = this.mvObj_Transaction != null;
            if (flag3)
            {
                this.mvObj_Transaction = null;
            }
            this.mvObj_LastServerErr = null;
        }

        // Token: 0x0600001E RID: 30 RVA: 0x0000279C File Offset: 0x0000099C
        private void FillParamIn(ref SqlCommand oObj_Command)
        {
            bool flag = this.mvObj_Params != null;
            checked
            {
                if (flag)
                {
                    int num = this.mvObj_Params.Count - 1;
                    for (int i = 0; i <= num; i++)
                    {
                        oObj_Command.Parameters.Add(this.mvObj_Params[i]);
                    }
                }
            }
        }

        // Token: 0x0600001F RID: 31 RVA: 0x000027EC File Offset: 0x000009EC
        private void FillParamOut(ref SqlCommand oObj_Command)
        {
            bool flag = this.mvObj_Params != null;
            checked
            {
                if (flag)
                {
                    int num = this.mvObj_Params.Count - 1;
                    for (int i = 0; i <= num; i++)
                    {
                        this.mvObj_Params[i].Value = RuntimeHelpers.GetObjectValue(oObj_Command.Parameters[i].Value);
                    }
                }
            }
        }

        // Token: 0x04000008 RID: 8
        private cls_DB_ParameterCollection mvObj_Params;

        // Token: 0x04000009 RID: 9
        private SqlConnection mvObj_Connection;

        // Token: 0x0400000A RID: 10
        private SqlTransaction mvObj_Transaction;

        // Token: 0x0400000B RID: 11
        private SqlException mvObj_LastServerErr;
    } // cls
} //ns
