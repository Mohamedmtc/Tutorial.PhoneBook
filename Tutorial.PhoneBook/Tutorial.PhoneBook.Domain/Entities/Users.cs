using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tutorial.PhoneBook.Domain.Entities;

public partial class Users
{
    [Key]
    public Guid Id { get; set; }

    public string RealName { get; set; }

    public string Email { get; set; }

    public string UserName { get; set; }

    public string Salt { get; set; }

    public string Password { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<PhoneNumbers> PhoneNumbers { get; } = new List<PhoneNumbers>();
}
