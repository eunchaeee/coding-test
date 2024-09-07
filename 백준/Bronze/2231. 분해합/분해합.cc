#include <iostream>
using namespace std;

int main()
{
    int N;
    cin>>N;
    
    int num = 1;
    while (true){
        int sum = num;
        int counter = num;
        while (true){
            sum += counter%10;
            counter/=10;
            if(counter==0) break;
        }
        if (sum == N) break;
        num++;
        if (num>=N){
            cout<<0;
            return 0;
        }
    }
    cout<<num;
    return 0;
}