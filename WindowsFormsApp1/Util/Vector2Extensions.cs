using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival.Util
{
    public static class Vector2Extensions
    {
        public static Vector2 Normalized(this Vector2 vector)
        {
            if(vector.Length()==0) return Vector2.Zero;
            return Vector2.Normalize(vector);
        }
    }
}
