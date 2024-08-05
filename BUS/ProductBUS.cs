using BuiTienThinh_22102363;
using BuiTienThinh_22102363.DAO;
using BuiTienThinh_22102363.DTO;
using System.Data;
using System.Data.SqlClient;

internal class ProductBUS
{
    private ProductDAO productDAO;

    public ProductBUS()
    {
        productDAO = new ProductDAO();
    }

    public List<Product> GetProductsByCategoryId(int categoryId)
    {
        try
        {
            DataTable dataTable = productDAO.GetProductByCategoryId(categoryId);
            List<Product> productList = new List<Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Product pro = new Product();
                pro.Id = Convert.ToInt32(dr["Id"]);
                pro.Description = dr["Description"].ToString();
                pro.Price = Convert.ToSingle(dr["Price"]);
                pro.Discount = Convert.ToSingle(dr["Discount"]);
                pro.CategoryId = Convert.ToInt32(dr["CategoryId"]);
                pro.Picture = dr["Picture"] as byte[];
                productList.Add(pro);
            }

            return productList;
        }
        catch (Exception ex)
        {
            // Hiển thị thông báo lỗi nếu có
            MessageBox.Show("Error in GetProductsByCategoryId: " + ex.Message);
            throw;
        }
    }
    public bool InsertProduct(Product product)
    {
        string query = "INSERT INTO [Product] (Description, Price, Discount, CategoryId, Picture) VALUES (@Description, @Price, @Discount, @CategoryId, @Picture)";

        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@Description", SqlDbType.NVarChar) { Value = product.Description },
            new SqlParameter("@Price", SqlDbType.Float) { Value = product.Price },
            new SqlParameter("@Discount", SqlDbType.Float) { Value = product.Discount },
            new SqlParameter("@CategoryId", SqlDbType.Int) { Value = product.CategoryId },
            new SqlParameter("@Picture", SqlDbType.VarBinary) { Value = product.Picture ?? (object)DBNull.Value }
        };

        try
        {
            return SqlDataAccessHelper.ExecuteInsertQuery(query, parameters);
        }
        catch (Exception ex)
        {
            // Hiển thị thông báo lỗi nếu có
            MessageBox.Show("Error in InsertProduct: " + ex.Message);
            return false;
        }
    }

    public bool DeleteProduct(int productId)
    {
        string query = "DELETE FROM [Product] WHERE Id = @Id";

        SqlParameter sqlParameter = new SqlParameter("@Id", SqlDbType.Int) { Value = productId };

        try
        {
            return SqlDataAccessHelper.ExecuteDeleteQuery(query, sqlParameter);
        }
        catch (Exception ex)
        {
            // Hiển thị thông báo lỗi nếu có
            MessageBox.Show("Error in DeleteProduct: " + ex.Message);
            return false;
        }
    }
    public bool UpdateProduct(Product product)
    {

        string query = "UPDATE Products SET Description = @Description, Price = @Price, Discount = @Discount, CategoryId = @CategoryId, Picture = @Picture WHERE Id = @Id";
        SqlParameter[] sqlParameters = new SqlParameter[]
        {
        new SqlParameter("@Description", product.Description),
        new SqlParameter("@Price", product.Price),
        new SqlParameter("@Discount", product.Discount),
        new SqlParameter("@CategoryId", product.CategoryId),
        new SqlParameter("@Picture", product.Picture ?? (object)DBNull.Value),
        new SqlParameter("@Id", product.Id)
        };
        return SqlDataAccessHelper.ExecuteInsertQuery(query, sqlParameters);
    }
}
