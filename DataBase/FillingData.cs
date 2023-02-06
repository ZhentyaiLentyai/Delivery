using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class FillingData
    {
        public static void Fill(EFDBContext context, Base @base) 
        {
            context.Base.Add(new Base()
            {
                SenderCity = @base.SenderCity,
                SenderAddress = @base.SenderAddress,
                RecipientCity = @base.RecipientCity,
                RecipientAddress = @base.RecipientAddress,
                Weight = @base.Weight,
                Date = @base.Date,
            });
            context.SaveChanges();
        }
    }
}
