using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BuiTienThinh_22102363.DTO;


namespace BuiTienThinh_22102363.DAO
{
    internal class ProductDAO
    {
        public ProductDAO()
        {
            SqlDataAccessHelper sqlHelper = new SqlDataAccessHelper();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM [Product]";
            return SqlDataAccessHelper.ExecuteSelectAllQuery(query);
        }

        public DataTable GetProductByCategoryId(int _id)
        {
            string query = "SELECT * FROM [Product] WHERE CategoryId = @cateID";
            SqlParameter sqlParameter = new SqlParameter("@cateID", SqlDbType.Int)
            {
                Value = _id
            };
            try
            {
                return SqlDataAccessHelper.ExecuteSelectQuery(query, sqlParameter);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Error in GetProductByCategoryId: " + ex.Message);
                throw;
            }
        }
        public void InsertProduct(Product product)
        {
            string query = @"
            INSERT INTO [Product] (Description, Price, Discount, CategoryId, Picture)
            VALUES (@description, @price, @discount, @categoryId, @picture)";

            SqlParameter[] parameters = {
            new SqlParameter("@description", SqlDbType.NVarChar) { Value = product.Description },
            new SqlParameter("@price", SqlDbType.Float) { Value = product.Price },
            new SqlParameter("@discount", SqlDbType.Float) { Value = product.Discount },
            new SqlParameter("@categoryId", SqlDbType.Int) { Value = product.CategoryId },
            new SqlParameter("@picture", SqlDbType.VarBinary) { Value = product.Picture ?? (object)DBNull.Value }
        };

            try
            {
                SqlDataAccessHelper.ExecuteInsertQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Error in InsertProduct: " + ex.Message);
                throw;
            }
        }

        public void DeleteProduct(int productId)
        {
            string query = "DELETE FROM [Product] WHERE Id = @id";

            SqlParameter sqlParameter = new SqlParameter("@id", SqlDbType.Int) { Value = productId };

            try
            {
                SqlDataAccessHelper.ExecuteDeleteQuery(query, sqlParameter);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Error in DeleteProduct: " + ex.Message);
                throw;
            }
        }
        public bool UpdateProduct(Product product)
        {
            string query = "UPDATE Products SET Description = @Description, Price = @Price, Discount = @Discount, CategoryId = @CategoryId, Picture = @Picture WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", product.Id),
                new SqlParameter("@Description", product.Description),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@Discount", product.Discount),
                new SqlParameter("@CategoryId", product.CategoryId),
                new SqlParameter("@Picture", product.Picture ?? (object)DBNull.Value)
            };

            return SqlDataAccessHelper.ExecuteInsertQuery(query, parameters);
        }
        /*public DataTable SearchByName(string _username)
        {
            string query = "SELECT * FROM [t01_user] WHERE t01_firstname LIKE @t01_firstname";
            SqlParameter sqlParameter = new SqlParameter("@t01_firstname", SqlDbType.VarChar)
            {
                Value = "%" + _username + "%"
            };
            return SqlDataAccessHelper.ExecuteSelectQuery(query, new SqlParameter[] { sqlParameter });
        }*/
    }
}
