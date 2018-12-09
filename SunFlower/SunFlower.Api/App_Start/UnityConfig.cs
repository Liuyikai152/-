using System;

using Unity;

namespace SunFlower.Api
{
    using Services;
    using IServices;
    using MODEL;
    using SunFlower.IServices;
    using SunFlower.Services;

    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IComment, CommentsService>();
            container.RegisterType<IArea,AreaService>();
            container.RegisterType<IFood, FoodService>();
            container.RegisterType<ICollect, CollectService>();
            container.RegisterType<IFoodType, FoodTypeService>();
            container.RegisterType<IDiscounts, DiscountService>();
            container.RegisterType<IBootstrap, BootstrapServices>();
            container.RegisterType<IUserOrder,UserOrderService>();
            container.RegisterType<IStore, StoreService>();
            container.RegisterType<IUserLogs, UserLogsServce>();
            container.RegisterType<IUsers, UserService>();
            container.RegisterType<IUser_Adders, User_AddersService>();
            container.RegisterType<ITrolley, TrolleyService>();
            container.RegisterType<ITrolleyDetails, TrolleyDetailService>();
        }
    }
}