using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleRollUp.Domain {
    public class Generator {
        public string BuildTriangle(List<int> nums) {
            if (nums.Count == 0) return String.Empty;
            if (nums.Count == 1) return String.Format("{0}\n", nums[0]);

            return GetStringFromTriangle(BuildIntTriangle(nums));
        }

        private Stack<List<int>> BuildIntTriangle(List<int> nums) {
            List<int> current = nums;
            Stack<List<int>> triangle = new Stack<List<int>>();
            triangle.Push(null);
            do {
                triangle.Push(current);
                List<int> next = new List<int>();
                int back = 0;
                int front = 1;
                while (front < current.Count) {
                    next.Add(current[back++] + current[front++]);
                }
                current = next;
            } while (current.Count > 1);
            triangle.Push(current);

            return triangle;
        }

        private string GetStringFromTriangle(Stack<List<int>> triangle) {
            int tabs = triangle.Count - 2;
            StringBuilder sb = new StringBuilder();
            List<int> row = triangle.Pop();
            while (row != null) {
                for (int i = 0; i < tabs; i++) {
                    sb.Append("\t");
                }
                for (int i = 0; i < row.Count; i++) {
                    sb.Append(row[i]);
                    sb.Append("\t\t");
                }
                sb.Append("\n");

                tabs--;
                row = triangle.Pop();
            }

            return sb.ToString();
        }
    }
}
