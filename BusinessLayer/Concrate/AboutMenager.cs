using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutMenager : IAboutService
    {
        IAboutDal  _aboutDal;
        

        public AboutMenager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

     

        public About GetByID(int id)
        {
           return _aboutDal.GetByID(id);
            
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TGetList()
        {
          return  _aboutDal.GetList();
            
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
