using System;

///<summary>A Generic queue.</summary>
class Queue<T>
{
    //The first element of the queue.
    private Node head;
    //The last element of the queue.
    private Node tail;
    //Amount of nodes in the queue.
    private int count;

    ///<summary>The first element of the queue.</summary>
    public Node Head
    {
        get {return head;}
        set {head = value;}
    }

    ///<summary>The last element of the queue.</summary>
    public Node Tail
    {
        get {return tail;}
        set {tail = value;}
    }

    ///<summary>Returns the type of the queue.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summar>Adds a new node to the queue.</summary>
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

    ///<summary>Return the amount of nodes in the queue.</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>Nodes of the queue.</summary>
    public class Node
    {
        //Content of the node.
        private T value = default(T);

        //Link to the next node.
        private Node next = null;

        ///<summary>Content of the node.</summary>
        public T Value
        {
            get {return this.value;}
            set {this.value = value;}
        }

        ///<summary>Link to the next node.</summary>
        public Node Next
        {
            get {return next;}
            set {next = value;}
        }

        ///<summary>Create a new node with a value.</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }
}
