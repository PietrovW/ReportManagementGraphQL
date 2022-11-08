using ReportManagementGraphQL.Data.Entity;

namespace ReportManagementGraphQL.Payloads;

public record UserPayload(User? record, string? error = null);