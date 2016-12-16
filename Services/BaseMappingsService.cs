using System;
using WebApplication1TidTilForsikringApp.Enums;
using WebApplication1TidTilForsikringApp.Models;

namespace WebApplication1TidTilForsikringApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseMappingsService
    {
        public virtual Outputs ResolveOutputs(bool a, bool b, bool c, int d, int e, int f)
        {
            var x = ResolveX(a, b, c);
            var y = ResolveY(x, d, e, f);

            return new Outputs { _X = x, Y = y };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        protected virtual X ResolveX(bool a, bool b, bool c)
        {
            if (a && b && !c)
            {
                return X.S;
            }

            if (a && b && c)
            {
                return X.R;
            }

            if (!a && b && c)
            {
                return X.T;
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        protected virtual decimal ResolveY(X x, int d, int e, int f)
        {
            switch (x)
            {
                case X.S:
                    return d + (d * e / 100);

                case X.R:
                    return d + (d * (e - f) / 100);

                case X.T:
                    return d - (d * f / 100);

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}