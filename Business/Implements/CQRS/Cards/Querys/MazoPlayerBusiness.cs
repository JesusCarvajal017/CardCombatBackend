using AutoMapper;
using Business.Implements.Bases;
using Business.Interfaces.Querys;
using Data.Interfaces.Group.Querys;
using Entity.Dtos.Card;
using Entity.Model.Card;
using Microsoft.Extensions.Logging;
using Utilities.Helpers.Validations;

namespace Business.Implements.CQRS.Cards.Querys
{

    public class MazoPlayerBusiness : BaseQueryBusiness<MazoPlayer, MazoPlayerQueryDto>, IQueryMazoServices
    {
        protected readonly IQueryMazoPlayer _data;
       
        public MazoPlayerBusiness(
            IQueryMazoPlayer data,
            IMapper mapper,
            ILogger<MazoPlayerBusiness> _logger,
            IGenericHerlpers helpers) : base(data, mapper, _logger, helpers)
        {
            _data = data;
        }


        /// <summary>
        /// Valida un DTO utilizando las reglas de validación de FluentValidation.
        /// </summary>
        /// <param name="dto">El objeto DTO a validar</param>
        /// <returns>Una tarea que representa la operación de validación asíncrona</returns>
        /// <remarks>
        /// Este método utiliza el servicio _helpers para realizar la validación.
        /// Si la validación falla, se agrupan todos los errores en una sola excepción.
        /// </remarks>
        protected async Task EnsureValid(MazoPlayerQueryDto dto)
        {
            var validationResult = await _helpers.Validate(dto);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors);
                throw new ArgumentException($"Validación fallida: {errors}");
            }
        }


        public async Task<IEnumerable<MazoPlayerQueryDto>> GetByAllCardsService(int id)
        {
            try
            {
                var entities = await _data.QueryCardsMazo(id);
                _logger.LogInformation($"Obteniendo {typeof(MazoPlayer).Name} con ID: {id}");

                var result = _mapper.Map<IEnumerable<MazoPlayerQueryDto>>(entities);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener {typeof(MazoPlayer).Name} con ID {id}: {ex.Message}");
                throw;
            }
        }

    }

}
