using BuiTienThinh_22102363.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// thêm 1 hàm tìm kiếm
namespace BuiTienThinh_22102363.DAO
{
    internal class CategoryDAO
    {
        public CategoryDAO() {
            new SqlDataAccessHelper();
        }
        public DataTable GetAll()
        {
            string query = "select * from Category";
            DataTable dt = new DataTable();

            dt = SqlDataAccessHelper.ExecuteSelectAllQuery(query);

            return dt;
        }
        public void Insert(Category category)
        {
            string query = string.Format("Insert into [Category](Name,Picture) values (@Name,@Pic)");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            
               sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar) { Value = category.Name };
                sqlParameters[1] =  new SqlParameter("@Pic", SqlDbType.VarBinary) { Value = category.Picture };
       

             SqlDataAccessHelper.ExecuteInsertQuery(query, sqlParameters);
        }
        // Thêm hàm tìm kiếm category
        public DataTable SearchCategories(string keyword)
        {
            string query = "SELECT * FROM Category WHERE Name LIKE @Keyword";
            SqlParameter sqlParameter = new SqlParameter ("@Keyword", "%" + keyword + "%");

            DataTable dt = new DataTable();
            dt = SqlDataAccessHelper.ExecuteSelectQuery(query, sqlParameter);

            return dt;
        }
        public bool UpdateTable(DataTable cateTable)
        {
            string insQuery = string.Format("Insert into [Category](Name) values (@Name)");
            string updateQuery = string.Format("Update Category SET Name = @Name WHERE Id=@Id ");
            string delQuery = string.Format("Delete from Category WHERE Id=@Id");

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name");
            


            SqlParameter[] sqlParameters2 = new SqlParameter[2];
            sqlParameters2[0] = new SqlParameter("@Name", SqlDbType.VarChar, 15, "Name");
          
            sqlParameters2[1] = new SqlParameter("@Id", SqlDbType.Int, 0, "Id");

            SqlParameter[] sqlParameters3 = new SqlParameter[1];
            sqlParameters3[0] = new SqlParameter("Id", SqlDbType.Int, 0, "Id");



            return SqlDataAccessHelper.UpdateAdapter(insQuery, updateQuery, delQuery, sqlParameters, sqlParameters2, sqlParameters3, cateTable);


        }
    }
    
}
