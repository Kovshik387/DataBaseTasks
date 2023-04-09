using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTasks.Service
{
    public class ClientService
    {
        public DataTable FetchOrderGroup(NpgsqlDataAdapter adapter, string connectionString)
        {
            var dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                
                adapter = new NpgsqlDataAdapter( //"select * from public.\"test\""
                        @"SELECT public.""Users"".""Name"" AS Имя, COUNT(""съёмщик"".""ID_T"") AS Колво_Квартир, SUM(""контракт"".""PaymentSize"") AS ОплатаВмесяц from public.""Users""
                            JOIN public.""Tenant"" AS съёмщик ON ""съёмщик"".""ID_U"" = public.""Users"".""ID_U""
                            JOIN public.""Solution"" AS договор ON ""договор"".""UD_T"" = ""съёмщик"".""ID_T""
                            JOIN public.""Contract"" AS контракт ON ""контракт"".""ID_Solution"" = договор.""ID_Solution""
                        GROUP BY public.""Users"".""Name"""
                        , connection
                );
                
                adapter.Fill(dataTable);
                
                connection.Close();

                Console.WriteLine("Команда выполнена успешно");
            }

            return dataTable;
        }

        public DataTable FetchOrderHaving(NpgsqlDataAdapter adapter, string connectionString)
        {
            var dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                adapter = new NpgsqlDataAdapter( //"select * from public.\"test\""
                        @"SELECT public.""Users"".""Name"" AS Имя, COUNT(""съёмщик"".""ID_T"") AS Колво_Квартир, SUM(""контракт"".""PaymentSize"") AS ОплатаВмесяц from public.""Users""
                            JOIN public.""Tenant"" AS съёмщик ON ""съёмщик"".""ID_U"" = public.""Users"".""ID_U""
                            JOIN public.""Solution"" AS договор ON ""договор"".""UD_T"" = ""съёмщик"".""ID_T""
                            JOIN public.""Contract"" AS контракт ON ""контракт"".""ID_Solution"" = договор.""ID_Solution""
                        GROUP BY public.""Users"".""Name""
                        HAVING COUNT(1) > 1
                        "
                        
                        , connection
                );

                adapter.Fill(dataTable);

                connection.Close();

                Console.WriteLine("Команда выполнена успешно");
            }

            return dataTable;
        }
    }
}
