#include <iostream>
using namespace std;

int main()
{
    int a,b,c;
    cin>>a>>b>>c;
    if(a==b&&b==c)
    {
        cout<<10000+a*1000;
    }
    else if(a!=b&&b!=c&&c!=a)
    {
        cout<<max(max(a,b),c)*100;
    }
    else
    {
        if(a==b)
        {
            cout<<1000+a*100;
        }
        else
        {
            cout<<1000+c*100;    
        }       
    }
    return 0;
}