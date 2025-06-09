using System.ComponentModel.DataAnnotations;

namespace QuotaManager.DTOs;

public class VmQuotaRequestResult
{
    [Required]
    public VmQuotaRequest Request { get; set; } = default!;

    public int CoresLimit { get; set; }

    public int CoresInUse { get; set; }

    public int CoresPerVm { get; set; }

    public int RequestedCores { get; set; }

    public int ApprovedCores { get; set; }

    public string? Receipt { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}
