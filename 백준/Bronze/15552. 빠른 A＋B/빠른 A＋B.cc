#include <iostream>
using namespace std;

int main(){
    cin.tie(NULL);
    ios_base::sync_with_stdio(false);
    int T; cin>>T;
    for (int i=0; i<T; i++){
        int a, b;
        cin>>a>>b;
        cout<<a+b<<"\n";
    }
    return 0;
}