class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        string ans="";
        if(strs.size()==0) return ans;
        string first= strs[0];        
        for(int i=0;i<first.size();i++){            
            for(int j=1;j<strs.size();j++){               
                if(i>=strs[j].size() || first[i]!=strs[j][i]){
                    return ans;   
                }
            }           
            ans.push_back(first[i]);
        }
        return ans;
    }
};
