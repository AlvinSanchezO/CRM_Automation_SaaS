using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CRM.Domain.Entities;

public class User : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string? CompanyName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Relación con los contactos (Un usuario tiene muchos contactos)
    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}