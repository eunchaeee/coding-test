#include <iostream>
#include <algorithm>
#include <string>
using namespace std;

struct score {
    string name;
    int korean, english, math;
}arr[100000];

bool compare(score& a, score& b) {
    if (a.korean != b.korean) {
        return a.korean > b.korean;
    }
    else if (a.korean == b.korean && a.english != b.english) {
        return a.english < b.english;
    }
    else if (a.korean == b.korean && a.english == b.english 
            && a.math != b.math) {
        return a.math > b.math;
    }
    else {
        return a.name < b.name;
    }
}

int main() {
    int n; cin >> n;
    
    for (int i = 0; i < n; i++) {
        cin >> arr[i].name >> arr[i].korean >> arr[i].english >> arr[i].math;
    }
    
    sort(arr, arr + n, compare);
    
    for (int i = 0; i < n; i++) {
        cout << arr[i].name <<'\n';
    }
    return 0;
}