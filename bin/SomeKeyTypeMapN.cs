//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SomeKeyTypeMapN : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<testlib.nested.SomeKeyTypeN, string>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SomeKeyTypeMapN(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SomeKeyTypeMapN obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SomeKeyTypeMapN() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          simplecsPINVOKE.delete_SomeKeyTypeMapN(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public string this[testlib.nested.SomeKeyTypeN key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(testlib.nested.SomeKeyTypeN key, out string value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(string);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

  public global::System.Collections.Generic.ICollection<testlib.nested.SomeKeyTypeN> Keys {
    get {
      global::System.Collections.Generic.ICollection<testlib.nested.SomeKeyTypeN> keys = new global::System.Collections.Generic.List<testlib.nested.SomeKeyTypeN>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<string> Values {
    get {
      global::System.Collections.Generic.ICollection<string> vals = new global::System.Collections.Generic.List<string>();
      foreach (global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<testlib.nested.SomeKeyTypeN> keyList = new global::System.Collections.Generic.List<testlib.nested.SomeKeyTypeN>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      testlib.nested.SomeKeyTypeN currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>>.GetEnumerator() {
    return new SomeKeyTypeMapNEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new SomeKeyTypeMapNEnumerator(this);
  }

  public SomeKeyTypeMapNEnumerator GetEnumerator() {
    return new SomeKeyTypeMapNEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class SomeKeyTypeMapNEnumerator : global::System.Collections.IEnumerator, 
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>>
  {
    private SomeKeyTypeMapN collectionRef;
    private global::System.Collections.Generic.IList<testlib.nested.SomeKeyTypeN> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public SomeKeyTypeMapNEnumerator(SomeKeyTypeMapN collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<testlib.nested.SomeKeyTypeN>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        testlib.nested.SomeKeyTypeN currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<testlib.nested.SomeKeyTypeN, string>(currentKey, collectionRef[currentKey]);
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }
  

  public SomeKeyTypeMapN() : this(simplecsPINVOKE.new_SomeKeyTypeMapN__SWIG_0(), true) {
  }

  public SomeKeyTypeMapN(SomeKeyTypeMapN other) : this(simplecsPINVOKE.new_SomeKeyTypeMapN__SWIG_1(SomeKeyTypeMapN.getCPtr(other)), true) {
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = simplecsPINVOKE.SomeKeyTypeMapN_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = simplecsPINVOKE.SomeKeyTypeMapN_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    simplecsPINVOKE.SomeKeyTypeMapN_Clear(swigCPtr);
  }

  private string getitem(testlib.nested.SomeKeyTypeN key) {
    string ret = simplecsPINVOKE.SomeKeyTypeMapN_getitem(swigCPtr, testlib.nested.SomeKeyTypeN.getCPtr(key));
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(testlib.nested.SomeKeyTypeN key, string x) {
    simplecsPINVOKE.SomeKeyTypeMapN_setitem(swigCPtr, testlib.nested.SomeKeyTypeN.getCPtr(key), x);
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(testlib.nested.SomeKeyTypeN key) {
    bool ret = simplecsPINVOKE.SomeKeyTypeMapN_ContainsKey(swigCPtr, testlib.nested.SomeKeyTypeN.getCPtr(key));
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(testlib.nested.SomeKeyTypeN key, string val) {
    simplecsPINVOKE.SomeKeyTypeMapN_Add(swigCPtr, testlib.nested.SomeKeyTypeN.getCPtr(key), val);
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(testlib.nested.SomeKeyTypeN key) {
    bool ret = simplecsPINVOKE.SomeKeyTypeMapN_Remove(swigCPtr, testlib.nested.SomeKeyTypeN.getCPtr(key));
    if (simplecsPINVOKE.SWIGPendingException.Pending) throw simplecsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = simplecsPINVOKE.SomeKeyTypeMapN_create_iterator_begin(swigCPtr);
    return ret;
  }

  private testlib.nested.SomeKeyTypeN get_next_key(global::System.IntPtr swigiterator) {
    testlib.nested.SomeKeyTypeN ret = new testlib.nested.SomeKeyTypeN(simplecsPINVOKE.SomeKeyTypeMapN_get_next_key(swigCPtr, swigiterator), false);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    simplecsPINVOKE.SomeKeyTypeMapN_destroy_iterator(swigCPtr, swigiterator);
  }

}