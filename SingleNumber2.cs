
//137. Single Number II Medium

public class Solution {
    public int SingleNumber(int[] nums) {
          Dictionary<int,int> countDict = new Dictionary<int,int>();
        foreach(int num in nums){            
           if(!countDict.ContainsKey(num)){                        
                         countDict.Add(num,1);
                    }
                    else if(countDict.ContainsKey(num) && countDict[num]==1){
                         countDict[num]+=1;
                    }
                    else{
                        countDict.Remove(num);
                    }
                     
        }
        return countDict.Single(x=>x.Value==1).Key;
    }
}
