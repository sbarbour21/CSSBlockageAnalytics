using CSSBlockageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSBlockageLibrary;
using Dapper;


namespace CSSBlockageLibrary.DataAccess
{
    public class SQLConnection : IDataConnection
    {
        public BlockEntryModel SaveEntry(BlockEntryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(BlockEntryConfig.CnnString("EntryDB1")))
            {
                //Sends to the database
                var p = new DynamicParameters();
                p.Add("@EngineerId", model.EngineerId);
                p.Add("@TimeStamp", model.Time);
                p.Add("@ServiceRequest", model.ServiceRequest);
                p.Add("@Severity", model.Severity);
                p.Add("@CriSit", model.CriSit);
                p.Add("@BlockReason", model.Status);
                p.Add("@BlockStatus", model.StatusReason);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spEntry_BlockInsert", p, commandType: CommandType.StoredProcedure);
                
                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
