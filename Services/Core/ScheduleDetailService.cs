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
    public interface IScheduleDetailService
    {
        ResultModel Add(ScheduleDetailCreateModel model);
        ResultModel Update(ScheduleDetailUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);

    }
    public class ScheduleDetailService : IScheduleDetailService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;

        public ScheduleDetailService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(ScheduleDetailCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<ScheduleDetailCreateModel, Data.Entities.ScheduleDetail>(model);
                _dbContext.ScheduleDetail.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.ScheduleDetail, ScheduleDetailModel>(data);
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
                var data = _dbContext.ScheduleDetail.Where(s => s.scheduleDetailID == id).FirstOrDefault();
                if (data != null)
                {

                    _dbContext.SaveChanges();
                    var view = _mapper.Map<Data.Entities.ScheduleDetail, ScheduleDetailModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "ScheduleDetail" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.ScheduleDetail.Where(s => s.scheduleDetailID == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.ScheduleDetail, ScheduleDetailModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "ScheduleDetail" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.ScheduleDetail;
                var view = _mapper.ProjectTo<ScheduleDetailModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }



        public ResultModel Update(ScheduleDetailUpdateModel model)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.ScheduleDetail.Where(s => s.scheduleDetailID == model.scheduleDetailID).FirstOrDefault();
                if (data != null)
                {
                    if (model.scheduleDetailID != null)
                    {
                        data.exerciseID = model.exerciseID;
                    }
                    if (model.totalScheduleID != null)
                    {
                        data.totalScheduleID = model.totalScheduleID;
                    }
                    if (model.scheduleTypeID != null)
                    {
                        data.scheduleTypeID = model.scheduleTypeID;
                    }
                    if (model.feeID != null)
                    {
                        data.feeID = model.feeID;
                    }

                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<Data.Entities.ScheduleDetail, ScheduleDetailModel>(data);
                }
                else
                {
                    result.ErrorMessage = "ScheduleDetail" + ErrorMessage.ID_NOT_EXISTED;
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
