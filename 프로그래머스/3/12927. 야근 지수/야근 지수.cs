using System;
using System.Linq;

public class Solution {
    public long solution(int n, int[] works)
    {
        PriorityQueue<int> qp = new PriorityQueue<int>();
        for (int i = 0; i < works.Length; i++)
        {
            int element = works[i];
            qp.Enqueue(element);
        }
        while (n > 0)
        {
            //우선순위 큐를 이용해서 현재 값 꺼냄
            int now = qp.Dequeue();
            //Peek을 통해 다음꺼와의 차를 구해서 n비교
            int next = qp.Peek();
            int compare = now - next;
            int subValue = 1; // 뺄 값
            if (compare > n)
            {
                //n이 더 작으면 현재 값에서 n만큼 뻄
                subValue = n;
            }
            else if (0 < compare && compare < n)
            {
                //n이 더 크면 현재 값에서 다음꺼만큼 뺌
                subValue = compare;
            }
            else if (compare == n)
            {
                //같다면 1씩 계속 빼야함
                subValue = 1;
            }
            if (now > 0)
            {
                now -= subValue;                                             
            }
            //뺸 값만큼 n에서 뺌
            n -= subValue;
            //빼고 다시 큐에 삽임
            qp.Enqueue(now);
            //n이 0이 될때까지 반복
        }
        long result = 0;
        for (int i = 0; i < works.Length; i++)
        {
            int value = qp.Dequeue();
            result += value * value;
        }
        return result;
    }
}

public class PriorityQueue<T> where T : IComparable<T>
{
    public T[] data { get; private set; }
    public int Count { get; private set; }
    public int Capacity { get; private set; }
    #region 생성자
    // 기본 생성자
    public PriorityQueue()
    {
        Count = 0;
        Capacity = 1;
        data = new T[Capacity];
    }
    // 초기 Capacity 지정 생성자
    public PriorityQueue(int capacity)
    {
        Count = 0;
        Capacity = capacity;
        data = new T[Capacity];
    }
    #endregion
    #region public function
    public void Enqueue(T value)
    {
        // data 배열이 꽉 찼다면 확장
        if (Count >= Capacity)
            Expand();
        // 데이터 추가
        data[Count] = value;
        Count++;
        // 힙 트리를 유지하기 위해 데이터 교환
        // 새로 추가한 노드부터 부모 노드와 비교하여 더 크다면 
        int now = Count - 1;
        while (now > 0)
        {
            int parent = (now - 1) / 2;
            // 부모 노드의 값이 더 크다면 정지
            if (data[now].CompareTo(data[parent]) < 0)
                break;
            // 값 교환
            T temp = data[now];
            data[now] = data[parent];
            data[parent] = temp;
            // 현재 위치 갱신
            now = parent;
        }
    }
    public T Dequeue()
    {
        // Count가 0이라면 예외 발생
        if (Count == 0)
            throw new IndexOutOfRangeException();
        // 루트 노드 값 추출
        // 마지막 노드와 교환 후 제거
        T result = data[0];
        data[0] = data[Count - 1];
        data[Count - 1] = default(T);
        Count--;
        // 힙 트리를 유지하도록 데이터 교환
        // 루트부터 시작하여 자식 노드 중 큰 쪽과 비교, 현재 노드가 더 작다면 교환
        int now = 0;
        while (now < Count)
        {
            int left = (now * 2) + 1;
            int right = (now * 2) + 2;
            int next = now;
            // 왼쪽 노드가 존재하고 값이 더 크다면 next 갱신 
            if (left < Count && data[next].CompareTo(data[left]) < 0)
                next = left;
            // 오른쪽 노드가 존재하고 값이 더 크다면 next 갱신 
            if (right < Count && data[next].CompareTo(data[right]) < 0)
                next = right;
            // 갱신되지 않았다면 루프 종료
            if (next == now)
                break;
            // 값 교환
            T temp = data[now];
            data[now] = data[next];
            data[next] = temp;
            // 현재 위치 갱신
            now = next;
        }
        return result;
    }
    public T Peek()
    {
        // Count가 0이라면 예외 발생
        if (Count == 0)
            throw new IndexOutOfRangeException();
        return data[0];
    }
    #endregion
    #region private function
    // data 배열 확장용
    // 기존 Capacity의 2배로 확장
    void Expand()
    {
        T[] newData = new T[Capacity * 2];
        for (int i = 0; i < Count; i++)
            newData[i] = data[i];
        data = newData;
        Capacity *= 2;
    }
    #endregion
}