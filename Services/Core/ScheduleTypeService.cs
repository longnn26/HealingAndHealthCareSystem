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
    public interface IScheduleTypeService
    {
        ResultModel Add(ScheduleTypeCreateModel model);
        ResultModel Update(ScheduleTypeUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);


    }
    public class ScheduleTypeService : IScheduleTypeService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;

        public ScheduleTypeService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(ScheduleTypeCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<ScheduleTypeCreateModel, Data.Entities.ScheduleType>(model);
                _dbContext.ScheduleType.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.ScheduleType, ScheduleTypeModel>(data);
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
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ScheduleType.Where(s => s.scheduleTypeID == id).FirstOrDefault();
                if (data != null)
                {

                    _dbContext.SaveChanges();
                    var view = _mapper.Map<Data.Entities.ScheduleType, ScheduleTypeModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "ScheduleType" + ErrorMessage.ID_NOT_EXISTED;
                    result.Succeed = false;
                }


            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Get(Guid? id)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ScheduleType.Where(s => s.scheduleTypeID == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.ScheduleType, ScheduleTypeModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "ScheduleType" + ErrorMessage.ID_NOT_EXISTED;
                    result.Succeed = false;
                }


            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel GetAll()
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ScheduleType;
                var view = _mapper.ProjectTo<ScheduleTypeModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Update(ScheduleTypeUpdateModel model)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ScheduleType.Where(s => s.scheduleTypeID == model.scheduleTypeID).FirstOrDefault();
                if (data != null)
                {
                    if (model.scheduleTypeID != null)
                    {
                        data.typeOfName = model.typeOfName;
                    }
                    if (model.description != null)
                    {
                        data.description = model.description;
                    }

                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<Data.Entities.ScheduleType, ScheduleTypeModel>(data);
                }
                else
                {
                    result.ErrorMessage = "ScheduleType" + ErrorMessage.ID_NOT_EXISTED;
                    result.Succeed = false;
                }
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

    }


}
