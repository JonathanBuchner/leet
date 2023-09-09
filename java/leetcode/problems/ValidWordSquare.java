// In progress
class Solution {
    public boolean validWordSquare(List<String> words) {
        var r = 0;
        var c = 1;

        while (r < words.size())
        {
            var rowlength = words.get(r).length();
            
            if (rowlength > words.size() && r < words.get(rowlength).length())
            {

            }

            while ( c < rowlength)
            {
                if (words.get(r).charAt(c) != words.get(c).charAt(r))
                {
                    return false;
                }
                
                c++;
            }

            r++;
        }

        return true;
    }
}