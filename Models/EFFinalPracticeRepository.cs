using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public class EFFinalPracticeRepository : IFinalPracticeRepository
    {
        private ApplicationContext context { get; set; }

        public EFFinalPracticeRepository (ApplicationContext temp)
        {
            context = temp;
        }

        public IQueryable<FormResponse> MyTable => context.MyTable;

        public void Save(FormResponse fr)
        {
            context.SaveChanges();
        }

        public void Create(FormResponse fr)
        {
            context.Add(fr);
            context.SaveChanges();
        }

        public void Delete(FormResponse fr)
        {
            context.Remove(fr);
            context.SaveChanges();
        }
    }
}
