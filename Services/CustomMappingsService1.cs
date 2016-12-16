using WebApplication1TidTilForsikringApp.Enums;

namespace WebApplication1TidTilForsikringApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomMappingsService1 : BaseMappingsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        protected override decimal ResolveY(X x, int d, int e, int f)
        {
            if (x == X.R)
            {
                return (2 * d) + (d * e / 100);
            }

            return base.ResolveY(x, d, e, f);
        }
    }
}