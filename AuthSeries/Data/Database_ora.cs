using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text;

namespace StudentWebAPI.Data
{
    public class Database_ora : IdentityDbContext<IdentityUser>
    {

        public Database_ora(DbContextOptions<Database_ora> options) : base(options)
        {
        }


        #region " Global variables"

        OracleConnection conn = default(OracleConnection);
        OracleDataReader reader = default(OracleDataReader);
        DataSet dataset = default(DataSet);
        DataTable datatable = default(DataTable);
        OracleCommand command = default(OracleCommand);


        #endregion


        #region "Constructor"

        public Database_ora()
        {
            string ConnString = "EMS";
            try
            {
                string connectionString = null;
                connectionString = ConnectionStringByServer(ConnString);
                conn = new OracleConnection(connectionString);
                conn.Open();
                //for (int i = 0; i < 5; i++)
                //{
                //    try
                //    {
                //        conn.Open();
                //    }
                //    catch (OracleException)
                //    {
                //        System.Threading.Thread.Sleep(15);
                //        if (i.Equals(4))
                //            OracleConnection.ClearAllPools();
                //    }
                //}
            }
            catch (Exception ex)
            {

            }
        }

        public Database_ora(bool IsConnOpen, string ConnectionString_Config, string Provider_Name)
        {

            if (Provider_Name == "ODP")
            {
                if (IsConnOpen == true)
                {
                    try
                    {
                        string connectionString = null;
                        connectionString = ConnectionStringByServer(ConnectionString_Config);
                        conn = new OracleConnection(connectionString);
                        conn.Open();
                    }
                    catch (Exception ex)
                    {

                    }
                }


            }
            //else if (Provider_Name == "OLEDB")
            //{
            //    if (IsConnOpen == true)
            //    {
            //        OleDbConnection oracleConn = new OleDbConnection();
            //        string connectionString = null;
            //        connectionString = ConnectionStringByServer(ConnectionString_Config);
            //        oracleConn.ConnectionString = connectionString;
            //        oracleConn.Open();
            //    }

            //}

        }

        public Database_ora(string ConnectionString_Config)
        {
            string ConnectionString = null;
            ConnectionString = ConnectionStringByServer(ConnectionString_Config);
            conn = new OracleConnection(ConnectionString);
            conn.Open();
        }

        #endregion


        #region "User Defined Connection Strings Function By different server"

        public string ConnectionStringByServer(string server_identity)
        {

            string ConnString = null;

            if (server_identity == "EMS")
            {
                ConnString = ConfigurationManager.AppSetting["ConnectionStrings:OracleDBConnection"];
                //ConnString = "Data Source = EMS_REAL; User ID = EMS; password = EMS; Connection Timeout = 300";
                //ConnString = "Data Source=103.91.54.27:1521/EPAYWZPDCL;User Id=EMS;Password=EMS;Connection Timeout=900;";
                //ConnString = "Data Source=103.91.54.27:1521/EPAYWZPDCL;User Id=EMS;Password=EMS;Connection Timeout=900; pooling='true';Max Pool Size=900";
                //ConnString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.20.27)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=EPAYWZPDCL)));User ID=EMS;Password=EMS;";
                //ConnString = "Data Source = localhost; User ID = EMS; password = EMS; Connection Timeout = 300";
                // ConnString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.20.25)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=mbp)));User ID=EMS;Password=EMS;";
            }

            return ConnString;

        }

        #endregion

        #region "CreateSqlCommand"

        public void CreateSqlCommand(string SpName, OracleParameter[] parms)
        {
            command = new OracleCommand(SpName, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 1200;
            command.InitialLOBFetchSize = -1;
            if ((parms != null))
            {
                foreach (OracleParameter parameter in parms)
                {
                    if (parameter.Direction == ParameterDirection.Output && parameter.OracleDbType != OracleDbType.Varchar2)
                        command.Parameters.Add(parameter.ParameterName, parameter.OracleDbType, 4000).Direction = parameter.Direction;
                    else
                        command.Parameters.Add(parameter);
                }
            }

        }

        public void CreateSqlCommand(string SqlStatement)
        {
            command = new OracleCommand(SqlStatement, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 1200;
        }

        #endregion


        #region "RunProcedure"

        public int RunProcedureWithReturnVal(string SpName, OracleParameter[] parms)
        {

            CreateSqlCommand(SpName, parms);

            Int32 retval = 0;

            try
            {
                command.ExecuteNonQuery();
                retval = ((OracleDecimal)command.Parameters[0].Value).ToInt32();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command.Dispose();
                CleanDatabase();

            }

            return retval;

        }

        public string RunProcedureWithReturnValueString(string SpName, OracleParameter[] parms)
        {

            CreateSqlCommand(SpName, parms);

            string retval = string.Empty;

            try
            {
                command.ExecuteNonQuery();
                retval = ((OracleDecimal)command.Parameters[0].Value).ToString();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command.Dispose();
                CleanDatabase();

            }

            return retval;

        }

        public (int status,string response)  RunProcedureWithReturnValAndStatus(string SpName, OracleParameter[] parms)
        {

            CreateSqlCommand(SpName, parms);

            Int32 status = 0;
            string response = "0";

            try
            {
                command.ExecuteNonQuery();
                status = ((OracleDecimal)command.Parameters[0].Value).ToInt32();
                response =Convert.ToString((OracleString)command.Parameters[1].Value).Trim();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command.Dispose();
                CleanDatabase();

            }

            return (status, response);

        }



        public void RunProcedure(string SpName)
        {
            CreateSqlCommand(SpName);

            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command.Dispose();
                conn.Close();

            }

        }

        public void RunProcedurewithparameter(string SpName, ref OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);
            try
            {
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                command.Dispose();
                conn.Close();

            }
        }

