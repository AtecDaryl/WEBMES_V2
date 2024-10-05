using System;
using System.Collections.Generic;

namespace WEBMES_V2.Models.DomainModels.PlasmaMagazine;

public partial class TrnMachinePerStage
{
    public int Id { get; set; }

    public int? TrnTransactionId { get; set; }

    public int? StageId { get; set; }

    public string? MachineId { get; set; }

    public DateTime? TrackOutDateTime { get; set; }
}
