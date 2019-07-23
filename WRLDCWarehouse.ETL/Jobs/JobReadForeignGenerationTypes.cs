﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WRLDCWarehouse.Data;
using WRLDCWarehouse.Core.Entities;
using WRLDCWarehouse.ETL.Extracts;
using WRLDCWarehouse.ETL.Loads;
using WRLDCWarehouse.ETL.Enums;

namespace WRLDCWarehouse.ETL.Jobs
{
    public class JobReadForeignGenerationTypes
    {
        public async Task ImportForeignGenerationTypes(WRLDCWarehouseDbContext _context, string oracleConnStr, EntityWriteOption opt)
        {
            GenerationTypeExtract genTypeExtract = new GenerationTypeExtract();
            List<GenerationType> genTypes = genTypeExtract.ExtractGenTypes(oracleConnStr);

            LoadGenerationType loadGenType = new LoadGenerationType();
            foreach (GenerationType genType in genTypes)
            {
                GenerationType insertedGenType = await loadGenType.LoadSingleAsync(_context, genType, opt);
            }
        }
    }
}
