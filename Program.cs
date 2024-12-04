//*****************************************************************************
//** 2825. Make String a Subsequence Using Cyclic Increments    leetcode     **
//*****************************************************************************

bool canMakeSubsequence(char* str1, char* str2)
{
    int i = 0;
    int n = strlen(str2); 

    for (int j = 0; str1[j] != '\0'; ++j)
    {
        char c = str1[j];
        char d = (c == 'z') ? 'a' : c + 1;

        if (i < n && (str2[i] == c || str2[i] == d))
        {
            ++i;
        }
    }

    return i == n;
}