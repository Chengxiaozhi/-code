﻿/// <summary>
/// 题目描述
/*
 	对于一个字符串，和字符串中的某一位置，请设计一个算法，将包括i位置在内的左侧部分移动到右边，将右侧部分移动到左边。
	给定字符串A和它的长度n以及特定位置p，请返回旋转后的结果。
	测试样例：
	"ABCDEFGH",8,4
	返回："FGHABCDE"
*/
/// </summary>
class StringRotation
{
    public string rotateString(string A, int n, int p)
    {
        // write code here
        string left = A.Substring(0,p+1);
        string right = A.Substring(p+1,n-p-1);
        string B = "";
        B = right + left;
        return B;
    }

     public string rotateString1(string A, int n, int p)
    {
        // write code here
        string C = A + A;
        string B = C.Substring(p+1,n);
        return B;
    }
}

