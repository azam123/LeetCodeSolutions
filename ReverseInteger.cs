//Reverse Integer 
public class Solution {
    public int Reverse(int x) {
        try{
            bool negative=false;
        char[] intStr = x.ToString().ToCharArray();
            string sNum = "";
        for(int i=intStr.Length-1;i>=0;i--){
            
           // Console.Write(intStr[i]);
            if(intStr[i]=='-'){
                negative=true;
            }else{
                sNum+=intStr[i];
            }
        }
            if(negative)
                sNum="-"+sNum;
          int num = Convert.ToInt32(sNum);  
        return num;
        }
        catch{
            return 0;
        }
        
    }
}
