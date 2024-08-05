using System;
using System.Collections.Generic;
using System.Data;
using BuiTienThinh_22102363.DAO;
using BuiTienThinh_22102363.DTO;

namespace BuiTienThinh_22102363.BUS
{
    internal class CategoryBUS
    {
        private CategoryDAO categoryDAO;
        public CategoryBUS()
        {
            categoryDAO = new CategoryDAO();
        }

        public List<Category> GetAll()
        {
            List<Category> catlist = new List<Category>();
            DataTable dt = categoryDAO.GetAll();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Category cate = new Category
                    {
                        CategoryId = (int)dr["Id"],
                        Name = dr["Name"].ToString(),
                        Picture = dr.IsNull("Picture") ? null : (byte[])dr["Picture"]
                    };
                    catlist.Add(cate);
                }
            }
            return catlist;
        }
        public DataTable GetAllTable()
        {
          
            DataTable dt = categoryDAO.GetAll();
         
            return dt;
        }
        public List<Category> SearchCategories(string keyword)
        {
            List<Category> catlist = new List<Category>();
            DataTable dt = categoryDAO.SearchCategories(keyword);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Category cate = new Category
                    {
                        CategoryId = (int)dr["Id"],
                        Name = dr["Name"].ToString(),
                        Picture = dr.IsNull("Picture") ? null : (byte[])dr["Picture"]
                    };
                    catlist.Add(cate);
                }
            }
            return catlist;
        }

        public void Insert(Category cate)
        {
            categoryDAO.Insert(cate);
        }
     
        public bool UpdateTable(DataTable dataTable)
        {
            return categoryDAO.UpdateTable(dataTable);
        }
    }
}
