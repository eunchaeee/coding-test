#include <iostream>
using namespace std;

int main(){
    int N;
    cin>>N;
    
    int arr[N];
    for(int i=0; i<N; i++){
        cin>>arr[i];
    }
    
    int targetNum;
    cin>>targetNum;
    
    int count=0;
    for(int i=0; i<N; i++){
        if(arr[i]==targetNum) count++;
    }
    
    cout<<count;
    return 0;
}