using Core.Common.Contracts;
using Core.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Data_Repositories
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, CarRentalContext>
        where T : class, IIdentifiableEntity, new()
    {
        
    }
}
