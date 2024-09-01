#include <iostream>
using namespace std;

int main()
{
    int N; cin>>N;
    
    int min_result = 1000000;
    int max_result = -1000000;
    
    for (int i=0; i<N; i++) {
        int new_num;
        cin>>new_num;
        
        if (min_result > new_num) {
            min_result = new_num;
        }
        if (max_result < new_num) {
            max_result = new_num;
        }
    }
    
    cout<<min_result<<" "<<max_result;
    
    return 0;
}