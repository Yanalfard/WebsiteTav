using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebsiteTav.Models.Regular;

namespace WebsiteTav.Utilities
{
    public class MainProvider
    {
        private static readonly string ConnectionString = Config.ConnectionString;
        private SqlConnection _connection;
        private SqlCommand _command;
        private string _commandText = "";

        public MainProvider()
        {
            _connection = new SqlConnection(ConnectionString);
            _connection.Open();
        }

        private void _disconnect()
        {
            _connection.Close();
        }

        public enum Tables
        {
            TblCoop,
            TblStart,
            TblProduct,
            TblHelp
        }

        public object Add<T>(T table)
        {
            //try
            //{
            object tableObj = table;
            SqlCommand command;
            if (table.GetType() == typeof(TblCoop))
            {
                TblCoop coop = (TblCoop)tableObj;

                _commandText = $"insert into TblCoop (Name , TellNo) values (N'{coop.Name}' , N'{coop.TellNo}' )";
                command = new SqlCommand($"select TOP (1) * from TblCoop where TellNo = N'{coop.TellNo}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblCoop(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString());
            }

            else if (table.GetType() == typeof(TblStart))
            {
                TblStart start = (TblStart)tableObj;
                _commandText = $"insert into TblStart (Name , TellNo , Description , Brand , SocialMediaLink , Status) values (N'{start.Name}' , N'{start.TellNo}' , N'{start.Description}' , N'{start.Brand}' , N'{start.SocialMediaLink}' , N'{start.Status}' )";
                command = new SqlCommand($"select TOP (1) * from TblStart where TellNo = N'{start.TellNo}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblStart(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Description"].ToString(), reader["Brand"].ToString(), reader["SocialMediaLink"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0);
            }

            else if (table.GetType() == typeof(TblProduct))
            {
                TblProduct product = (TblProduct)tableObj;
                _commandText = $"insert into TblProduct (Name , TellNo , Address , ProductName) values (N'{product.Name}' , N'{product.TellNo}' , N'{product.Address}' , N'{product.ProductName}' )";
                command = new SqlCommand($"select TOP (1) * from TblProduct where TellNo = N'{product.TellNo}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString());
            }

            else if (table.GetType() == typeof(TblHelp))
            {
                TblHelp help = (TblHelp)tableObj;
                _commandText = $"insert into TblHelp (Name , Email , Description) values (N'{help.Name}' , N'{help.Email}' , N'{help.Description}' )";
                command = new SqlCommand($"select TOP (1) * from TblHelp where Email = N'{help.Email}' ORDER BY id DESC", _connection);
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return new TblHelp(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["Description"].ToString());
            }

            _command = new SqlCommand(_commandText, _connection);
            _command.ExecuteNonQuery();
            return true;
            //}
            //catch
            //{
            //    return false;
            //}
            //finally
            //{
            //    _disconnect();
            //}
        }

        public bool Update<T>(T table, int logId)
        {
            try
            {
                object tableObj = table;
                if (table.GetType() == typeof(TblCoop))
                {
                    TblCoop coop = (TblCoop)tableObj;
                    _commandText = $"update TblCoop set Name = N'{coop.Name}' , TellNo = N'{coop.TellNo}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblStart))
                {
                    TblStart start = (TblStart)tableObj;
                    _commandText = $"update TblStart set Name = N'{start.Name}' , TellNo = N'{start.TellNo}' , Description = N'{start.Description}' , Brand = N'{start.Brand}' , SocialMediaLink = N'{start.SocialMediaLink}' , Status = N'{start.Status}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblProduct))
                {
                    TblProduct product = (TblProduct)tableObj;
                    _commandText = $"update TblProduct set Name = N'{product.Name}' , TellNo = N'{product.TellNo}' , Address = N'{product.Address}' , ProductName = N'{product.ProductName}' where id = N'{logId}'";
                }
                else if (table.GetType() == typeof(TblHelp))
                {
                    TblHelp help = (TblHelp)tableObj;
                    _commandText = $"update TblHelp set Name = N'{help.Name}' , Email = N'{help.Email}' , Description = N'{help.Description}' where id = N'{logId}'";
                }
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _disconnect();
            }
        }

        public bool Delete(Tables tableType, int id)
        {
            try
            {
                _commandText = $"delete from {tableType.ToString()} where id = N'{id}'";
                _command = new SqlCommand(_commandText, _connection);
                _command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _disconnect();
            }
        }

        public IEnumerable SelectAll(Tables tableType)
        {
            try
            {
                _commandText = $"select * from {tableType.ToString()}";
                _command = new SqlCommand(_commandText, _connection);
                SqlDataReader reader = _command.ExecuteReader();
                switch (tableType)
                {
                    case Tables.TblCoop:
                        List<TblCoop> coops = new List<TblCoop>();
                        while (reader.Read())
                            coops.Add(new TblCoop(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString()));
                        return coops;
                    case Tables.TblStart:
                        List<TblStart> starts = new List<TblStart>();
                        while (reader.Read())
                            starts.Add(new TblStart(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Description"].ToString(), reader["Brand"].ToString(), reader["SocialMediaLink"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0));
                        return starts;
                    case Tables.TblProduct:
                        List<TblProduct> products = new List<TblProduct>();
                        while (reader.Read())
                            products.Add(new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString()));
                        return products;
                    case Tables.TblHelp:
                        List<TblHelp> helps = new List<TblHelp>();
                        while (reader.Read())
                            helps.Add(new TblHelp(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["Description"].ToString()));
                        return helps;
                    default:
                        return new List<bool>();
                }
            }
            catch
            {
                return new List<bool>();
            }
            finally
            {
                _disconnect();
            }
        }

        public object SelectById(Tables table, int id)
        {
            try
            {
                _command = new SqlCommand($"select * from {table.ToString()} where id = '{id}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                if (table == Tables.TblCoop)
                    return new TblCoop(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString());
                else if (table == Tables.TblStart)
                    return new TblStart(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Description"].ToString(), reader["Brand"].ToString(), reader["SocialMediaLink"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0);
                else if (table == Tables.TblProduct)
                    return new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString());
                else if (table == Tables.TblHelp)
                    return new TblHelp(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["Description"].ToString());

                return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                _disconnect();
            }
        }

        #region TblCoop

        public TblCoop SelectCoopByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblCoop where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblCoop(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString());
            }
            catch
            {
                return new TblCoop(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        public TblCoop SelectCoopByTellNo(string tellNo)
        {
            try
            {
                _command = new SqlCommand($"select* from TblCoop where TellNo = N'{tellNo}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblCoop(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString());
            }
            catch
            {
                return new TblCoop(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion


        #region TblStart

        public TblStart SelectStartByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblStart where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblStart(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Description"].ToString(), reader["Brand"].ToString(), reader["SocialMediaLink"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0);
            }
            catch
            {
                return new TblStart(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        public TblStart SelectStartByTellNo(string tellNo)
        {
            try
            {
                _command = new SqlCommand($"select* from TblStart where TellNo = N'{tellNo}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblStart(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Description"].ToString(), reader["Brand"].ToString(), reader["SocialMediaLink"].ToString(), reader["Status"].ToString() != "" ? Convert.ToInt32(reader["Status"]) : 0);
            }
            catch
            {
                return new TblStart(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion


        #region TblProduct

        public TblProduct SelectProductByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblProduct where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString());
            }
            catch
            {
                return new TblProduct(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        public TblProduct SelectProductByTellNo(string tellNo)
        {
            try
            {
                _command = new SqlCommand($"select* from TblProduct where TellNo = N'{tellNo}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString());
            }
            catch
            {
                return new TblProduct(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        public TblProduct SelectProductByProductName(string productName)
        {
            try
            {
                _command = new SqlCommand($"select* from TblProduct where ProductName = N'{productName}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblProduct(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["TellNo"].ToString(), reader["Address"].ToString(), reader["ProductName"].ToString());
            }
            catch
            {
                return new TblProduct(-1);
            }
            finally
            {
                _disconnect();
            }
        }

        #endregion


        #region TblHelp

        public TblHelp SelectHelpByName(string name)
        {
            try
            {
                _command = new SqlCommand($"select* from TblHelp where Name = N'{name}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblHelp(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["Description"].ToString());
            }
            catch
            {
                return new TblHelp(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        public TblHelp SelectHelpByEmail(string email)
        {
            try
            {
                _command = new SqlCommand($"select* from TblHelp where Email = N'{email}'", _connection);
                SqlDataReader reader = _command.ExecuteReader();
                reader.Read();
                return new TblHelp(reader["id"].ToString() != "" ? Convert.ToInt32(reader["id"]) : 0, reader["Name"].ToString(), reader["Email"].ToString(), reader["Description"].ToString());
            }
            catch
            {
                return new TblHelp(-1);
            }
            finally
            {
                _disconnect();
            }
        }
        #endregion


    }
}
