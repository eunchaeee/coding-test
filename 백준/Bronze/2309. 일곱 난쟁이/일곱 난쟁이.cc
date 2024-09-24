#include <iostream>
#include <algorithm>
using namespace std;

int arr[9];

int main() {
    int sum = 0;
    for (int i=0; i<9; i++){
        cin >> arr[i];
        sum += arr[i];
    }
    
    sort(arr, arr+9);
        
    for (int i=0; i<9-1; i++){
        for (int j=1; j<9; j++){
            if (sum-arr[i]-arr[j] == 100){
                arr[i] = 0;
                arr[j] = 0;
                for (int i=0; i<9; i++){
                    if (arr[i] != 0){
                        cout << arr[i] << '\n';
                    }   
                }
                return 0;
            }
        }
    }
}