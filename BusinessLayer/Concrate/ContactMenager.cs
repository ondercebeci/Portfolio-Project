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
   public class ContactMenager:IContactService
    {
        IContactDal _contactDal;

        public ContactMenager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public List<Contact> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
