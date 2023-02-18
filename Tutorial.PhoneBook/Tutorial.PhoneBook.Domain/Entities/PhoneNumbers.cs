using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tutorial.PhoneBook.Domain.Entities;

[Index("PhoneNumberTypeId", Name = "IX_PhoneNumbers_PhoneNumberTypeId")]
[Index("UserId", Name = "IX_PhoneNumbers_UserId")]
public partial class PhoneNumbers
{
    [Key]
    public Guid Id { get; set; }

    public string Number { get; set; }

    public Guid? PhoneNumberTypeId { get; set; }

    public Guid? UserId { get; set; }

    [ForeignKey("PhoneNumberTypeId")]
    [InverseProperty("PhoneNumbers")]
    public virtual PhoneNumberTypes PhoneNumberType { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PhoneNumbers")]
    public virtual Users User { get; set; }
}
