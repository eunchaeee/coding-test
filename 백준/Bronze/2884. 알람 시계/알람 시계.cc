#include <iostream>
using namespace std;

int main()
{
    int h; int m;
    cin>>h>>m;
    
    if(m>=45){
        cout<<h<<" "<<m-45;
    }
    else{
        if (h==0){
            cout<<23<<" "<<m+60-45;
        }
        else{
            cout<<h-1<<" "<<m+60-45;
        }
    }
    return 0;
}