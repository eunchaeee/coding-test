#include <iostream>
using namespace std;

int main()
{
    int N; cin>>N;
    int num = 666;
    int count = 0;
    while(true){
        string s = to_string(num);
        for (int i=0; i<sizeof(s)/sizeof(char)-2; i++) {
            if (s[i]=='6' && s[i+1]=='6' && s[i+2]=='6'){
                count++;
                if(count==N){
                    cout<<num;
                    return 0;
                }
                break;
            }
        }
        num++;
    }
    return 0;
}