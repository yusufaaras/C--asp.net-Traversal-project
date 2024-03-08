using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetList()
        {
            return _guideDal.GetList();
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TChangeToFalseByGuide(int id)
        {
            _guideDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }
        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
