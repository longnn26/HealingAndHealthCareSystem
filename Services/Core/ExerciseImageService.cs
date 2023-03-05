using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.DataAccess;
using AutoMapper;
using Data.DataAccess.Constant;

namespace Services.Core
{
    public interface IExerciseImageService
    {
        ResultModel Add(ExerciseImageCreateModel model);
        ResultModel Update(ExerciseImageUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);


    }
    public class ExerciseImageService : IExerciseImageService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;

        public ExerciseImageService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(ExerciseImageCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<ExerciseImageCreateModel, Data.Entities.ExerciseImage>(model);
                _dbContext.ExerciseImage.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.ExerciseImage, ExerciseImageModel>(data);
                result.Succeed = true;

            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ResultModel Get(Guid? id)
        {
            throw new NotImplementedException();
        }

        /* public ResultModel Delete(Guid id)
         {
             ResultModel result = new ResultModel();
             try
             {
                 var data = _dbContext.ExerciseVideo.Where(s => s.id == id).FirstOrDefault();
                 if (data != null)
                 {

                     _dbContext.SaveChanges();
                     var view = _mapper.Map<Data.Entities.ExerciseVideo, ExerciseVideoModel>(data);
                     result.Data = view;
                     result.Succeed = true;
                 }
                 else
                 {
                     result.ErrorMessage = "Exercise Video" + ErrorMessage.ID_NOT_EXISTED;
                     result.Succeed = false;
                 }


             }
             catch (Exception e)
             {
                 result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
             }
             return result;
         }*/

        /*public ResultModel Get(Guid? id)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ExerciseImage.Where(s => s.id == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.ExerciseImage, ExerciseImageModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "Exercise Image" + ErrorMessage.ID_NOT_EXISTED;
                    result.Succeed = false;
                }


            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }*/

        public ResultModel GetAll()
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ExerciseImage;
                var view = _mapper.ProjectTo<ExerciseImageModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Update(ExerciseImageUpdateModel model)
        {
            throw new NotImplementedException();
        }
    }


}
