#include <iostream>
using namespace std;

int main()
{
    int N; cin>>N;
    int count = 5000;
    for (int i=0; i<=N/5; i++){
        if((N-i*5)%3==0){
          count = min(count, i+(N-i*5)/3);
        }
    }
    
    if(count == 5000) {
      cout<<-1;
    }
    else{
      cout<<count;
    }
    
    return 0;
}