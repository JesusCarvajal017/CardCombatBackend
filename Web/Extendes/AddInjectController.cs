using Business.Implements.Bases;
using Business.Implements.CQRS.Cards.Querys;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Data.Implements.Commands;
using Data.Implements.CQRS.Card;
using Data.Implements.Pizza;
using Data.Implements.Querys;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
using Entity.Model.Card;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;


namespace Web.Extendes
{
    public static class AddInjectController
    {
        public static IServiceCollection AddInject(this IServiceCollection services)
        {
            // Data
            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );

            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );


            // Business
            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
                );
            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );


            // ======================================= extends =================================================

            services.AddScoped(
                  typeof(IQuerys<MazoPlayer>),
                  typeof(MazoPlayerData)
            );


            services.AddScoped<IQueryMazoPlayer, MazoPlayerData>();
            services.AddScoped<IQueryMazoServices, MazoPlayerBusiness>();

            services.AddScoped<IQuerysMove, MoveData >();
            services.AddScoped<IQueryCardRoundServices, MoverRoundBusiness>();

            services.AddScoped<IQuerysPlayer, PlayerData>();
            services.AddScoped<IQueryPlayerServices, PlayerBusiness>();


            services.AddScoped<IGenericHerlpers, GenericHelpers>();

            services.AddScoped<LoginData>();




            return services;

        }
    }
}
