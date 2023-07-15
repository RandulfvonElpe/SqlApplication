using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SqlApplication
{
   public class Parameter
   {
      String connectionDataNew = @"server=192.168.0.47;userid=ralf;password=ralf;";
 //     String connectionDataNew = @"server=192.168.137.22;userid=ralf;password=ralf;";     
      String connectionData = @"server=192.168.0.47;userid=ralf;password=ralf;database=test";
//      String connectionData = @"server=192.168.137.22;userid=ralf;password=ralf;database=test";
      String database  =    "test";
      String    table  =    "cars";
      String[]  clm    =  { "id", "name", "model", "built" };
      String[]  clT    =  { "INTEGER PRIMARY KEY AUTO_INCREMENT", "TEXT", "TEXT", "TEXT"};
      String[,] cars   = {{ "Buick", "Wildcat", "1972" },
                          { "Chevrolet", "Impala", "1968"},           
                          { "Chevrolet", "El Camino", "1984" ,},                       
                          { "Ford", "F1", "1951" },
                          { "Ford", "F250", "1981" } };

      public Parameter() { }
      public String ConnectionDataNew() { return connectionDataNew; } 
      public String GetConnectionData() { return connectionData; }
      public String GetDatabase() { return database; }
      public String GetTable() { return table; }
      public String[] GetColumns() { return clm; }
      public String[] GetColumnTypes() { return clT; }
      public String[,] GetCars() { return cars; }
   }
}
