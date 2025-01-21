#include <graphics.h>
#include <iostream>
using namespace std;

void drawShape(int x1, int y1, int x2, int y2, int color) {
    setcolor(color);
    rectangle(x1, y1, x2, y2);
    // Add visual markers instead of text
    setfillstyle(SOLID_FILL, color);
    fillellipse(x1-5, y1-5, 5, 5);  // Mark starting point
    line(x1, y1, x2, y2);
    line(x2, y1, x1, y2);
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");
    
    if (graphresult() != grOk) {
        cout << "Graphics initialization failed!";
        return 1;
    }
    
    // Print information in console instead
    cout << "White shape: Original" << endl;
    cout << "Green shape: Translated" << endl;
    
    // Original coordinates
    int x1 = 100, y1 = 100;
    int x2 = 200, y2 = 200;
    
    // Draw original shape in white
    drawShape(x1, y1, x2, y2, WHITE);
    
    // Translation factors
    int tx = 150, ty = 100;
    
    // Draw translated shape in green
    drawShape(x1 + tx, y1 + ty, x2 + tx, y2 + ty, GREEN);
    
    cout << "Translation values: tx=" << tx << ", ty=" << ty << endl;
    
    getch();
    closegraph();
    return 0;
}
