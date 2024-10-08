using System;
using System.Collections.Generic;

// 1. 해당 네트워크를 그래프 형태로 변환
// 2. 방문하지 않았던 노드를 DFS로 탐색 , DFS로 탐색 성공한 노드는 방문했다고 체크(true 값으로 전환)
// 3. DFS 한 횟수 한번당 결과값에 1 추가
public class Solution {
    public  int solution(int n, int[,] computers){
        Graph graph = new Graph(n);        
        for(int i = 0;i<n;i++){
            for(int j = i ; j<n ;j++){
                if(i!=j && computers[i,j]==1)
                    graph.ConnectBoth(i,j);
            }
        }
        bool[] visited = new bool[n];
        for(int i = 0;i<n;i++){
            visited[i]=false;
        }
        //DFS로 한 노드에서 탐색, 탐색할수있는 모든 노드를 찾고 visited값 true로 바꿈 1회 탐색후 결과값에 1추가
        int result = 0;
        for(int i = 0 ; i < n ; i++){
            //visited값이 false인 값에서 탐색
            if(visited[i]==false){
                DFS(graph, i, visited);
                result++;
            }           
        }
        return result;
        
    }
    public void DFS(Graph graph, int start,bool[] visited){
        SearchNode(graph, start, visited);
    }
    
    public void SearchNode(Graph graph, int start, bool[] visited){
        visited[start]=true;
        for(int i = 0 ; i<graph.graph.GetLength(0);i++){
            if(graph.IsConnect(start,i) &&
              visited[i]==false){
                SearchNode(graph, i, visited);
            }
        }
    }    
}



public class Graph{
    public bool[,] graph;
    public Graph(int node){
        graph = new bool[node,node];
    }
    public void ConnectBoth(int a , int b){
        graph[a,b] = true;
        graph[b,a] = true;
    }
    public bool IsConnect(int a, int b){
        return graph[a,b];
    }
}