using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Generate_Parentheses
{
    public class Solution
    {

        List<string> Parenthesislist { set; get; } = new List<string>();
        int N { set; get; }
        void DFS(int depth, int left, int right, string p)
        {
            if (depth < 2 * N)
            {
                if (right <= left && left <= N)
                {
                    DFS(depth + 1, left + 1, right, p + "(");
                    DFS(depth + 1, left, right + 1, p + ")");
                }
            }
            else
            {
                if (left == right)
                {
                    Parenthesislist.Add(p);
                }
            }
        }

        public IList<string> GenerateParenthesis(int n)
        {
            N = n;
            DFS(0, 0, 0, "");
            return Parenthesislist;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            (new Solution()).GenerateParenthesis(3);
        }
    }
}
