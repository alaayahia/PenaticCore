using AutoMapper;
using PenaticCore.Application.Modules.DTO;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Common
{
    public interface IServiceBase<T, TDTO, TRequestDTO> where T : EntityBase where TDTO : BaseDTO
    {

        Task<TDTO> SingleAsync(string id);
        Task<IList<TDTO>> AllAsync();
        Task<TDTO> AddAsync(TRequestDTO requestDTO);
        
    }

    public abstract class ServiceBase<T, TDTO, TRequestDTO> : IServiceBase<T, TDTO, TRequestDTO>
  where T : EntityBase where TDTO : BaseDTO
    {
        protected readonly IRepositoryBase<T> Repository;
        protected readonly IMapper Mapper;

        protected ServiceBase(IMapper mapper, IRepositoryBase<T> repository)
        {
            Repository = repository;
            Mapper = mapper;
        }


        public virtual async Task<TDTO> SingleAsync(string id)
        {
            var result = await Repository.SingleOrDefaultAsync(x => x.Id == id);
            var mappedResult = Mapper.Map<T, TDTO>(result);
            return mappedResult;
        }
        public virtual async Task<IList<TDTO>> AllAsync()
        {
            var result = await Repository.GetAllAsync(x => x.IsActive == true);
            var mappedResult = Mapper.Map<IList<T>, IList<TDTO>>(result);
            return mappedResult;
        }
        public virtual async Task<TDTO> AddAsync(TRequestDTO dTO)
        {
            var mappedItem = Mapper.Map<TRequestDTO, T>(dTO);
            var savedItem = await Repository.AddAsync(mappedItem);
            var result = Mapper.Map<T, TDTO>(savedItem);
            return result;
        }

        


    }
}
