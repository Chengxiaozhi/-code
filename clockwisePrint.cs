/// <summary>
/// 题目描述
/*
    对于一个矩阵，请设计一个算法从左上角(mat[0][0])开始，顺时针打印矩阵元素。
     给定int矩阵mat,以及它的维数nxm，请返回一个数组，数组中的元素为矩阵元素的顺时针输出。
     测试样例：
     [[1,2],[3,4]],2,2
     返回：[1,2,4,3]
*/
/// </summary>
class Printer
{
    public int[] clockwisePrint(int[][] mat, int n, int m)
    {
        // write code here
        //动态规划算法解决，四个方向上下左右，根据当前位置规划下一步怎么走
        int [] result = new int [n*m];
        int currentI = 0;
        int currentJ = 0;
        int maxI = n-1;
        int maxJ = m-1;
        int minI = 0;
        int minJ = 0;
        int q = 0;
        int direction = 0; //0,1,2,3分别表示下个要走的方向上下左右
        result[0] = mat[0][0];
        for(int i=0;i<n*m;i++)
        {
            switch (direction)
            {
                case 0://右走
                	result[q++] = mat[currentI][currentJ++];
                	
                	if (currentJ == maxJ)
                    {
                        minI++;                    
                		direction = 1;
                    }                		
                	break;
                case 1://下走
                	result[q++] = mat[currentI++][currentJ];
                	if (currentI == maxI)
                    {
                        maxJ--;
                		direction = 2;
                    }                		
                	break;
                case 2://左走
                	result[q++] = mat[currentI][currentJ--];
                	if(currentJ == minJ)
                    {
                        maxI--;
                        direction = 3;
                    }                        
                	break;
                case 3://上走
                	result[q++] = mat[currentI--][currentJ];
                	if(currentI == minI)
                    {
                        minJ++;
                        direction = 0;
                    }
                	break;
            }
                
            
        }
        return result;
        
        
    }
}