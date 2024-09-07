#include <iostream>
using namespace std;

int main(){
    int N; cin>>N;
    char arr[N];
    fill(arr, arr+N-1, ' ');
    for (int i=N-1; i>=0; i--){
        arr[i]='*';
        for (int j=0; j<sizeof(arr)/sizeof(char); j++){
            cout<<arr[j];
        }
        cout<<'\n';
    }
    return 0;
}