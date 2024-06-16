#include <iostream>
using namespace std;

int arr[1000000];
int main()
{
    int N; cin>>N;
    for(int i=0;i<N;i++) cin>>arr[i];
    
    int min_num = 1000000;
    int max_num = -1000000;
    
    for(int i=0;i<N;i++){
        if(arr[i]<min_num) min_num=arr[i];
        if(arr[i]>max_num) max_num=arr[i];
    }
    
    cout<<min_num<<" "<<max_num;
    return 0;
}