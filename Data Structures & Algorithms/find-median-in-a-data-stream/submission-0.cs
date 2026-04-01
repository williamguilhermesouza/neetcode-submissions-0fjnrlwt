public class MedianFinder {
    // upper = max-heap (smaller half)
    PriorityQueue<int, int> upper =
        new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

    // lower = min-heap (larger half)
    PriorityQueue<int, int> lower = new PriorityQueue<int, int>();

    public MedianFinder() { }
    
    public void AddNum(int num) {

        // step 1: add to upper (max-heap)
        upper.Enqueue(num, num);

        // step 2: ensure ordering (max(upper) <= min(lower))
        if (lower.Count > 0 && upper.Peek() > lower.Peek())
        {
            var u = upper.Dequeue();
            var l = lower.Dequeue();

            upper.Enqueue(l, l);
            lower.Enqueue(u, u);
        }

        // step 3: rebalance sizes
        if (upper.Count > lower.Count + 1)
        {
            var el = upper.Dequeue();
            lower.Enqueue(el, el);
        }
        else if (lower.Count > upper.Count + 1)
        {
            var el = lower.Dequeue();
            upper.Enqueue(el, el);
        }
    }
    
    public double FindMedian() {
        if (upper.Count > lower.Count) return upper.Peek();
        if (lower.Count > upper.Count) return lower.Peek();

        return (upper.Peek() + lower.Peek()) / 2.0;
    }
}