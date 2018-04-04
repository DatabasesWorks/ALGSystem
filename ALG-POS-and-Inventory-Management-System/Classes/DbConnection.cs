using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ALG_POS_and_Inventory_Management_System {
    class DbConnection {
        private static string Server = Properties.Settings.Default.dbIpAddress;
        private static string DatabaseName = Properties.Settings.Default.dbName;
        private static string User = Properties.Settings.Default.dbUsername;
        private static string Password = Properties.Settings.Default.dbPassword;
        MySqlCommand Command = new MySqlCommand();
        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlConnection Connection = new MySqlConnection("Server='" + Properties.Settings.Default.dbIpAddress + "'; User Id='" + Properties.Settings.Default.dbUsername + "'; Password='" + Properties.Settings.Default.dbPassword + "' ;Database='" + Properties.Settings.Default.dbName + "'");

        public bool Execute(string query, string[] param) {
            bool status = false;
            try {
                Connection.Open();
                Command = new MySqlCommand(query, Connection);
                for (int i = 0; i < param.Length; i++) {
                    string par = String.Format("@{0}", i);
                    string val = param[i].ToString();
                    Command.Parameters.AddWithValue(par, val);
                }
                Command.CommandTimeout = 60;
                Command.ExecuteReader();
                status = true;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            return (status);
        }
        public bool Execute(string query) {
            bool status = false;
            try {
                Connection.Open();
                Command = new MySqlCommand(query, Connection);
                Command.CommandTimeout = 60;
                Command.ExecuteReader();
                status = true;
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            return (status);
        }
        public System.Data.DataTable Retrieve(string query) {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            try {
                Connection.Open();
                Adapter = new MySqlDataAdapter(query, Connection);
                //Adapter.SelectCommand.Parameters.AddWithValue("@param", query);
                Adapter.Fill(dataTable);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            return (dataTable);
        }
        public void Authenticate(string query, string[] param) {
            //Connection.ConnectionString = ConnectionString();
            //string[] result = null;
            try {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                for (int i = 0; i < param.Length; i++) {
                    string par = String.Format("@{0}", i);
                    string val = param[i].ToString();
                    cmd.Parameters.AddWithValue(par, val);
                }
                //cmd.CommandTimeout = 60;
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                //List<string> list = new List<string>();
                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        //for (int i = 0; i < Convert.ToInt32(cmd.ExecuteScalar().ToString()); i++) {
                        //ControllerLogin.userID = dataReader.GetString(0); ControllerLogin.firstname = dataReader.GetString(1); ControllerLogin.user_type = dataReader.GetString(2); ControllerLogin.isLogin = dataReader.GetString(3);
                        //}
                    }
                } else {

                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
        }
        public List<string> Select(string query, string[] param) {
            List<string> list = new List<string>();
            try {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                for (int i = 0; i < param.Length; i++) {
                    string par = String.Format("@{0}", i);
                    string val = param[i].ToString();
                    cmd.Parameters.AddWithValue(par, val);
                }
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        for (int i = 0; i < dataReader.FieldCount; i++) {
                            if (dataReader.GetString(i) == null) {
                                list = null;
                                break;
                            }
                            list.Add(dataReader.GetString(i));
                        }
                    }
                } else {
                    list = null;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            return list;
        }
        public List<string> Select(string query) {
            //Connection.ConnectionString = ConnectionString();
            List<string> list = new List<string>();
            try {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                //cmd.CommandTimeout = 60;
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        for (int i = 0; i < dataReader.FieldCount; i++) {
                            if (dataReader.IsDBNull(i)) {
                                list = null;
                                break;
                            }
                            list.Add(dataReader.GetString(i));
                        }
                    }
                    //  result = list.ToArray();
                }else if (dataReader.IsDBNull(0)) {
                    list = null;
                }
                else {
                    list = null;
                }
            } catch (Exception ex) {
                list = null;
                //System.Windows.Forms.MessageBox.Show(ex.Message);   // commented out because error occurs for unknown reason. error: invalid attempt to acccess a field before calling Read(); when selecting product without price
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            return list;
        }
        public string[] SelectStringArray(string query, string[] param) {
            //Connection.ConnectionString = ConnectionString();
            List<string> list = new List<string>();
            string[] result;
            try {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                for (int i = 0; i < param.Length; i++) {
                    string par = String.Format("@{0}", i);
                    string val = param[i].ToString();
                    cmd.Parameters.AddWithValue(par, val);
                }
                //cmd.CommandTimeout = 60;
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        for (int i = 0; i < dataReader.FieldCount; i++) {
                            list.Add(dataReader.GetString(i));
                        }
                    }
                    //  result = list.ToArray();
                } else {
                    list = null;
                }
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            } finally {
                if (Connection.State == System.Data.ConnectionState.Open) {
                    Connection.Close();
                }
            }
            if (list == null) {
                result = null;
            } else {
                result = list.Select(i => i.ToString()).ToArray(); ;
            }
            return result;
        }
    }
}
