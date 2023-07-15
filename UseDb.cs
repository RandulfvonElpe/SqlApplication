//using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SqlApplication
{
   public class UseDb
   {
      Parameter pm = new Parameter();
      
      internal Boolean CreateDatabase()
      {
         Boolean   createDbSuccess  = false;
         String connectionStringNew = pm.ConnectionDataNew();
         String    connectionString = pm.GetConnectionData();
         String    table            = pm.GetTable();
         String[]  clm              = pm.GetColumns();
         String[]  clT              = pm.GetColumnTypes();
         using var con1             = new MySqlConnection(connectionStringNew);  
         using var con2             = new MySqlConnection(connectionString);
         using var cmd              = new MySqlCommand();
         try
         {
            con1.Open();                                                // create database
            cmd.Connection  = con1;
            cmd.CommandText = @" CREATE DATABASE test;";
            cmd.ExecuteNonQuery();
            con1.Close();
            
            con2.Open();                                                // create Table
            cmd.Connection = con2;
            cmd.CommandText = @"CREATE TABLE " + table + "(";
            for (int i = 0; i < clm.GetLength(0); i++) 
            { 
               cmd.CommandText += clm[i] +" " + clT[i] + ", ";
            }
            cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 2);
            cmd.CommandText += ");";
            cmd.ExecuteNonQuery();
            createDbSuccess = true;
            con2.Close();
            return (createDbSuccess);
         }
         catch
         {
            Exception e;
            return (createDbSuccess);
         }
      }

      internal Boolean FillTable()                                      // fill table with default data
      {        
         Boolean   createFillSuccess = false;
         String table                = pm.GetTable();
         String[]  clm               = pm.GetColumns();
         String[,] cars              = pm.GetCars();
         String    connectionString  = pm.GetConnectionData();
         using var con               = new MySqlConnection(connectionString);
         using var cmd               = new MySqlCommand();
         try
         {
            con.Open();
            cmd.Connection = con;
            for (int i = 0; i < cars.GetLength(0); i++)   
            {
               cmd.CommandText = @"INSERT INTO " + table + "(";
               for (int j = 1; j < clm.GetLength(0); j++)
               {
                  cmd.CommandText += clm[j] + ", ";
               }
               cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 2);
               cmd.CommandText += ") VALUES ( '";
               for (int j = 0; j < clm.GetLength(0) -1; j++)
               {
                  cmd.CommandText += cars[i, j] + "', '";
               }
               cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 3);
               cmd.CommandText += ");";
               cmd.ExecuteNonQuery();
            }
            con.Close();
            return (createFillSuccess = true);
         }
         catch
         {
            Exception e;
            return (createFillSuccess);
         }
      }

      internal String GetLastRecordId()
      {
         int lr;
         String lastRecordId;
         String table = pm.GetTable();
         String connectionString = pm.GetConnectionData();
         using var con = new MySqlConnection(connectionString);
         using var cmd = new MySqlCommand();      
         try
         {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"SELECT max(id) FROM " + table + ";";
            cmd.ExecuteNonQuery();
            using MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            lr = Convert.ToInt16(rdr.GetValue(0)) + 1;                           // 16 oder 32 ??? beides läuft.
            lastRecordId = lr.ToString();
            rdr.Close();
            con.Close();
            return (lastRecordId);
         }
         catch 
         { 
            Exception e;
            return ("e"); 
         }
      }

      internal void AddCarExec(String newManuf, String newModel, String newBuilt)
      {
         String message          = "New Record Inserted";
         String table            = pm.GetTable();
         String[] columns        = pm.GetColumns();
         String connectionString = pm.GetConnectionData();
         using var con           = new MySqlConnection(connectionString);
         using var cmd           = new MySqlCommand();
         try
         {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO " + table + "(" + columns[1] + "," + columns[2] + "," + columns[3] + ")" +
                               "VALUES('" + newManuf + "','" + newModel + "','" + newBuilt + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(message);
         }
         catch
         {
            Exception e;
           }
      }

      internal void DeleteCar(String row)
      {
         String table = pm.GetTable();
         String connectionString = pm.GetConnectionData();
         using var con = new MySqlConnection(connectionString);
         using var cmd = new MySqlCommand();
         try
         {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = @"DELETE FROM " + table + " WHERE id = '" + row + "';";
            cmd.ExecuteNonQuery();
            con.Close();
         }
         catch
         {
            Exception e;
         }
      }

      internal Boolean GetData(DataGridView dgv)                  // Hier nochmal aufräumen
      {
         String[] clm = pm.GetColumns();
         DataTable dataTable = new DataTable();
         DataSet dataSet = new DataSet();
         dgv.DataSource = dataTable;
         dataSet.Tables.Add(dataTable);
         for (int i = 0; i < clm.Length; i++)
         {
            dataTable.Columns.Add(new DataColumn(clm[i], typeof(String)));
         }

         Boolean dbExists = false;
         DataRow dataRow;
         String table = pm.GetTable();
         String connectionString = pm.GetConnectionData();
         using var con = new MySqlConnection(connectionString);
         try
         {
            con.Open();
            String query = @"SELECT * FROM " + table + ";";
            using var cmd = new MySqlCommand(query, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
               dataRow = dataTable.NewRow();
               for (int i = 0; i < rdr.FieldCount; i++)      // O.K. so?
               {
                  dataRow[i] = rdr.GetValue(i);              // O.K. so? Im DataTable sind alle Zellen als String deklariert.
               }                                             //          In der Sql Tabelle ist id aber integer.
               dataTable.Rows.Add(dataRow);
            }
            rdr.Close();
            con.Close();
            dbExists = true;
            return (dbExists);
         }
         catch
         {
            Exception e;
            return (dbExists);
         }
      }
   }
}
