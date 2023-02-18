using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Tutorial.PhoneBook.Domain.Entities;

namespace Tutorial.PhoneBook.Application.Contracts
{

    public interface IDataBaseService
    {
        DbSet<PhoneNumberTypes> PhoneNumberTypes { get; set; }

        DbSet<PhoneNumbers> PhoneNumbers { get; set; }

        DbSet<Users> Users { get; set; }
        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);

    }

}
