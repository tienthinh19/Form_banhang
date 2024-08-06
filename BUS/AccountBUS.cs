using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BuiTienThinh_22102363.DAO;
using BuiTienThinh_22102363.DTO;

namespace BuiTienThinh_22102363.BUS
{
    internal class AccountBUS
    {
        private AccountDAO accountDAO;

        public AccountBUS()
        {
            accountDAO = new AccountDAO();
        }

        public List<Account> GetAll()
        {
            List<Account> accountList = new List<Account>();
            DataTable dt = accountDAO.GetAll(); 
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Account account = new Account
                    {
                        Id = (int)dr["Id"],
                        Email = dr["Email"].ToString(),
                        FullName = dr["FullName"].ToString(),
                        RoleId = dr["RoleId"].ToString(),
                        Password = dr["Password"].ToString()
                    };
                    accountList.Add(account);
                }
            }
            return accountList;
        }

        public List<Account> SearchAccounts(string keyword)
        {
            List<Account> accountList = new List<Account>();
            DataTable dt = accountDAO.SearchAccounts(keyword); // Sử dụng instance accountDAO để gọi phương thức SearchAccounts
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Account account = new Account
                    {
                        Id = (int)dr["Id"],
                        Email = dr["Email"].ToString(),
                        FullName = dr["FullName"].ToString(),
                        RoleId = dr["RoleId"].ToString(),
                        Password = dr["Password"].ToString()
                    };
                    accountList.Add(account);
                }
            }
            return accountList;
        }
        public void Insert(Account account)
        {
            account.Password = FunctionHelper.HashPassword(account.Password);
            accountDAO.Insert(account);
        }
        public bool ValidateCredentials(string email, string password)
        {
            string hashedPassword = FunctionHelper.HashPassword(password);
            return accountDAO.ValidateCredentials(email, password);
        }
        public void Update(Account account)
        {
            string query = "UPDATE [Account] SET Email = @Email, FullName = @FullName, RoleId = @RoleId, Password = @Password WHERE Id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@Id", SqlDbType.Int) { Value = account.Id },
        new SqlParameter("@Email", SqlDbType.NVarChar) { Value = account.Email },
        new SqlParameter("@FullName", SqlDbType.NVarChar) { Value = account.FullName },
        new SqlParameter("@RoleId", SqlDbType.NVarChar) { Value = account.RoleId },
        new SqlParameter("@Password", SqlDbType.NVarChar) { Value = account.Password }
            };

            SqlDataAccessHelper.ExecuteNonQuery(query, sqlParameters);
        }

    }
}
