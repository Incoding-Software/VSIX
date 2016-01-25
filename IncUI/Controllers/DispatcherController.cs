namespace IncUI.Controllers
{
    #region << Using >>

    using Incoding.MvcContrib.MVD;

    #endregion

    public class DispatcherController : DispatcherControllerBase
    {
        #region Constructors

        public DispatcherController()
                : base(typeof(Bootstrapper).Assembly) { }

        #endregion
    }
}