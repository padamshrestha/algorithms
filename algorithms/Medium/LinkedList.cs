using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class LinkListNode<T>
  {
    public LinkListNode(T value)
    {
      Value = value;
    }

    public T Value { get; set; }

    public LinkedListNode<T> Next { get; set; }
  }

  public class LinkedList<T> : ICollection<T>
  {

    public LinkedListNode<T> Head
    {
      get; private set;
    }

    public int Count => throw new System.NotImplementedException();

    public bool IsReadOnly => throw new System.NotImplementedException();

    public void Add(T item)
    {
      throw new System.NotImplementedException();
    }

    public void Clear()
    {
      throw new System.NotImplementedException();
    }

    public bool Contains(T item)
    {
      throw new System.NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
      LinkedListNode<T> current = Head;
      while (current != null)
      {
        yield return current.Value;
        current = current.Next;
      }

    }

    public bool Remove(T item)
    {
      throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return ((IEnumerable<T>)this).GetEnumerator();
    }
  }
}
