#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> v;

int main(){
    ios_base::sync_with_stdio(0); cin.tie(0); cout.tie(0);
    
    int n; cin>>n;
    for (int i=0; i<n; i++){
        int x; cin>>x;
        v.push_back(x);
    }
    
    sort(v.begin(), v.end());
    
    for (auto &k :v) cout<< k <<'\n';
    
    return 0;
}