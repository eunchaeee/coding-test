#include <iostream>
using namespace std;

int main(){
    int N; cin>>N;
    for (int i=1; i<=N; i++){
        int a, b; cin>>a>>b;
        cout<<"Case #"<<i<<": "<<a<<" + "<<b<<" = "<<a+b<<"\n";
    }
    return 0;
}