using DevOps.Web.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOps.Web.Api.Adapters
{
    public class SqlAdapter
    {
        public SqlAdapter()
        {
            
            this.connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        }

        private string connectionString;

        public List<PlayerEntity> ReadAll()
        {
            var result = new List<PlayerEntity>();

            using (var context = new System.Data.SqlClient.SqlConnection(this.connectionString))
            {
                try
                {
                    context.Open();

                    var command = context.CreateCommand();

                    command.CommandText = "select * from players;";

                    using (SqlDataReader rdr = command.ExecuteReader())
                    {

                        if (rdr.HasRows)
                        {
                            
                            while (rdr.Read())
                            {
                                var entity = new PlayerEntity();

                                entity.ID = rdr.GetInt32(0);
                                entity.Name = rdr.GetString(1);
                                entity.LastName = rdr.GetString(2);
                                entity.Birthday = rdr.GetInt64(3);

                                result.Add(entity);
                            }                            
                        }
                        
                    }

                    context.Close();
                }
                catch (Exception ex)
                {
                    context.Close();

                    throw ex;
                }                
            }

            return result;
        }
    }
}