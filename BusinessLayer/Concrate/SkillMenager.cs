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
   public class SkillMenager:ISkillService
    {
        ISkillDal _skillDal;

        public SkillMenager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public Skill GetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public List<Skill> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
