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
    public class FeatureMenager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureMenager(IFeatureDal featureDal
            )
        {
            _featureDal = featureDal;
        }

        public Feature GetByID(int id)
        {
           return _featureDal.GetByID(id);
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
