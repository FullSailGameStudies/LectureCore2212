// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

enum Superpower
{
    Money, Speed, Sleep, Teleport, ShapeShift, MindControl
};
int main()
{
    //std -- standard namespace
    //:: -- scope resolution operator
    //cout -- console output stream
    //<< -- insertion operator
    std::cout << "Hello World!\n" << 5 << "\n";

    //<type> <name>
    int num = 5;
    cout << sizeof(char) << "(bytes)\n";

    char best[] = "Batman";//adds a \0 (null terminator)
    char notBest[] = { 'A','q','u','a','m','a','n','\0'};
    cout << best << "\n" << notBest << "\n";

    for (int i = 0; i < 6; i++)
    {
        cout << best[i] << ".";
    }
    cout << "\n";

    //random numbers
    srand(time(NULL));
    int random = rand();//0-RAND_MAX (32767) max short value
    //0-100
    random = rand() % 101;//0-100

    Superpower mypower = Superpower::Speed;
    switch (mypower)
    {
    case Money:
        break;
    case Speed:
        break;
    case Sleep:
        break;
    case Teleport:
        break;
    case ShapeShift:
        break;
    case MindControl:
        break;
    default:
        break;
    }
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
