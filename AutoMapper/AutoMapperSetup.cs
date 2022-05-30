using AutoMapper;
using AutoMapperTest.models;
namespace AutoMapperTest.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region PloomesToProtheus

            CreateMap<ContactPloomes, ContactProtheus>();

            #endregion


            #region ProtheusToPloomes

            CreateMap<ContactProtheus, ContactPloomes>();

            #endregion
        }

    }
}