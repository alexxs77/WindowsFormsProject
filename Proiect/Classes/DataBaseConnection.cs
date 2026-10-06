using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Proiect.Classes
{
    internal class DataBaseConnection
    {
       public String? connString;
       public SqlConnection? connection;
       public SqlDataAdapter? adapter_utilizatori;
       public SqlDataAdapter? adapter_servicii;
       public SqlDataAdapter? adapter_programari;
       public SqlDataAdapter? adapter_plati;
       public SqlCommandBuilder? commandBuilder_utilizatori;
       public SqlCommandBuilder? commandBuilder_servicii;
       public SqlCommandBuilder? commandBuilder_programari;
       public SqlCommandBuilder? commandBuilder_plati;
       public DataTable table_utilizatori = new DataTable("Utilizatori");
       public DataTable table_servicii = new DataTable("Servicii");
       public DataTable table_programari = new DataTable("Programari");
       public DataTable table_plati = new DataTable("Plati");

        public DataBaseConnection()
        {
            connString = ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
            connection = new SqlConnection(connString);

            adapter_utilizatori = new SqlDataAdapter("SELECT Id, Username, Parola, Nume, Email, Rol FROM dbo.Utilizatori", connection);
            commandBuilder_utilizatori = new SqlCommandBuilder(adapter_utilizatori);

            adapter_servicii = new SqlDataAdapter("SELECT Id, Denumire, Descriere, Pret FROM dbo.Servicii", connection);
            commandBuilder_servicii = new SqlCommandBuilder(adapter_servicii);

            adapter_programari = new SqlDataAdapter("SELECT Id, IdUtilizator, Pacient, Serviciu, DataProgramare, Pret, Status FROM dbo.Programari", connection);
            commandBuilder_programari = new SqlCommandBuilder(adapter_programari);

            adapter_plati = new SqlDataAdapter("SELECT Id, IdProgramare, Suma, DataPlata, MetodaPlata, StatusPlata FROM dbo.Plati", connection);
            commandBuilder_plati = new SqlCommandBuilder(adapter_plati);
        }


    }
}
