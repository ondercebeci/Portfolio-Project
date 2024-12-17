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
    public class AnnouncementMenager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementMenager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public Announcement GetByID(int id)
        {
            return _announcementDal.GetByID(id);
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
