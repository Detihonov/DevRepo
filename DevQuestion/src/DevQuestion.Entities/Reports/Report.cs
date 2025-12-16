namespace DevQuestion.Entities.Reports;

public class Report
{
    public Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Guid ReportUserId { get; set; }
    public Guid? ResolvedByUserId { get; set; }
    public required string Reason { get; set; }
    public Status Status { get; set; } = Status.Open;
    public DateTime CreateAt { get; set; }
    public DateTime? UpdateAt { get; set; }
}