#include <iostream>
using namespace std;

void foo(char* text) 
{
    text = new char[] {"Elvin"};
}

struct A {
    char a;
    int c; 
    double b;
};

int add(int a) {
    return a;
}

int main() {

    int n = 3;
    int res = add(n);

// int arr[2][2] = {{1, 2, 3}, {4, 5}};

    int* arr = new int[5]{1, 2, 3, 4, 5};

    cout << arr[3];

    cout << arr << endl; 

    cout << *arr  << endl;

    FILE* a;

    fopen_s(&a, "data.txt", "w");

    int num = 5;
    int* a = &num;

    int arr2[3]{1, 2, 3};

    cout << arr2;

{
    int a = 1;
    {
        int b = 2;
        {
            int c = 3;
        }
    }
}
return 0;
}


