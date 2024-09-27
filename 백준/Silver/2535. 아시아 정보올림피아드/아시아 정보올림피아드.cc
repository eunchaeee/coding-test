#include <iostream>
#include <algorithm>
using namespace std;

struct participant {
    int nation;
    int student_num;
    int score;
}arr[100];

bool compare(participant& a, participant& b) {
    return a.score > b.score;
}

int main() {
    int n; cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> arr[i].nation >> arr[i].student_num >> arr[i].score;
    }
    
    sort(arr, arr+n, compare);
    
    int cnt = 0;
    
    for (int i = 0; i < n; i++) {
    	if (cnt == 3) break;
    	
        if (i >= 2 && arr[0].nation == arr[1].nation) {
            if (arr[i].nation == arr[0].nation) {
                continue;
            }
            else {
                cout << arr[i].nation << ' ' << arr[i].student_num << '\n';
                cnt++;
                break;
            }
        }
        cout << arr[i].nation << ' ' << arr[i].student_num << '\n';
        cnt++;
    }
    return 0;
}