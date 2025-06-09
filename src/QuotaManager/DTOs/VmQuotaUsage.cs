using System.ComponentModel.DataAnnotations;

namespace QuotaManager.DTOs;

public class VmQuotaUsage
{
    [Required]
    public string Location { get; set; } = default!;

    [Required]
    public string VmSize { get; set; } = default!;

    public int CoresPerVm { get; set; }

    public int CoresInUse { get; set; }

    public int CoresLimit { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}
