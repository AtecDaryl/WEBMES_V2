using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WEBMES_V2.Models.DomainModels.PlasmaMagazine;

namespace WEBMES_V2.Models.DTO.PlasmaMagazineDTO
{
    public class Trn_InsertMachineDTO
    {
          public int? Id { get; set; }
            public int? TrnTransactionId { get; set; }
        
            public int? StageId { get; set; }
        
            public string? MachineId { get; set; }
        
            public DateTime? TrackOutDateTime { get; set; }

    }
}