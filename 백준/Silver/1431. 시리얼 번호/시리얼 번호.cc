#include <iostream>
#include <algorithm>
#include <vector>
#include <string>
using namespace std;

bool compare(string a, string b) {
    if (a.length() != b.length()) {
        return a.length() < b.length();
    }
    else {
        int a_sum = 0;
        int b_sum = 0;
        for (int i = 0; i < a.length(); i++) {
            if ('0' <= a[i] && a[i] <= '9') a_sum+= a[i] - '0';
        }
        for (int i = 0; i < b.length(); i++) {
            if ('0' <= b[i] && b[i] <= '9') b_sum+= b[i] - '0';
        }
        
        if (a_sum != b_sum) {
            return a_sum < b_sum;
        }
        else {
            return a < b;
        }
    }
}

int main() {
    
    ios_base::sync_with_stdio(false);
    cin.tie(0); cout.tie(0);
    
    int n;
    cin >> n;
    vector<string> v;
    for (int i = 0; i < n; i++) {
        string s;
        cin >> s;
        v.push_back(s);
    }
    sort(v.begin(), v.end(), compare);
        
    for (int i = 0; i < n; i++) {
        cout << v[i] <<'\n';
    }    
    return 0;
}