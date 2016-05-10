/// <summary>
/// 题目描述
/*
    Given two strings s and t, determine if they are isomorphic.

    Two strings are isomorphic if the characters in s can be replaced to get t.

    All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

    For example,
    Given "egg", "add", return true.

    Given "foo", "bar", return false.

    Given "paper", "title", return true.

    Note:
    You may assume both s and t have the same length.
*/
/*
实现思想：
    由于ASCII码只有256个字符，所以我们可以用一个256大小的数组来代替哈希表，并初始化为0，我们遍历原字符串，分别从源字符串和目标字符串取出一个字符，
    然后分别在两个哈希表中查找其值，若都是为0，则分别把对方的值存入对应的哈希表，若不相等，则返回false,；若全部相等则返回true，
*/
/// </summary>同构字符串
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        char [] chars = new char[256];
        char [] chart = new char[256];
        char [] s1 = s.ToCharArray();
        char [] t1 = t.ToCharArray();
        int n = s.Length;
        if(s.Length != t.Length)
        {
            return false;
        }
        else
        {
            for(int i = 0; i < n; i++)
            {
                if (chars[s1[i]] == 0 && chart[t1[i]] == 0)
                {
                    chars[s1[i]] = t1[i];
                    chart[t1[i]] = s1[i];
                }
                else
                {
                    if(chars[s1[i]] != t1[i] || chart[t1[i]] != s1[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}