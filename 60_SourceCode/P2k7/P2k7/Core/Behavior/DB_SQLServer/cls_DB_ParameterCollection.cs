using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior
{
// Token: 0x0200000A RID: 10
	public class cls_DB_ParameterCollection
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002F21 File Offset: 0x00001121
		public cls_DB_ParameterCollection()
		{
			this.mvArr_Params = new ArrayList();
		}

		// Token: 0x17000016 RID: 22
		public SqlParameter this[string iStr_ParamName]
		{
			get
			{
				return this.GetParamByName(iStr_ParamName);
			}
		}

		// Token: 0x17000017 RID: 23
		public SqlParameter this[int iInt_Index]
		{
			get
			{
				bool flag = iInt_Index >= this.mvArr_Params.Count;
				SqlParameter result;
				if (flag)
				{
					result = null;
				}
				else
				{
					SqlParameter sqlParameter = (SqlParameter)this.mvArr_Params[iInt_Index];
					result = sqlParameter;
				}
				return result;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002F94 File Offset: 0x00001194
		public int Count
		{
			get
			{
				return this.mvArr_Params.Count;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FB4 File Offset: 0x000011B4
		private SqlParameter GetParamByName(string iStr_ParamName)
		{
			SqlParameter sqlParameter = null;
			bool flag = false;
			checked
			{
				int num = this.mvArr_Params.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					sqlParameter = (SqlParameter)this.mvArr_Params[i];
					bool flag2 = Operators.CompareString(sqlParameter.ParameterName, iStr_ParamName, false) == 0;
					if (flag2)
					{
						flag = true;
						break;
					}
				}
				bool flag3 = !flag;
				SqlParameter result;
				if (flag3)
				{
					result = null;
				}
				else
				{
					result = sqlParameter;
				}
				return result;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003024 File Offset: 0x00001224
		public SqlParameter Add(SqlParameter iObj_Param)
		{
			this.mvArr_Params.Add(iObj_Param);
			return iObj_Param;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003044 File Offset: 0x00001244
		public void Remove(SqlParameter iObj_Param)
		{
			bool flag = this.mvArr_Params.Contains(iObj_Param);
			if (flag)
			{
				this.mvArr_Params.Remove(iObj_Param);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003074 File Offset: 0x00001274
		public void Remove(string iStr_ParamName)
		{
			SqlParameter paramByName = this.GetParamByName(iStr_ParamName);
			bool flag = paramByName != null;
			if (flag)
			{
				this.Remove(paramByName);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000309C File Offset: 0x0000129C
		public void Remove(int iInt_Index)
		{
			bool flag = iInt_Index >= this.mvArr_Params.Count;
			if (!flag)
			{
				this.mvArr_Params.RemoveAt(iInt_Index);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000030CF File Offset: 0x000012CF
		public void Clear()
		{
			this.mvArr_Params.Clear();
		}

		// Token: 0x04000013 RID: 19
		private ArrayList mvArr_Params;
	}
}
