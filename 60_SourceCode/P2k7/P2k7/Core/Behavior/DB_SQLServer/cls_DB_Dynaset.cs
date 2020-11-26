using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace P2k7.Core.Behavior
{
    // Token: 0x02000009 RID: 9
    public class cls_DB_Dynaset
    {
        // Token: 0x06000020 RID: 32 RVA: 0x0000284C File Offset: 0x00000A4C
        public cls_DB_Dynaset()
        {
            this.mvInt_ActionMode = 0;
            this.mvObj_DataSet = new DataSet();
            this.mvObj_DataTable = new DataTable();
            this.mvLng_Pos = 0L;
            this.mvInt_ColumnIndex = 0;
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00002884 File Offset: 0x00000A84
        private object Convert(object iObj_Value)
        {
            object result = RuntimeHelpers.GetObjectValue(iObj_Value);
            bool flag = Information.IsDBNull(RuntimeHelpers.GetObjectValue(iObj_Value));
            if (flag)
            {
                result = "";
            }
            return result;
        }

        // Token: 0x06000022 RID: 34 RVA: 0x000028B5 File Offset: 0x00000AB5
        public void Close()
        {
            this.mvObj_DataSet = null;
            this.mvObj_DataTable = null;
        }

        // Token: 0x06000023 RID: 35 RVA: 0x000028C8 File Offset: 0x00000AC8
        public void MoveNext()
        {
            long num = this.RecordCount();
            ref long ptr = ref this.mvLng_Pos;
            checked
            {
                this.mvLng_Pos = ptr + 1L;
                bool flag = this.mvLng_Pos > num;
                if (flag)
                {
                    this.mvLng_Pos = num - 1L;
                }
                bool flag2 = this.mvLng_Pos < 0L;
                if (flag2)
                {
                    this.mvLng_Pos = 0L;
                }
            }
        }

        // Token: 0x06000024 RID: 36 RVA: 0x0000291C File Offset: 0x00000B1C
        public void MoveFirst()
        {
            this.mvLng_Pos = 0L;
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00002928 File Offset: 0x00000B28
        public void MoveLast()
        {
            this.mvLng_Pos = checked(this.RecordCount() - 1L);
            bool flag = this.mvLng_Pos < 0L;
            if (flag)
            {
                this.mvLng_Pos = 0L;
            }
        }

        // Token: 0x06000026 RID: 38 RVA: 0x00002960 File Offset: 0x00000B60
        public long RecordCount()
        {
            long result = 0L;
            bool flag = this.mvObj_DataSet != null;
            if (flag)
            {
                this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                bool flag2 = this.mvObj_DataTable != null;
                if (flag2)
                {
                    this.mvObj_DataRowCollection = this.mvObj_DataTable.Rows;
                    result = (long)this.mvObj_DataRowCollection.Count;
                }
            }
            return result;
        }

        //// Token: 0x06000027 RID: 39 RVA: 0x000029CC File Offset: 0x00000BCC
        //public long EOF()
        //{
        //    bool flag = this.mvLng_Pos < 0L;
        //    if (flag)
        //    {
        //        this.mvLng_Pos = 0L;
        //    }
        //    return (-(((this.mvLng_Pos == this.RecordCount()) > false) ? 1L : 0L)) ? 1L : 0L;
        //}

        // Token: 0x06000028 RID: 40 RVA: 0x00002A0C File Offset: 0x00000C0C
        public void AddNew()
        {
            bool flag = this.mvInt_ActionMode == 0;
            if (flag)
            {
                bool flag2 = this.mvObj_DataSet != null;
                if (flag2)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag3 = this.mvObj_DataTable != null;
                    if (flag3)
                    {
                        this.mvObj_DataTable.Rows.Add(this.mvObj_DataTable.NewRow());
                        this.mvLng_Pos = (long)(checked(this.mvObj_DataTable.Rows.Count - 1));
                        this.mvInt_ActionMode = 1;
                    }
                }
            }
        }

        // Token: 0x06000029 RID: 41 RVA: 0x00002A9C File Offset: 0x00000C9C
        public void Edit()
        {
            bool flag = this.mvObj_DataSet != null;
            if (flag)
            {
                this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                this.mvInt_ActionMode = 2;
            }
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00002AD8 File Offset: 0x00000CD8
        public void Delete()
        {
            bool flag = this.mvObj_DataSet != null;
            checked
            {
                if (flag)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag2 = this.mvObj_DataTable != null;
                    if (flag2)
                    {
                        this.mvObj_DataTable.Rows[(int)this.mvLng_Pos].Delete();
                        this.Update();
                        ref long ptr = ref this.mvLng_Pos;
                        this.mvLng_Pos = ptr - 1L;
                    }
                }
            }
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00002B50 File Offset: 0x00000D50
        public void Update()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = this.mvObj_Command;
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(this.mvObj_DataSet);
            this.mvInt_ActionMode = 0;
        }

        //// Token: 0x1700000C RID: 12
        //[IndexerName("Items")]
        //public object this[int iInt_Index]
        //{
        //    get
        //    {
        //        return this.get_Fields(iInt_Index);
        //    }
        //}

        //// Token: 0x1700000D RID: 13
        //[IndexerName("Items")]
        //public object this[string iStr_Name]
        //{
        //    get
        //    {
        //        return this.get_Fields(iStr_Name);
        //    }
        //}

        //// Token: 0x1700000E RID: 14
        //// (get) Token: 0x0600002E RID: 46 RVA: 0x00002BC4 File Offset: 0x00000DC4
        //// (set) Token: 0x0600002F RID: 47 RVA: 0x00002C88 File Offset: 0x00000E88
        //public object Value
        //{
        //    get
        //    {
        //        object result = null;
        //        bool flag = this.mvObj_DataSet != null;
        //        if (flag)
        //        {
        //            this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
        //            bool flag2 = this.mvObj_DataTable != null;
        //            if (flag2)
        //            {
        //                this.mvObj_DataRowCollection = this.mvObj_DataTable.Rows;
        //                bool flag3 = this.mvObj_DataRowCollection.Count > 0;
        //                if (flag3)
        //                {
        //                    DataRow dataRow = this.mvObj_DataRowCollection[checked((int)this.mvLng_Pos)];
        //                    if (iBln_Convert)
        //                    {
        //                        result = RuntimeHelpers.GetObjectValue(this.Convert(RuntimeHelpers.GetObjectValue(dataRow[this.mvInt_ColumnIndex])));
        //                    }
        //                    else
        //                    {
        //                        result = RuntimeHelpers.GetObjectValue(dataRow[this.mvInt_ColumnIndex]);
        //                    }
        //                }
        //            }
        //        }
        //        return result;
        //    }
        //    set
        //    {
        //        bool flag = this.mvObj_DataSet != null;
        //        if (flag)
        //        {
        //            this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
        //            bool flag2 = this.mvObj_DataTable != null;
        //            if (flag2)
        //            {
        //                this.mvObj_DataRowCollection = this.mvObj_DataTable.Rows;
        //                DataRow dataRow = this.mvObj_DataRowCollection[checked((int)this.mvLng_Pos)];
        //                dataRow[this.mvInt_ColumnIndex] = RuntimeHelpers.GetObjectValue(value);
        //            }
        //        }
        //    }
        //}

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x06000030 RID: 48 RVA: 0x00002D04 File Offset: 0x00000F04
        // (set) Token: 0x06000031 RID: 49 RVA: 0x00002D6C File Offset: 0x00000F6C
        public object Name
        {
            get
            {
                object result = null;
                bool flag = this.mvObj_DataSet != null;
                if (flag)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag2 = this.mvObj_DataTable != null;
                    if (flag2)
                    {
                        result = this.mvObj_DataTable.Columns[this.mvInt_ColumnIndex].ColumnName;
                    }
                }
                return result;
            }
            set
            {
                bool flag = this.mvObj_DataSet != null;
                if (flag)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag2 = this.mvObj_DataTable != null;
                    if (flag2)
                    {
                        this.mvObj_DataTable.Columns[this.mvInt_ColumnIndex].ColumnName = Conversions.ToString(value);
                    }
                }
            }
        }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x06000032 RID: 50 RVA: 0x00002DD4 File Offset: 0x00000FD4
        public object Type
        {
            get
            {
                object result = null;
                bool flag = this.mvObj_DataSet != null;
                if (flag)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag2 = this.mvObj_DataTable != null;
                    if (flag2)
                    {
                        result = this.mvObj_DataTable.Columns[this.mvInt_ColumnIndex].DataType.Name;
                    }
                }
                return result;
            }
        }

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x06000033 RID: 51 RVA: 0x00002E40 File Offset: 0x00001040
        public DataColumnCollection Fields
        {
            get
            {
                DataColumnCollection result = null;
                bool flag = this.mvObj_DataSet != null;
                if (flag)
                {
                    this.mvObj_DataTable = this.mvObj_DataSet.Tables[0];
                    bool flag2 = this.mvObj_DataTable != null;
                    if (flag2)
                    {
                        result = this.mvObj_DataTable.Columns;
                    }
                }
                return result;
            }
        }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x06000034 RID: 52 RVA: 0x00002E98 File Offset: 0x00001098
        // (set) Token: 0x06000035 RID: 53 RVA: 0x00002EB0 File Offset: 0x000010B0
        public DataSet Dynaset
        {
            get
            {
                return this.mvObj_DataSet;
            }
            set
            {
                this.mvObj_DataSet = value;
            }
        }

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x06000036 RID: 54 RVA: 0x00002EBC File Offset: 0x000010BC
        // (set) Token: 0x06000037 RID: 55 RVA: 0x00002ED4 File Offset: 0x000010D4
        public SqlCommand SqlCommand
        {
            get
            {
                return this.mvObj_Command;
            }
            set
            {
                this.mvObj_Command = value;
            }
        }

        //// Token: 0x17000014 RID: 20
        //// (get) Token: 0x06000038 RID: 56 RVA: 0x00002EE0 File Offset: 0x000010E0
        //public int Fields
        //{
        //    get
        //    {
        //        this.mvInt_ColumnIndex = iInt_Index;
        //        return this;
        //    }
        //}

        //// Token: 0x17000015 RID: 21
        //// (get) Token: 0x06000039 RID: 57 RVA: 0x00002EFC File Offset: 0x000010FC
        //public string Fields
        //{
        //    get
        //    {
        //        this.mvInt_ColumnIndex = this.Fields.IndexOf(iStr_Name);
        //        return this;
        //    }
        //}

        // Token: 0x0400000C RID: 12
        private DataSet mvObj_DataSet;

        // Token: 0x0400000D RID: 13
        private DataTable mvObj_DataTable;

        // Token: 0x0400000E RID: 14
        private DataRowCollection mvObj_DataRowCollection;

        // Token: 0x0400000F RID: 15
        private SqlCommand mvObj_Command;

        // Token: 0x04000010 RID: 16
        private long mvLng_Pos;

        // Token: 0x04000011 RID: 17
        private int mvInt_ColumnIndex;

        // Token: 0x04000012 RID: 18
        private int mvInt_ActionMode;
    }
}
