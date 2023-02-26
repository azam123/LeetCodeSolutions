//136. Single Number
 public int SingleNumber(int[] nums) {
        
        Dictionary<int,int> countDict = new Dictionary<int,int>();
        foreach(int num in nums){            
           if(!countDict.ContainsKey(num)){                        
                         countDict.Add(num,1);
                    }
                    else{
                        countDict.Remove(num);
                    }
                     
        }
        return countDict.Single(x=>x.Value==1).Key;
       
    }
