using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution
{
    public int solution(int[,] maps)
    {
        int sizeX = maps.GetLength(0);
        int sizeY = maps.GetLength(1);
        Board board = new Board(sizeX, sizeY);
        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                if (maps[x, y] == 0)
                {
                    board.board[x, y].wall = true;
                }
            }
        }
        Block start = board.board[0, 0];
        Block finish = board.board[sizeX - 1, sizeY - 1];
        start = AStar.GetAStarFinding(board, start, finish);
        int result = 1;
        Block current = start;
        if (finish.prev == null)
            return -1;
        while (current != finish)
        {
            if (current.next.x - current.x != 0 && current.next.y - current.y != 0)
                result++;
            current = current.next;
            result++;
        }
        return result;
    }
}
public class AStar
{
    public static Block GetAStarFinding(Board board, Block start, Block finish)
    {
        if (board.Exist(start) && board.Exist(finish))
        {
            board.Clear();
            List<Block> OpenList = new List<Block>();
            List<Block> CheckList = new List<Block>();
            start.H = (Math.Abs(finish.x - start.x) + Math.Abs(finish.y - start.y)) * 10;
            Block current = start;
            while (current != null)
            {
                List<Block> arround = board.GetArroundBlock(board, current);
                List<Block> OpenAround = new List<Block>();
                foreach (Block block in arround)
                {
                    FuncHeuristics(block, current, finish, out int aroundG, out int aroundH);
                    if (aroundG + aroundH <= current.F) // 해당 블럭의 F값이 더 작을 경우 OpenList에서 제거
                    {
                        OpenList.Remove(block);
                        block.isOpen = false;
                    }
                    if (!block.isOpen && !block.isCheck)
                    {
                        block.G = aroundG;
                        block.H = aroundH;
                        block.prev = current;
                        block.isOpen = true;
                        OpenList.Add(block);
                        OpenAround.Add(block);
                    }
                }
                current.isCheck = true;
                if (OpenList.Remove(current))
                    CheckList.Add(current);
                if (OpenAround.Count > 0)
                {
                    current = GetNextBlock(OpenAround, current); // F값이 가장 낮은값 선정
                }
                else
                {
                    current = null;
                }
                if (current == finish)
                    break;
                if (current == null)
                {
                    current = GetNextBlock(OpenList); // 만약 주변이 막힌길이라면 갈수있던곳중 가장 F가 낮았던 블럭으로 이동
                }
            }
            if (current != finish)
                return null;
            while (current != start)
            {
                current.prev.next = current;
                current = current.prev;
            }
            return start;
        }
        return null;
    }
    private static Block GetNextBlock(List<Block> OpenArround)
    {
        Block result = null;
        for (int i = 0; i < OpenArround.Count; i++)
        {
            if (result == null || result.F > OpenArround[i].F)
                result = OpenArround[i];
        }
        return result;
    }
    private static Block GetNextBlock(List<Block> OpenArround, Block current)
    {
        Block result = null;
        for (int i = 0; i < OpenArround.Count; i++)
        {
            if (result == null || result.F > OpenArround[i].F)
                result = OpenArround[i];
        }
        if (result.F > current.F)
            result = null;
        return result;
    }
    // 새로구한 F값이 더 높으면 다시 그값으로 F값을 넣게 바꿔야함
    private static void FuncHeuristics(Block around, Block current, Block finish, out int aroundG, out int aroundH)
    {
        aroundG = around.G;
        aroundH = around.H;
        bool isDiagonalBlock = around.x - current.x != 0 && around.y - current.y != 0;
        aroundG = current.G + (isDiagonalBlock ? 14 : 10);
        aroundH = (Math.Abs(finish.x - around.x) + Math.Abs(finish.y - around.y)) * 10;
    }
}
public class Block
{
    public int x, y;
    public bool wall;
    public int F => G + H;
    public int G;
    public int H;
    public bool isOpen;
    public bool isCheck;
    public Block prev;
    public Block next;
    public Block(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void SetPrice(int G, int H)
    {
        this.G = G;
        this.H = H;
    }
    public void Clear()
    {
        G = 0;
        H = 0;
        isOpen = false;
        isCheck = false;
        prev = null;
        next = null;
    }
}
public class Board
{
    public Block[,] board { get; private set; }
    public int sizeX { get; private set; }
    public int sizeY { get; private set; }
    public Board(int sizeX, int sizeY)
    {
        board = new Block[sizeX, sizeY];
        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                board[x, y] = new Block(x, y);
            }
        }
        this.sizeX = sizeX;
        this.sizeY = sizeY;
    }
    public void Clear()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                board[i, j].Clear();
            }
        }
    }
    public bool Exist(Block block)
    {
        return Exist(block.x, block.y);
    }
    public bool Exist(int x, int y)
    {
        if (0 <= x && x < sizeX &&
             0 <= y && y < sizeY)
            return true;
        return false;
    }
    public List<Block> GetArroundBlock(Board board, Block current)
    {
        List<Block> around = new List<Block>();
        if (Exist(current.x, current.y - 1))// 상단
        {
            Block Block = board.board[current.x, current.y - 1];
            around.Add(Block);
        }
        if (Exist(current.x - 1, current.y))// 좌측
        {
            Block Block = board.board[current.x - 1, current.y];
            around.Add(Block);
        }
        if (Exist(current.x + 1, current.y))// 우측
        {
            Block Block = board.board[current.x + 1, current.y];
            around.Add(Block);
        }
        if (Exist(current.x, current.y + 1))// 하단
        {
            Block Block = board.board[current.x, current.y + 1];
            around.Add(Block);
        }
        if (Exist(current.x - 1, current.y - 1))// ↖
        {
            Block Block = board.board[current.x - 1, current.y - 1];
            around.Add(Block);
        }
        if (Exist(current.x + 1, current.y - 1))// ↗
        {
            Block Block = board.board[current.x + 1, current.y - 1];

            around.Add(Block);
        }
        if (Exist(current.x - 1, current.y + 1))// ↙
        {
            Block Block = board.board[current.x - 1, current.y + 1];
            around.Add(Block);
        }
        if (Exist(current.x + 1, current.y + 1))// ↘
        {
            Block Block = board.board[current.x + 1, current.y + 1];
            around.Add(Block);
        }
        for (int i = around.Count - 1; i >= 0; i--)
        {
            Block block = around[i];
            bool isDiagonalBlock = block.x - current.x != 0 && block.y - current.y != 0;
            if (isDiagonalBlock)
            {
                if (around.Find(b => b.x == block.x && b.y == current.y).wall ||
                   around.Find(b => b.x == current.x && b.y == block.y).wall)
                    around.Remove(block);
            }
        }
        around.RemoveAll(b => b.wall);
        return around;
    }

}
