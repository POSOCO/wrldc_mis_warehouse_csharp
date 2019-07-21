﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WRLDCWarehouse.Data;
using WRLDCWarehouse.Core.Entities;
using WRLDCWarehouse.ETL.Extracts;
using WRLDCWarehouse.ETL.Loads;
using WRLDCWarehouse.ETL.Enums;
using WRLDCWarehouse.Core.ForiegnEntities;

namespace WRLDCWarehouse.ETL.Jobs
{
    public class JobReadForeignStates
    {
        public async Task ImportForeignStates(WRLDCWarehouseDbContext _context, string oracleConnStr, EntityWriteOption opt)
        {
            StateExtract stateExtract = new StateExtract();
            List<StateForeign> stateForeigns = stateExtract.ExtractStatesForeign(oracleConnStr);

            LoadState loadState = new LoadState();
            foreach (StateForeign stateForeign in stateForeigns)
            {
                State insertedRegion = await loadState.LoadSingleAsync(_context, stateForeign, opt);
            }
        }
    }
}
