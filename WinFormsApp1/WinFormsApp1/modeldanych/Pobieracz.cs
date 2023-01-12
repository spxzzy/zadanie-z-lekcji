using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.modeldanych
{
    public class Pobieracz
    {
        public List<Osoba> listaOsob { get; set; }
        public Pobieracz()
        {
            listaOsob = new List<Osoba>();
        }

        public void PobierzDane()
        {
            string baza = @"Data Source = Uczestnicy1.db";
            SqliteConnection connection = new SqliteConnection(baza);
            connection.Open();

            var command = connection.CreateCommand();
            string sql = "select Id, Imie, Nazwisko, Data_Urodzenia, " + "Srednia_Ocen, Poziom_Angielski from Osoba";
            command.CommandText = sql;
            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                string imie = reader.GetString(reader.GetOrdinal("Imie"));
                string nazwisko = reader.GetString(reader.GetOrdinal("Nazwisko"));
                DateTime dt = reader.GetDateTime(reader.GetOrdinal("Data_Urodzenia"));
                decimal sred = reader.GetDecimal(reader.GetOrdinal("Srednia_Ocen"));
                string ang = reader.GetString(reader.GetOrdinal("Poziom_Angielski"));
                listaOsob.Add(new Osoba(id, imie, nazwisko, dt, sred, ang));
            }

            connection.Close();
            connection.Dispose();
        }

    }
}
