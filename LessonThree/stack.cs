using System;

class Stack
{
    private char[] st;
    private int arr_size;

    private int st_size=0;

    public Stack(int n)
    {
        arr_size = n;
        st = new char[n];

    } 

    public void st_push(char el)
    {
        st[st_size] = el;
        st_size++;
    }

    public void st_pop()
    {
        st_size--;
    }
    public bool st_isempty()
    {
        if (st_size >0) return true;
        else return false;
    }

    public int st_total_size()
    {
        return st.Length;
    }

    public int st_real_size()
    {
        return st_size;
    }

}


/* class MyClass
{
    static void Main()
    {
        Stack mystack = new Stack(100);
        Console.WriteLine(mystack.st_isempty());
        mystack.st_push('a');
        Console.WriteLine(mystack.st_isempty()); 
    }
} */



