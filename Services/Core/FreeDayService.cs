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
    public interface IFreeDayService
    {
        ResultModel Add(FreeDayCreateModel model);
        ResultModel Update(FreeDayUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);

        Guid TestDI();
    }
    public class FreeDayService : IFreeDayService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;

        public Guid TestDI()
        {
            return id;
        }
        public FreeDayService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(FreeDayCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<FreeDayCreateModel, Data.Entities.FreeDay>(model);
                _dbContext.FreeDay.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.FreeDay, FreeDayModel>(data);
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
                var data = _dbContext.FreeDay.Where(s => s.freeDayID == id).FirstOrDefault();
                if (data != null)
                {

                    _dbContext.SaveChanges();
                    var view = _mapper.Map<Data.Entities.FreeDay, FreeDayModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "FreeDay" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.FreeDay.Where(s => s.freeDayID == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.FreeDay, FreeDayModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "FreeDay" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.FreeDay;
                var view = _mapper.ProjectTo<FreeDayModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Update(FreeDayUpdateModel model)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.FreeDay.Where(s => s.freeDayID == model.freeDayID).FirstOrDefault();
                if (data != null)
                {
                    if (model.freeDayID != null)
                    {
                        data.freeDate = model.freeDate;
                    }
                    if (model.timeStart != null)
                    {
                        data.timeStart = model.timeStart;
                    }
                    if (model.timeEnd != null)
                    {
                        data.timeEnd = model.timeEnd;
                    }
                    

                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<Data.Entities.FreeDay, FreeDayModel>(data);
                }
                else
                {
                    result.ErrorMessage = "FreeDay" + ErrorMessage.ID_NOT_EXISTED;
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
