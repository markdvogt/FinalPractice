using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public interface IFinalPracticeRepository
    {
        IQueryable<FormResponse> MyTable { get; }

        public void Save(FormResponse fr);

        public void Create(FormResponse fr);

        public void Delete(FormResponse fr);
    }
}
