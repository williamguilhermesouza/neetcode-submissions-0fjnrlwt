public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var par = new int[n];
        var rank = new int[n];
        Array.Fill(rank, 1);

        foreach(var x in Enumerable.Range(0, n))
            par[x] = x;

        int find(int n1)
        {
            var res = n1;

            while (res != par[res])
            {
                par[res] = par[par[res]];
                res = par[res];
            }

            return res;
        }

        int union(int n1, int n2)
        {
            var p1 = find(n1);
            var p2 = find(n2);

            if (p1 == p2)
                return 0;
            
            if (rank[p2] > rank[p1])
            {
                par[p1] = p2;
                rank[p2] += rank[p1];
            }
            else
            {
                par[p2] = p1;
                rank[p1] += rank[p2];
            }
            return 1;
        }

        var res = n;
        foreach(var ed in edges)
        {
            var n1 = ed[0];
            var n2 = ed[1];
            res -= union(n1, n2);
        }

        return res;
    }
}
