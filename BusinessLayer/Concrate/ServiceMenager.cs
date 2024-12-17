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
   public class ServiceMenager:IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceMenager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public Service GetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
