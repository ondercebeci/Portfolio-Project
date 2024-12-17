using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
   public  class ExperienceMenager: IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceMenager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public Experience GetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public List<Experience> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
