using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FoodRepository
    {
        public List<Food> GetAll()
        {
            List<Food> food = new List<Food>();
            using ( SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT*FROM MeatSeaFood";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Food f = new Food();
                    f.Id = sqlDataReader.GetInt32(0);
                    f.ProductName = sqlDataReader.GetString(1);
                    f.ProductDescription = sqlDataReader.GetString(2);
                    f.ProductQuantity = sqlDataReader.GetString(3);
                    f.ProductPrice = sqlDataReader.GetDecimal(4);
                    f.ProductDiscount = sqlDataReader.GetBoolean(5);
                    f.InStock = sqlDataReader.GetInt32(6);
                    food.Add(f);
                }
            }
            return food;
        }

        public int Insert (Food f)
        {
            using(SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO MeatSeaFood VALUES ('{0}','{1}','{2}',{3},{4},{5})", f.ProductName, f.ProductDescription, f.ProductQuantity, f.ProductPrice, f.ProductDiscount, f.InStock);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
