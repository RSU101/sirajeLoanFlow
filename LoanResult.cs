namespace LoanFlow.Api.Models;

/// <summary>
/// The response after a loan request has been evaluated.
/// </summary>
public class LoanResult
{
    public bool Approved { get; set; }
    public decimal MonthlyPayment { get; set; }
    public string? Reason { get; set; }   // null when approved
}