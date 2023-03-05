using AutoMapper;
using Data.Entities;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ExerciseCreateModel, Data.Entities.Exercise>();
            CreateMap<Data.Entities.Exercise, ExerciseModel>();
            CreateMap<ExerciseDetailCreateModel, Data.Entities.ExerciseDetail>();
            CreateMap<Data.Entities.ExerciseDetail, ExerciseDetailModel>();
            CreateMap<CategoryCreateModel, Data.Entities.Category>();
            CreateMap<Data.Entities.Category, CategoryModel>();
            CreateMap<FreeDayCreateModel, Data.Entities.FreeDay>();
            CreateMap<Data.Entities.FreeDay, FreeDayModel>();
            CreateMap<PhysiotherapistDetailCreateModel, Data.Entities.PhysiotherapistDetail>();
            CreateMap<Data.Entities.PhysiotherapistDetail, PhysiotherapistDetailModel>();
            CreateMap<TotalScheduleCreateModel, Data.Entities.TotalSchedule>();
            CreateMap<Data.Entities.TotalSchedule, TotalScheduleModel>();
            CreateMap<FreePhysioScheduleCreateModel, Data.Entities.FreePhysioSchedule>();
            CreateMap<Data.Entities.FreePhysioSchedule, FreePhysioScheduleModel>();
            CreateMap<FeeCreateModel, Data.Entities.Fee>();
            CreateMap<Data.Entities.Fee, FeeModel>();           
            CreateMap<TypeOfFeeCreateModel, Data.Entities.TypeOfFee>();
            CreateMap<Data.Entities.TypeOfFee, TypeOfFeeModel>();
            CreateMap<PaymentCreateModel, Data.Entities.Payment>();
            CreateMap<Data.Entities.Payment, PaymentModel>();
            CreateMap<ScheduleTypeCreateModel, Data.Entities.ScheduleType>();
            CreateMap<Data.Entities.ScheduleType, ScheduleTypeModel>();
            CreateMap<FeedbackCreateModel, Data.Entities.Feedback>();
            CreateMap<Data.Entities.Feedback, FeedbackModel>();
            CreateMap<ScheduleDetailCreateModel, Data.Entities.ScheduleDetail>();
            CreateMap<Data.Entities.ScheduleDetail, ScheduleDetailModel>();
            CreateMap<ExerciseFeedbackCreateModel, Data.Entities.ExerciseFeedback>();
            CreateMap<Data.Entities.ExerciseFeedback, ExerciseFeedbackModel>();
            CreateMap<VideoCreateModel, Data.Entities.Video>();
            CreateMap<Data.Entities.Video, VideoModel>();
            CreateMap<ImageCreateModel, Data.Entities.Image>();
            CreateMap<Data.Entities.Image, ImageModel>();
            CreateMap<ExerciseImageCreateModel, Data.Entities.ExerciseImage>();
            CreateMap<Data.Entities.ExerciseImage, ExerciseImageModel>();
            CreateMap<ExerciseVideoCreateModel, Data.Entities.ExerciseVideo>();
            CreateMap<Data.Entities.ExerciseVideo, ExerciseVideoModel>();
            CreateMap<DepositCreateModel, Deposit>();
            CreateMap<Deposit, DepositModel>();
            CreateMap<UserCreateModel, User>();
            CreateMap<User, UserModel>()
            ;
        }
    }
}
