using System;

class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    public Node Head
    {
        get {return head;}
        set {head = value;}
    }
    public Node Tail
    {
        get {return tail;}
        set {tail = value;}
    }

    public Type CheckType()
    {
        return typeof(T);
    }

    public void Enqueue(T newValue)
    {
        Node newNode = new Node(newValue);
        if (head == null)
        {
            head = newNode;
            newNode.Next = null;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            tail = newNode;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }

    public class Node
    {
        private T value = default(T);
        private Node next = null;

        public T Value
        {
            get {return this.value;}
            set {this.value = value;}
        }
        public Node Next
        {
            get {return next;}
            set {next = value;}
        }

        public Node(T value)
        {
            this.value = value;
        }
    }
}
