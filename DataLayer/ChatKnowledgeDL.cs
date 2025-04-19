using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer
{
    public class ChatKnowledgeDL
    {
        private DataProvider provider = new DataProvider();

        // Lấy câu trả lời theo câu hỏi
        public (string answer, bool isSql)? GetAnswerByQuestion(string question)
        {
            string sql = "SELECT Answer, IsSql FROM ChatKnowledge WHERE Question = @q";
            SqlParameter[] parameters = {
                new SqlParameter("@q", question.ToLower())
            };

            DataTable dt = provider.MyExecuteReader(sql, CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                string answer = dt.Rows[0]["Answer"].ToString();
                bool isSql = Convert.ToBoolean(dt.Rows[0]["IsSql"]);
                return (answer, isSql);
            }

            return null;
        }

        // Thêm câu hỏi và câu trả lời mới
        public bool InsertNewQA(string question, string answer, bool isSql)
        {
            string sql = "INSERT INTO ChatKnowledge (Question, Answer, IsSql) VALUES (@q, @a, @isSql)";
            SqlParameter[] parameters = {
                new SqlParameter("@q", question.ToLower()),
                new SqlParameter("@a", answer),
                new SqlParameter("@isSql", isSql)
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }

        // Thực thi câu SQL động
        public DataTable ExecuteDynamicSql(string sql)
        {
            try
            {
                return provider.MyExecuteReader(sql, CommandType.Text);
            }
            catch (Exception ex)
            {
                // Trả về null để xử lý lỗi bên ngoài
                return null;
            }
        }




        // Phương thức xóa câu hỏi và câu trả lời
        public bool DeleteQA(string question)
        {
            string sql = "DELETE FROM ChatKnowledge WHERE Question = @q";
            SqlParameter[] parameters = {
                new SqlParameter("@q", question.ToLower())
            };

            return provider.MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
    }
}
