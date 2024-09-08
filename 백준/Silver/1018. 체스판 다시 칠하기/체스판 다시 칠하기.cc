#include <iostream>
using namespace std;

int main()
{
    int N, M; cin>>N>>M;
    char arr[N][M];
    
    for (int i=0; i<N; i++){
        cin>>arr[i];
    }
    
    int result=64;
    
    for (int i=0; i<N-7; i++)
    {
        for (int j=0; j<M-7; j++)
        {
            char first = arr[i][j];
            int count_B = 0;
            int count_W = 0;
            for(int n=i; n<i+8; n++)
            {
                for(int m=j; m<j+8; m++)
                {
                    if((n+m)%2==0 && arr[n][m]!='W')
                    {
                        count_W++;
                    }
                    else if((n+m)%2!=0 && arr[n][m]=='W')
                    {
                        count_W++;
                    }
                    
                    if((n+m)%2==0 && arr[n][m]!='B')
                    {
                        count_B++;
                    }
                    else if((n+m)%2!=0 && arr[n][m]=='B')
                    {
                        count_B++;
                    }
                   
                }
            }
            result = min(result, min(count_B, count_W));
        }
    }
    cout<<result;
    return 0;
}