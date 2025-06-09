using Microsoft.AspNetCore.Mvc;
using QuotaManager.DTOs;

namespace QuotaManager.Controllers;

[ApiController]
[Route("api/v1/vm/quota")]
public class VmQuotaControllerV1 : ControllerBase
{
    private readonly ILogger _logger;

    public VmQuotaControllerV1(ILogger<VmQuotaControllerV1> logger)
    {
        _logger = logger;
    }

    [HttpPost("requests")]
    public async Task<VmQuotaRequestResult> RequestQuotaAsync([FromBody] VmQuotaRequest request, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("requests/{receipt}")]
    public async Task ReturnQuotaAsync(string receipt, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    [HttpGet("requests")]
    public async Task<IEnumerable<VmQuotaRequestResult>> GetRequests(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    [HttpGet("requests/{receipt}")]
    public async Task<VmQuotaRequestResult> GetRequest(string receipt, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}
