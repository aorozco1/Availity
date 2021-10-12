using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		string test = "(format t \"Hello, World!\")";
		Console.WriteLine(CheckParenValid(test));
	}
	
	public static Boolean CheckParenValid(string str) {
		Stack<char> s = new Stack<char>();
		 if (str == null || str.Length == 0) {
	            return true;
	        }
	        foreach (char c in str) {
	      
	            if (c == '(') {
	                s.Push(c);
	            } else if (c == ')') {
	                if (s.Count == 0)
	                    return false;
	                else
	                    s.Pop();
	            }
	        }
	
	       return s.Count == 0;
	
	}
}