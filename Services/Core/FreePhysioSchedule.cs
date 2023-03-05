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
    public interface IFreePhysioScheduleService
    {
        ResultModel Add(FreePhysioScheduleCreateModel model);
        ResultModel Update(FreePhysioScheduleUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);

        Guid TestDI();
    }
    public class FreePhysioScheduleService : IFreePhysioScheduleService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;

        public Guid TestDI()
        {
            return id;
        }
        public FreePhysioScheduleService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(FreePhysioScheduleCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<FreePhysioScheduleCreateModel, Data.Entities.FreePhysioSchedule>(model);
                _dbContext.FreePhysioSchedule.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.FreePhysioSchedule, FreePhysioScheduleModel>(data);
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
                var data = _dbContext.FreePhysioSchedule.Where(s => s.freeScheduleID == id).FirstOrDefault();
                if (data != null)
                {

                    _dbContext.SaveChanges();
                    var view = _mapper.Map<Data.Entities.FreePhysioSchedule, FreePhysioScheduleModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "FreePhysioSchedule" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.FreePhysioSchedule.Where(s => s.freeScheduleID == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.FreePhysioSchedule, FreePhysioScheduleModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "FreePhysioSchedule" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.FreePhysioSchedule;
                var view = _mapper.ProjectTo<FreePhysioScheduleModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Update(FreePhysioScheduleUpdateModel model)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.FreePhysioSchedule.Where(s => s.freeScheduleID == model.freeScheduleID).FirstOrDefault();
                if (data != null)
                {
                    if (model.freeScheduleID != null)
                    {
                        data.freeDayID = model.freeDayID;
                    }
                    if (model.physiotherapistID != null)
                    {
                        data.physiotherapistID = model.physiotherapistID;
                    }
                    


                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<Data.Entities.FreePhysioSchedule, FreePhysioScheduleModel>(data);
                }
                else
                {
                    result.ErrorMessage = "FreePhysioSchedule" + ErrorMessage.ID_NOT_EXISTED;
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
