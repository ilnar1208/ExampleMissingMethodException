using System;
using Npgsql;

namespace Example
{
    class Program
    {
        public class Result
        {
            public DateTime result_date { get; set; }
            public decimal? result_value { get; set; }
        }

        static void Main(string[] args)
        {
            var connectionString = "Host=127.0.0.1;Port=5432;Username=postgres;Password=herfvbytnhjufnm;Database=postgres;Load Table Composites=true";
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            connection.TypeMapper.MapComposite<Result>("test.results"); // works fine
            connection.TypeMapper.MapComposite(typeof(Result), "test.results"); // throws excepion
        }
    }
}
