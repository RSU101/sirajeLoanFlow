using LoanFlow.Api.Models;
using LoanFlow.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoanFlow.Api.Controllers;

/// <summary>
/// Exposes a single POST endpoint that evaluates a loan request.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class LoanController : ControllerBase
{
    private readonly ILoanProcessor _processor;

    public LoanController(ILoanProcessor processor)
    {
        _processor = processor;
    }

    /// <summary>
    /// Submit a loan request and receive an approval decision.
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    /// POST /api/loan
    /// {
    ///   "borrowerId": "A12345",
    ///   "amount": 25000,
    ///   "termMonths": 36,
    ///   "annualInterestRate": 6.5
    /// }
    /// </remarks>
    [HttpPost]
    public ActionResult<LoanResult> Evaluate([FromBody] LoanRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = _processor.Process(request);
        return Ok(result);
    }
}