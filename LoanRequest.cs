namespace LoanFlow.Api.Models;

/// <summary>
/// The data that a borrower sends to request a loan.
/// </summary>
public class LoanRequest
{
    /// <summary>Unique borrower identifier (e.g. SSN, employee‑ID, …)</summary>
    public string BorrowerId { get; set; } = string.Empty;

    /// <summary>Requested principal amount (USD)</summary>
    public decimal Amount { get; set; }

    /// <summary>Number of months for repayment</summary>
    public int TermMonths { get; set; }

    /// <summary>Annual interest rate in percent (e.g. 7.5)</summary>
    public decimal AnnualInterestRate { get; set; }
}