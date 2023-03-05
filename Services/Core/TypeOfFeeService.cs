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
    public interface ITypeOfFeeService
    {
        ResultModel Add(TypeOfFeeCreateModel model);
        ResultModel Update(TypeOfFeeUpdateModel model);
        ResultModel Get(Guid? id);
        ResultModel GetAll();
        ResultModel Delete(Guid id);

    }
    public class TypeOfFeeService : ITypeOfFeeService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly Guid id;


        public TypeOfFeeService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            id = Guid.NewGuid();
        }
        public ResultModel Add(TypeOfFeeCreateModel model)
        {
            var result = new ResultModel();
            try
            {
                var data = _mapper.Map<TypeOfFeeCreateModel, Data.Entities.TypeOfFee>(model);
                _dbContext.TypeOfFee.Add(data);
                _dbContext.SaveChanges();
                result.Data = _mapper.Map<Data.Entities.TypeOfFee, TypeOfFeeModel>(data);
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
                var data = _dbContext.TypeOfFee.Where(s => s.typeOfFeeID == id).FirstOrDefault();
                if (data != null)
                {

                    _dbContext.SaveChanges();
                    var view = _mapper.Map<Data.Entities.TypeOfFee, TypeOfFeeModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "TypeOfFee" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.TypeOfFee.Where(s => s.typeOfFeeID == id).FirstOrDefault();
                if (data != null)
                {
                    var view = _mapper.Map<Data.Entities.TypeOfFee, TypeOfFeeModel>(data);
                    result.Data = view;
                    result.Succeed = true;
                }
                else
                {
                    result.ErrorMessage = "TypeOfFee" + ErrorMessage.ID_NOT_EXISTED;
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
                var data = _dbContext.TypeOfFee;
                var view = _mapper.ProjectTo<TypeOfFeeModel>(data);
                result.Data = view;
                result.Succeed = true;
            }
            catch (Exception e)
            {
                result.ErrorMessage = e.InnerException != null ? e.InnerException.Message : e.Message;
            }
            return result;
        }

        public ResultModel Update(TypeOfFeeUpdateModel model)
        {
            ResultModel result = new ResultModel();
            try
            {
                var data = _dbContext.TypeOfFee.Where(s => s.typeOfFeeID == model.typeOfFeeID).FirstOrDefault();
                if (data != null)
                {
                    if (model.typeOfFeeID != null)
                    {
                        data.serviceCharge = model.serviceCharge;
                    }
                    

                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<Data.Entities.TypeOfFee, TypeOfFeeModel>(data);
                }
                else
                {
                    result.ErrorMessage = "TypeOfFee" + ErrorMessage.ID_NOT_EXISTED;
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
