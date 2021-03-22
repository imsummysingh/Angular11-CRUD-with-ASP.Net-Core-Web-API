using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext :DbContext
    {
        //constructor for DBCOntext
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {

        }

        //property for PaymentDetail
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
