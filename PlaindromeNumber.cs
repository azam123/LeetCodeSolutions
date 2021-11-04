//Problem No.9
public class Solution {
    public bool IsPalindrome(int x) {
       // bool isPalindrom=false;
        string mainStr = x.ToString();        
        string revStr="";        
        for(int i=mainStr.Length-1;i>=0;i--){
            revStr+=mainStr[i];
            Console.Write(mainStr[i]);
        }
        if(mainStr==revStr)
            return true;
        else
            return false;        
    }
}