        #endregion

        #region "RunFunction"

        public int RunFunction(string SpName, ref OracleParameter[] parms)
        {


            CreateSqlCommand(SpName, parms);
            int retVal = 0;
            try
            {
                command.ExecuteNonQuery();
                retVal = System.Convert.ToInt32(command.Parameters["ReturnValue"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return retVal;
        }


        public string RunFunctionString(string SpName, OracleParameter[] parms)
        {
            //success return 0 fail return 1 

            CreateSqlCommand(SpName, parms);
            string retVal = null;
            try
            {
                command.ExecuteNonQuery();
                retVal = command.Parameters["ReturnValue"].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return retVal;
        }


     

        public int RunFunctionInteger(string SpName, OracleParameter[] parms)
        {
            //success return 0 fail return 1 

            CreateSqlCommand(SpName, parms);
            int retVal = 0;
            try
            {
                command.ExecuteNonQuery();
                retVal =Convert.ToInt16(command.Parameters["ReturnValue"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return retVal;
        }

        #endregion


        #region "GetList"


        public OracleDataReader GetList(string SpName)
        {
            return GetList(SpName, null);
        }

        public OracleDataReader GetList(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }
            return reader;
        }

        public T GetModelData<T>(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);

            T local = (T)Activator.CreateInstance(typeof(T));

            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PropertyInfo[] properties = local.GetType().GetProperties();
                        foreach (PropertyInfo info in properties)
                        {
                            info.SetValue(local, this.GetValue(info.Name, reader), null);
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return local;
        }



        public string GetStringData(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);
            string jsonData = string.Empty;
            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Get JSON data
                        jsonData = reader.GetString(0);
                        return jsonData;
                    }
                    else
                    {
                        return null; // No data returned
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return jsonData;
        }
         

        public List<T> GetList<T>(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);

            List<T> list = new List<T>();

            try
            {
                //command.InitialLOBFetchSize = -1;
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        T local = (T)Activator.CreateInstance(typeof(T));
                        PropertyInfo[] properties = local.GetType().GetProperties();
                        foreach (PropertyInfo info in properties)
                        {
                            info.SetValue(local, this.GetValue(info.Name, reader), null);
                        }
                        list.Add(local);
                    }
                    return list;
                }  

            }
            catch (Exception ex)
            {
               throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return list;
        }


        public List<Dictionary<string, object>> GetDynamicList(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);

            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var columnName = reader.GetName(i);
                            var value = reader[i];
                            row[columnName] = value == DBNull.Value ? null : value;
                        }
                        list.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow as necessary)
                throw;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return list;
        }
        private object GetValue(string proname, OracleDataReader dreader)
        {
            try
            {
                object p = dreader[proname];
                if ((object.ReferenceEquals(p.GetType(), typeof(DBNull))))
                {
                    return null;
                }
                return p;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public OracleDataReader GetListWithReturnValue(string SpName, OracleParameter[] parms, ref int ReturnValue)
        {

            CreateSqlCommand(SpName, parms);

            try
            {
                reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ReturnValue = ((OracleDecimal)command.Parameters[0].Value).ToInt32();
                command.Dispose();
                CleanDatabase();
            }

            return reader;
        }
        #endregion

        #region " Clean Database"



        public void CleanDatabase()
        {

            try
            {
                if ((conn != null))
                {
                    //conn.CloseAsync();
                    conn.DisposeAsync();
                    OracleConnection.ClearPool(conn);
                }

                if ((reader != null))
                {
                    reader.DisposeAsync();                    
                }

                if ((command != null))
                {
                    command.DisposeAsync();
                }

                if ((datatable != null))
                {
                    datatable.Dispose();
                }


            }
            catch (Exception ex)
            {
            }
        }

        #endregion


        #region "getDataSet"

        public DataSet GetDataSet(string SpName)
        {
            return GetDataSet(SpName, null);
        }

        public DataSet GetDataSet(string SpName, OracleParameter[] parms)
        {
            return GetDataSet(SpName, parms, null);
        }


        public DataSet GetDataSet(string SpName, OracleParameter[] parms, Queue MapList)
        {
            return GetDataSet(SpName, parms, MapList, "IBudget");
        }

        public DataSet GetDataSet(string SpName, OracleParameter[] parms, Queue MapList, string DataSetName)
        {

            CreateSqlCommand(SpName, parms);

            OracleDataAdapter da = new OracleDataAdapter(command);            
            try
            {
                dataset = new DataSet(DataSetName);

                int i = 0;
                string MapName = "Table";
                while ((MapList != null) && MapList.Count > 0)
                {
                    da.TableMappings.Add(MapName, MapList.Dequeue().ToString());
                    i += 1;
                    MapName = "Table" + i;
                }

                da.Fill(dataset);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }

            return dataset;

        }
        #endregion

        #region GetDataTable

        //public DataTable GetDataTable(string SpName)
        //{
        //    return GetDataTable(SpName, null);
        //}

        //public DataTable GetDataTable(string SpName, OracleParameter[] parms)
        //{
        //    return GetDataTable(SpName, parms, "IBudget");
        //}

        //public DataTable GetDataTable(string SpName, OracleParameter[] parms, string DataTableName)
        //{

        //    CreateSqlCommand(SpName, parms);

        //    OracleDataAdapter da = new OracleDataAdapter(command);
        //    try
        //    {
        //        datatable = new DataTable(DataTableName);

        //        int i = 0;
        //        string MapName = "Table";
        //        da.Fill(datatable);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        command.Dispose();
        //        CleanDatabase();
        //    }

        //    return datatable;

        //}
        public DataTable GetDataTable(string SpName, OracleParameter[] parms)
        {
            CreateSqlCommand(SpName, parms);

            Int32 status = 0;

            DataTable dataTable = new DataTable();

            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    // Load data from the reader into the DataTable
                    dataTable.Load(reader);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                throw new Exception("Error occurred while reading data", ex);
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
            }
        }

