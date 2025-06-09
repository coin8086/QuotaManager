using System.ComponentModel.DataAnnotations;

namespace QuotaManager.DTOs;

public class VmQuotaRequest
{
    [Required]
    public string Location { get; set; } = default!;

    [Required]
    public string VmSize { get; set; } = default!;

    [Range(0, int.MaxValue)]
    public int RequestedVms { get; set; }

    public bool AcceptPartialApproval { get; set; } = false;
}
