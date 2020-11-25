using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P2k7.Core.Behavior
{
	// Token: 0x02000096 RID: 150
	public class cls_CM_ComboItem : IComparable
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00027EE4 File Offset: 0x000260E4
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00027EFC File Offset: 0x000260FC
		public object Value
		{
			get
			{
				return this.mvObj_Value;
			}
			set
			{
				this.mvObj_Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00027F0C File Offset: 0x0002610C
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00027F24 File Offset: 0x00026124
		public string Text
		{
			get
			{
				return this.mvStr_Text;
			}
			set
			{
				this.mvStr_Text = value;
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00027F2E File Offset: 0x0002612E
		public cls_CM_ComboItem()
		{
			this.mvObj_Value = null;
			this.mvStr_Text = string.Empty;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00027F4A File Offset: 0x0002614A
		public cls_CM_ComboItem(object Item, string Name)
		{
			this.mvObj_Value = RuntimeHelpers.GetObjectValue(Item);
			this.mvStr_Text = Name;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00027F68 File Offset: 0x00026168
		public override string ToString()
		{
			return this.Text;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00027F80 File Offset: 0x00026180
		public int CompareTo(object obj)
		{
			return Comparer.Default.Compare(this.ToString(), obj.ToString());
		}

		// Token: 0x0400043F RID: 1087
		private object mvObj_Value;

		// Token: 0x04000440 RID: 1088
		private string mvStr_Text;
	}
}
