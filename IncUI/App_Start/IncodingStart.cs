#region << Using >>

using IncUI.App_Start;
using WebActivator;

#endregion

[assembly: PreApplicationStartMethod(
        typeof(IncodingStart), "PreStart")]

namespace IncUI.App_Start
{
    #region << Using >>

    using IncUI.Controllers;

    #endregion

    public static class IncodingStart
    {
        public static void PreStart()
        {
            Bootstrapper.Start();
            new DispatcherController(); // init routes
        }
    }
}