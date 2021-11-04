public class Solution {
    public class Pair{
        public int count;
        public char first;
        public Pair(char f,int c){
            this.count=c;
            this.first=f;
        }
    }
    public string RemoveDuplicates(string s, int k) {
      
        Stack<Pair> dupStack = new Stack<Pair>();
        for(int i=0;i<s.Length;i++){
            if(dupStack.Count()==0 || dupStack.Peek().first!=s[i])
            {
                Pair p = new Pair(s[i],1);
                dupStack.Push(p);
               
            }
            else{
                // s[i]==top element    
                dupStack.Peek().count++;
                int counter = dupStack.Peek().count; 
                Console.WriteLine(counter);
                if(counter==k){
                    dupStack.Pop();                 
                }                
            }
        }
          string ans="";     
      
        Console.WriteLine(dupStack.Count());
        while(dupStack.Count()>0){
            int cc = dupStack.Peek().count;
            while(cc>0){
                ans= ans+dupStack.Peek().first;
                cc--;
            }
            dupStack.Pop();
        }
             char[] ansch = ans.ToCharArray();
             Array.Reverse(ansch);
            ans = new String(ansch);
            return ans;
        
    }
}
