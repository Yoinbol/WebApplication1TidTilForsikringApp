using WebApplication1TidTilForsikringApp.Enums;

namespace WebApplication1TidTilForsikringApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomMappingsService2 : BaseMappingsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        protected override X ResolveX(bool a, bool b, bool c)
        {
            if (a && b && !c)
            {
                return X.T;
            }

            if (a && !b && c)
            {
                return X.S;
            }

            return base.ResolveX(a, b, c);
        }

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
            if (x == X.S)
            {
                return f + d + (d * e / 100);
            }

            return base.ResolveY(x, d, e, f);
        }
    }
}