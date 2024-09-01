#include <iostream>
using namespace std;

int main()
{
    int N;
    cin>>N;
    string result="";
    for (int i=0; i<N; i++) {
        result+="*";
        cout<<result<<endl;
    }
    return 0;
}