#include <graphics.h>
#include <iostream>
using namespace std;

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");

    // Original rectangle coordinates
    int x1 = 100, y1 = 100;    // top-left corner
    int x2 = 200, y2 = 200;    // bottom-right corner

    // Draw original rectangle in white
    setcolor(WHITE);
    rectangle(x1, y1, x2, y2);

    // Input scaling factors
    float sx, sy;
    cout << "Enter scaling factor for X: ";
    cin >> sx;
    cout << "Enter scaling factor for Y: ";
    cin >> sy;

    // Calculate scaled coordinates
    int new_x1 = x1 * sx;
    int new_y1 = y1 * sy;
    int new_x2 = x2 * sx;
    int new_y2 = y2 * sy;

    // Draw scaled rectangle in green
    setcolor(GREEN);
    rectangle(new_x1, new_y1, new_x2, new_y2);

    // Display information in console
    cout << "\nOriginal Rectangle: White";
    cout << "\nScaled Rectangle: Green";
    cout << "\nPress any key to exit...";

    getch();
    closegraph();
    return 0;
}
