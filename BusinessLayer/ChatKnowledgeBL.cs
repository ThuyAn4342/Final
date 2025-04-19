using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using DataLayer;

namespace BusinessLayer
{
    public class ChatKnowledgeBL
    {
        private ChatKnowledgeDL chatDAL = new ChatKnowledgeDL();

        // Kiểm tra câu lệnh SQL có nguy hiểm không
        private bool IsSqlInjectionRisky(string query)
        {
            string[] dangerousKeywords = new string[] { "drop", "delete", "truncate", "update", "insert", "alter", "union", "exec"};
            query = query.ToLower();

            foreach (var keyword in dangerousKeywords)
            {
                if (query.Contains(keyword))
                    return true;
            }
            return false;
        }

        public string LearnNewResponse(string input, bool confirmUpdate = false)
        {
            if (!input.StartsWith("dạy:")) return "Câu lệnh học không đúng định dạng.";

            try
            {
                string[] parts = input.Substring(4).Split('|');

                if (parts.Length < 2)
                    return "Định dạng sai. Đúng: dạy: câu hỏi | câu trả lời | [sql]";

                string question = parts[0].Trim().ToLower();
                string answer = parts[1].Trim();
                bool isSql = parts.Length > 2 && parts[2].Trim().ToLower() == "sql";

                // ⚠️ Kiểm tra câu SQL có nguy hiểm không (nếu là SQL)
                if (isSql && IsSqlInjectionRisky(answer))
                {
                    return "Câu trả lời SQL không hợp lệ hoặc có nguy cơ nguy hiểm cho cơ sở dữ liệu!";
                }

                var existing = chatDAL.GetAnswerByQuestion(question);
                if (existing != null && !confirmUpdate)
                {
                    return "Câu hỏi đã tồn tại. Có muốn cập nhật không?";
                }

                // Nếu xác nhận cập nhật: xóa và thêm mới
                if (existing != null)
                {
                    chatDAL.DeleteQA(question);
                }

                bool success = chatDAL.InsertNewQA(question, answer, isSql);
                return success
                    ? (existing != null ? "Tôi đã cập nhật câu trả lời!" : "Tôi đã học câu trả lời mới!")
                    : "Không thể lưu dữ liệu.";
            }
            catch
            {
                return "Lỗi khi dạy. Định dạng: dạy: câu hỏi | câu trả lời | [sql]";
            }
        }


        public string GetResponse(string input)
        {
            input = input.Trim().ToLower();

            var result = chatDAL.GetAnswerByQuestion(input);
            if (result != null)
            {
                var (answer, isSql) = result.Value;

                if (!isSql)
                    return answer;

                // Trả về DataTable, đúng kiểu dữ liệu
                DataTable table = chatDAL.ExecuteDynamicSql(answer);

                if (table == null || table.Rows.Count == 0)
                    return "Không có dữ liệu.";

                // Xử lý kết quả
                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sb.Append(item.ToString() + " ");
                    }
                    sb.AppendLine(); // Xuống dòng giữa các bản ghi
                }

                return sb.ToString().Trim();
            }

            return "Tôi chưa biết câu này. Bạn có muốn dạy tôi không? Gõ: 'dạy: câu hỏi | câu trả lời | sql (nếu là câu sql)'";
        }



    }
}
