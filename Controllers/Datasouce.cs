using LogiRoute.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LogiRoute.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Datasouce : ControllerBase
    {

        [HttpPost]
        public IActionResult getdata([FromBody] GetData getdata)
        {
            try
            {
                DataTable dt = DbManagement.GetData(getdata.tablename, getdata.Whereclause);
                var result = dt.AsEnumerable()
                     .Select(row => dt.Columns.Cast<DataColumn>()
                         .ToDictionary(
                             col => col.ColumnName,
                             col => row[col] == DBNull.Value
                                 ? null
                                 : row[col]
                         ))
                     .ToList();

                return Ok(result);
            }
            catch (SqlException ex)
            {
                return StatusCode(500, new
                {
                    Message = "Database error occured",
                    Error = ex.Message
                });
            }
        }
    }
}
