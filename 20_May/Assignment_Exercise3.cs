using System;

class Dijkstra
{
    const int V = 5;

    int MinDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
            if (!sptSet[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }

        return minIndex;
    }

    void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1) return;
        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }

    void PrintSolution(int[] dist, int[] parent, int src)
    {
        Console.WriteLine("Vertex\tDistance\tPath");
        for (int i = 0; i < V; i++)
        {
            Console.Write(src + " -> " + i + "\t" + dist[i] + "\t\t" + src);
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }

    public void DijkstraAlgo(int[,] graph, int src)
    {
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];
        int[] parent = new int[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
            parent[i] = -1;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet);
            sptSet[u] = true;

            for (int v = 0; v < V; v++)
                if (!sptSet[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    parent[v] = u;
                    dist[v] = dist[u] + graph[u, v];
                }
        }

        PrintSolution(dist, parent, src);
    }

    static void Main()
    {
        int[,] graph = {
            { 0, 10, 0, 30, 100 },
            { 10, 0, 50, 0, 0 },
            { 0, 50, 0, 20, 10 },
            { 30, 0, 20, 0, 60 },
            { 100, 0, 10, 60, 0 }
        };

        Dijkstra d = new Dijkstra();
        d.DijkstraAlgo(graph, 0);
    }
}
