using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuiTienThinh_22102363
{
    internal class FunctionHelper
    {
        public static byte[] ConvertImageToBinary(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }

       public static Image ConvertBinaryToImage(byte[] data)
{
    if (data == null || data.Length == 0)
    {
        // Trả về null hoặc xử lý theo cách khác nếu dữ liệu là null hoặc rỗng
        return null;
    }

    using (MemoryStream ms = new MemoryStream(data))
    {
        ms.Seek(0, SeekOrigin.Begin);
        return Image.FromStream(ms);
    }
}

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string in hexadecimal format
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

    }
}
