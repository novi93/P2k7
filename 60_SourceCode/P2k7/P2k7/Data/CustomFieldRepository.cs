using P2k7.LookuptableWebSvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P2k7.Data
{
    public class CustomFieldRepository : PsiRepository
    {
        public CustomFieldRepository(MySettings mySettings) : base(mySettings)
        {
        }

        public List<LookupTableDataSet.LookupTableTreesRow> ReadTaskClass()
        {
            var lookuptableDS = lookupTable.ReadLookupTables("", false, 0);

            var taskClassTypeUID = ReadTaskClassLookUpUID();

            var rs = ((LookupTableDataSet.LookupTableTreesRow[])lookuptableDS
                .LookupTableTrees
                .Select($"{lookuptableDS.LookupTableTrees.LT_UIDColumn.ColumnName} = '{taskClassTypeUID}'")
                ).ToList();

            return rs;
        }
        
        public LookupTableDataSet.LookupTableTreesRow ReadTaskClass(string TaskClassName)
        {
            var lookuptableDS = lookupTable.ReadLookupTables("", false, 0);

            var taskClassTypeUID = ReadTaskClassLookUpUID();

            var rs = ((LookupTableDataSet.LookupTableTreesRow[])lookuptableDS.LookupTableTrees
                .Select($"{lookuptableDS.LookupTableTrees.LT_UIDColumn.ColumnName} = '{taskClassTypeUID}' AND {lookuptableDS.LookupTableTrees.LT_VALUE_TEXTColumn.ColumnName} = '{TaskClassName}'")
                ).FirstOrDefault();

            return rs;
        }

        public Guid ReadTaskClassLookUpUID()
        {
            var lookuptableDS = lookupTable.ReadLookupTables("", false, 0);

            var tskTypeList = (LookupTableDataSet.LookupTablesRow[])lookuptableDS.LookupTables
                .Select($"{lookuptableDS.LookupTables.LT_NAMEColumn.ColumnName} = '{"TaskClass"}'");

            if (tskTypeList == null || tskTypeList.Length == 0)
            {
                return Guid.Empty;
            }

            var taskClassTypeUID = tskTypeList[0].LT_UID; // fc96f7f7-9964-4bca-a072-32c42f469c4d

            return taskClassTypeUID;
        }
    }
}
