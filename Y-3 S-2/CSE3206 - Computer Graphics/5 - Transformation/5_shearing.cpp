#include <graphics.h>
#include <iostream>
#include <conio.h>

using namespace std;

void drawRect(int x1, int y1, int x2, int y2, int color) {
    setcolor(color);
    line(x1, y1, x2, y1);
    line(x2, y1, x2, y2);
    line(x2, y2, x1, y2);
    line(x1, y2, x1, y1);
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");
    
    // Original rectangle coordinates
    int x1 = 100, y1 = 100;
    int x2 = 200, y2 = 200;
    
    // Draw original rectangle in white
    drawRect(x1, y1, x2, y2, WHITE);
    delay(1000);  // Pause to show original shape
    
    float shear_factor;
    cout << "Enter shear factor (recommended 0.5 to 2.0): ";
    cin >> shear_factor;
    
    cout << "1. X-direction shear\n2. Y-direction shear\nEnter choice: ";
    int choice;
    cin >> choice;
    
    // Store original points for reference
    int orig_x1 = x1, orig_y1 = y1;
    int orig_x2 = x2, orig_y2 = y2;
    
    if (choice == 1) {  // X-direction shear
        x1 = orig_x1 + (shear_factor * (orig_y1 - y1));
        x2 = orig_x2 + (shear_factor * (orig_y2 - y1));
    }
    else {  // Y-direction shear
        y1 = orig_y1 + (shear_factor * (orig_x1 - x1));
        y2 = orig_y2 + (shear_factor * (orig_x2 - x1));
    }
    
    // Draw sheared rectangle in green
    drawRect(x1, y1, x2, y2, GREEN);
    
    getch();
    closegraph();
    return 0;
}
