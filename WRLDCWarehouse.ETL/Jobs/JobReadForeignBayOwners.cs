﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WRLDCWarehouse.Data;
using WRLDCWarehouse.Core.Entities;
using WRLDCWarehouse.ETL.Extracts;
using WRLDCWarehouse.ETL.Loads;
using WRLDCWarehouse.ETL.Enums;
using Microsoft.Extensions.Logging;
using WRLDCWarehouse.Core.ForiegnEntities;

namespace WRLDCWarehouse.ETL.Jobs
{
    public class JobReadForeignBayOwners
    {
        public async Task ImportForeignBayOwners(WRLDCWarehouseDbContext _context, ILogger _log, string oracleConnStr, EntityWriteOption opt)
        {
            BayOwnerExtract bayOwnerExtract = new BayOwnerExtract();
            List<BayOwnerForeign> bayOwnersForeign = bayOwnerExtract.ExtractBayOwnersForeign(oracleConnStr);

            LoadBayOwner loadBayOwner = new LoadBayOwner();
            foreach (BayOwnerForeign bayOwnerForeign in bayOwnersForeign)
            {
                BayOwner insertedBayOwner = await loadBayOwner.LoadSingleAsync(_context, _log, bayOwnerForeign, opt);
            }
        }
    }
}
