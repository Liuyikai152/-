using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SunFlower.Common;
using SunFlower.MODEL;
using SunFlower.IServices;
using Dapper;
using System.Data;
using Oracle.DataAccess.Client;

namespace SunFlower.Services
{

    public class AreaService : IArea
    {
        List<Area> IArea.GetAreas(int Pid)
        {
            using (OracleConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("");
                var areaList = conn.Query<Area>(sql, null);
                return areaList.ToList<Area>();
            }
        }
    }
}
