using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tutorial.PhoneBook.Domain.Entities;

public partial class PhoneNumberTypes
{
    [Key]
    public Guid Id { get; set; }

    public string Title { get; set; }

    [InverseProperty("PhoneNumberType")]
    public virtual ICollection<PhoneNumbers> PhoneNumbers { get; } = new List<PhoneNumbers>();
}
