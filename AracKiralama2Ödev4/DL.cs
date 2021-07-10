using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama2Ödev4
{ /*
    create table araclar
(
Plaka varchar(32) primary key,
Marka  varchar(32) ,
Model  varchar(32) ,
Yakit varchar(32) ,
Renk varchar(32) ,
vites  varchar(32) ,
KasaTipi varchar(32) ,
GünlükFiyat varchar(32),
Durum varchar(32)
);
drop table araclar;

create table kiralama
(
 KiralamaID int primary key AUTO_INCREMENT,
 Plaka varchar(32) ,
 TC varchar(32) ,
 Ad varchar(32) ,
 Soyad varchar(32) ,
 Telefon varchar(36) ,
 Mail varchar(100) ,
 Adres varchar(55) ,
 KiralamaTarihi date,
 TeslimTarihi date,
 Tutar int,
 ÖdemeTürü varchar(32),
 FOREIGN key (Plaka) REFERENCES araclar(Plaka)

);
DROP TABLE kiralama;
     */
    class DL
    {
        MySqlConnection con = new MySqlConnection(new MySqlConnectionStringBuilder()
        {
            Server = "78.135.82.146",
            Database = "19015221013_db",
            UserID = "19015221013",
            Password = "19015221013"
        }.ConnectionString);

        DataTable dataTable;
        public DataTable MtdListele(MySqlDataAdapter da, string sql)
        {
            dataTable = new DataTable();
            da = new MySqlDataAdapter(sql, con);
            da.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public void InsertUpdateDele(MySqlCommand command, string sorgu)
        {
            con.Open();
            command.Connection = con;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
