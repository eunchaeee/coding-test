#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        int arr[5];
        for (int j = 0; j < 5; j++) {
            cin >> arr[j];
        }
        
        sort(arr, arr+5);
        if (arr[3]-arr[1] >= 4) {
            cout << "KIN" << '\n';
        }
        else {
            cout << arr[1] + arr[2] + arr[3] << '\n';
        }
    }
    return 0;
}