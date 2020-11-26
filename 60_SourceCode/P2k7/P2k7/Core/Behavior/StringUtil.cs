using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior
{
// Token: 0x02000169 RID: 361
	public class StringUtil
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x00099798 File Offset: 0x00097998
		public static string fncTrim(string value)
		{
			try
			{
				bool flag = value != null;
				if (flag)
				{
					value = value.Trim();
					value = ("".Equals(value) ? null : value);
				}
			}
			catch (Exception ex)
			{
				value = null;
			}
			return value;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000997F8 File Offset: 0x000979F8
		public static string fncRemoveLastOf(string value, string removeString)
		{
			bool flag = true;
			bool flag2 = removeString == null || removeString.Length == 0;
			if (flag2)
			{
				flag = false;
			}
			while (flag)
			{
				bool flag3 = value != null && value.Length != 0;
				if (flag3)
				{
					int num = value.LastIndexOf(removeString);
					bool flag4 = num == -1 || checked(num + removeString.Length) != value.Length;
					if (flag4)
					{
						flag = false;
					}
					else
					{
						value = value.Substring(0, num);
					}
				}
				else
				{
					flag = false;
				}
			}
			return value;
		}
	}
}
