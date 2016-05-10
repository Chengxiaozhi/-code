class Solution(object):
    def isIsomorphic(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: bool
        """
        s1 = []
        t1 = []
        if len(s) != len(t):
            return False
        else:
            for n in range(len(s)):
                s1.append(s.index(s[n]))
                t1.append(t.index(t[n]))
                
        if s1 == t1:
            return True
        else:
            return False
                
                    