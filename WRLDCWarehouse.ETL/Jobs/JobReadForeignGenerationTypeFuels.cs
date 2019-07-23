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
    public class JobReadForeignGenerationTypeFuels
    {
        public async Task ImportForeignGenerationTypeFuels(WRLDCWarehouseDbContext _context, string oracleConnStr, EntityWriteOption opt)
        {
            GenTypeFuelExtract genTypeFuelExtract = new GenTypeFuelExtract();
            List<GenerationTypeFuelForeign> genTypeFuelsForeign = genTypeFuelExtract.ExtractGenerationTypeFuelsForeign(oracleConnStr);

            LoadGenerationTypeFuel loadGenTypeFuel = new LoadGenerationTypeFuel();
            foreach (GenerationTypeFuelForeign genTypeFuelForeign in genTypeFuelsForeign)
            {
                GenerationTypeFuel insertedGenTypeFuel = await loadGenTypeFuel.LoadSingleAsync(_context, genTypeFuelForeign, opt);
            }
        }
    }
}
