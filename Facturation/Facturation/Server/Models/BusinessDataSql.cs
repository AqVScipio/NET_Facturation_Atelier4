using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Facturation.Server.Models
{
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private SqlConnection cnct;

        public BusinessDataSql(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            cnct.Dispose();
        }

        public IEnumerable<Facture> Factures
            => cnct.Query<Facture>("SELECT * FROM Factures");

        public decimal CA 
            => cnct.QueryFirst<decimal>("select sum(f.Montant) from Factures f");
        public decimal Percu
            => cnct.QueryFirst<decimal>("select sum(f.MontantRegle) from Factures f");

        public void Add(Facture facture)
            => cnct.Execute("insert into Factures values (@Numero, @Client, @DateReglement, @Montant, @MontantRegle)", facture);

        public void Edit(Facture facture)
            => cnct.Execute("update Factures set Numero = @Numero, Client = @Client, DateReglement = @DateReglement, " +
                "Montant = @Montant, MontantRegle = @MontantRegle where Id = @Id", facture);

        public IEnumerable<Facture> GetFactures(DateTime? debut, DateTime? fin)
        {
            string sql = "select * from Factures f ";
            if(debut != null)
            {
                if(fin != null && fin > debut)
                    sql += string.Format("where DateReglement between {0} and {1}", debut.Value.ToShortDateString(), fin.Value.ToShortDateString());
                else
                    sql += string.Format("where DateReglement >= {0}", debut.Value.ToShortDateString());
            }
            else
                if (fin != null)
                    sql += string.Format("where DateReglement <= {0}", fin.Value.ToShortDateString());

            return cnct.Query<Facture>(sql);
        }

        public IEnumerable<Facture> GetFactures(string orderBy, string asc)
        {
            string sql = string.Format("select * from Factures f order by {0} {1}", orderBy, asc);
            return cnct.Query<Facture>(sql);
        }
    }
}

