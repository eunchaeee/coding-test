#include <iostream>
#include <algorithm>
#include <string>
using namespace std;

struct member{
    int number, age;
    string name;
}members[100000];

bool compare(member& a, member& b){
    if(a.age != b.age){
        return a.age<b.age;
    }
    else{
        return a.number<b.number;
    }
}

int main()
{
    ios_base::sync_with_stdio(false); cin.tie(NULL); cout.tie(NULL);
    
    int n; cin >> n;
    
    for(int i=0; i<n; i++){
        cin >> members[i].age >> members[i].name;
        members[i].number = i;
    }
    
    sort(members, members+n, compare);
    
    for (int i=0; i<n; i++){
        cout << members[i].age << " " << members[i].name << '\n';
    }    
    return 0;
}