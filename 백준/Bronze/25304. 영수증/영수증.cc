#include <iostream>
using namespace std;

int main(){
	int total, N;
    int sum=0;
	cin>>total>>N;
	for(int i=0;i<N;i++){
		int p, num;
		cin>>p>>num;
		sum+=p*num;
	}
	if(sum==total) cout<<"Yes";
	else cout<<"No";
	return 0;
}