#include <iostream>
using namespace std;

int main() {
    int arr[26] = {};
    string s;
    cin>>s;
    for (int i=0; i<s.length(); i++){
        arr[int(s[i])-97] += 1;
    }
    for (int i=0; i<sizeof(arr)/sizeof(int); i++) {
        cout<<arr[i]<<" ";
    }
    return 0;
}