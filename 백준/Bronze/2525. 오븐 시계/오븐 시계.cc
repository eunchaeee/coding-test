#include <iostream>
using namespace std;

int main(){
    int h, m, x;
    cin>>h>>m>>x;
    int total=h*60+m+x;
    if(total/60 >=24){
        cout<<total/60-24;
    }
    else{
        cout<<total/60;
    }
    cout<<" "<<total%60;
    return 0;
}