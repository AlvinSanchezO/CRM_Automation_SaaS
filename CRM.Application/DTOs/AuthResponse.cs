namespace CRM.Application.DTOs;
public record AuthResponse(string Token, string Email, string FullName);