        #endregion

        #region "Execute scaler"

        public object ExecuteScaler(string SpName, OracleParameter[] parms)
        {

            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            CreateSqlCommand(SpName, parms);
            try
            {
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                CleanDatabase();
                //CleanDatabase()
            }
        }
        #endregion

        #region " Make Parameter"

        // Makes input type param

        public OracleParameter MakeInParameter(object Value, OracleDbType ParamType)
        {
            return MakeParam("", ParameterDirection.Input, Value, ParamType, 0, OracleCollectionType.None);
        }
        public OracleParameter MakeInParameter(string ParmName, object Value, OracleDbType ParamType)
        {
            return MakeParam(ParmName, ParameterDirection.Input, Value, ParamType, 0, OracleCollectionType.None);
        }

        public OracleParameter MakeReturnValue(string ParmName, OracleDbType ParamType, int ParamSize)
        {
            return MakeParam(ParmName, ParameterDirection.ReturnValue, null, ParamType, ParamSize, OracleCollectionType.None);
        }

        public OracleParameter MakeOutParameter(OracleDbType ParamType, ParameterDirection ParmDirection)
        {

            return MakeParam("", ParmDirection, null, ParamType, 0, OracleCollectionType.None);
        }
        public OracleParameter MakeOutParameter(string ParmName, OracleDbType ParamType, ParameterDirection ParmDirection)
        {

            return MakeParam(ParmName, ParmDirection, null, ParamType, 0, OracleCollectionType.None);
        }

        public OracleParameter MakeCollectionParameter(string ParmName, object Value, OracleDbType ParamType, int ParamSize)
        {
            return MakeParam(ParmName, ParameterDirection.Input, Value, ParamType, ParamSize, OracleCollectionType.PLSQLAssociativeArray);
        }

        public OracleParameter MakeCollectionParameter(object Value, OracleDbType ParamType, int ParamSize)
        {
            return MakeParam("", ParameterDirection.Input, Value, ParamType, ParamSize, OracleCollectionType.PLSQLAssociativeArray);
        }


        public OracleParameter MakeParam(string ParmName, ParameterDirection Direction, object Value, OracleDbType ParamType, int ParamSize, OracleCollectionType ParamCollectionType)
        {
            OracleParameter Param = default(OracleParameter);
            try
            {
                if (Direction == ParameterDirection.Input)
                {
                    Param = new OracleParameter(ParmName, ParamType, ParamSize, Direction);
                    Param.Value = Value;
                }
                else if (Direction == ParameterDirection.Output)
                {
                    Param = new OracleParameter(ParmName, ParamType, ParamSize, Direction);
                    Param.Value = Value;
                }
                else if (Direction == ParameterDirection.ReturnValue)
                {
                    Param = new OracleParameter(ParmName, ParamType, ParamSize, null, Direction);
                    Param.Value = Value;
                }

                if (ParamCollectionType == OracleCollectionType.PLSQLAssociativeArray)
                {
                    Param.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return Param;

        }

        #endregion
    }
}
