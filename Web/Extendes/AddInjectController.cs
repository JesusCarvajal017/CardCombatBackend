using Business.Implements.Bases;
using Business.Interfaces.Commands;
using Data.Interfaces.Group.Querys;
using Data.Implements.Querys;
using Data.Interfaces.Group.Commands;
using Data.Implements.Commands;
using Business.Interfaces.Querys;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;
using Data.Implements.CQRS.Card;
using Entity.Model.Card;


namespace Web.Extendes
{
    public static class AddInjectController
    {
        public static IServiceCollection AddInject(this IServiceCollection services)
        {

            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );

            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );

            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
                );
            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );



            services.AddScoped(
                  typeof(IQuerys<MazoPlayer>),
                  typeof(MazoPlayerData)
            );

            services.AddScoped<IGenericHerlpers, GenericHelpers>();
  




            return services;

        }
    }
}
