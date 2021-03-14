using Core.Utilities.Results.DataResults;
using Core.Utilities.Results.VoidResults;
using Entities;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAllRentals();
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult Add(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
