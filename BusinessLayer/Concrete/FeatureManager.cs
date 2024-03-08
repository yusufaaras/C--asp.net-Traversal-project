using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public void TAdd(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature2 t)
        {
            throw new NotImplementedException();
        }

        public Feature2 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature2 t)
        {
            throw new NotImplementedException();
        }

        List<Feature2> IGenericService<Feature2>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
