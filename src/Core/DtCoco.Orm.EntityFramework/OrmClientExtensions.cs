using DtCoco.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DtCoco.Orm.EntityFramework
{
    public static class OrmClientExtensions
    {
        public static string GetEfVersion(IOrmClient orm)
        {
            return "6.6.6";
        }
    }
}
