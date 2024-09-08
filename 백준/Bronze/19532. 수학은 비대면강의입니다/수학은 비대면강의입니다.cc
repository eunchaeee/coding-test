#include <iostream>
using namespace std;

int main()
{
    int a, b, c, d, e, f;
    cin>>a>>b>>c>>d>>e>>f;
    
    if (b==0) {
        int x=c/a;
        int y= (f-x*d)/e;
        cout<<x<<" "<<y;
        return 0;
    }
    
    for (int x=-999; x<=999; x++) {
        int y=(c-a*x)/b;
        if(d*x + e*y == f && (c-a*x)%b==0 && y>=-999 && y<=999) {
            cout<<x<<" "<<y;   
        }
    }    
    return 0;
}