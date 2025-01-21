#include <graphics.h>
#include <iostream>
#include <cmath>
#define PI 3.14159265

using namespace std;

// Function to rotate a point around a center
void rotatePoint(int x, int y, int cx, int cy, double angle, int &newX, int &newY) {
    // Convert angle to radians
    double rad = angle * PI / 180.0;
    // Translate point to origin
    int dx = x - cx;
    int dy = y - cy;
    // Perform rotation
    newX = cx + (dx * cos(rad) - dy * sin(rad));
    newY = cy + (dx * sin(rad) + dy * cos(rad));
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");
    
    // Rectangle dimensions
    int left = 100, top = 100, right = 200, bottom = 200;
    
    // Calculate center point
    int centerX = (left + right) / 2;
    int centerY = (top + bottom) / 2;
    
    // Draw original rectangle in white
    setcolor(WHITE);
    rectangle(left, top, right, bottom);
    
    // Angle of rotation (45 degrees)
    double angle = 45.0;
    
    // Rotate each corner of the rectangle
    int x1, y1, x2, y2, x3, y3, x4, y4;
    
    rotatePoint(left, top, centerX, centerY, angle, x1, y1);
    rotatePoint(right, top, centerX, centerY, angle, x2, y2);
    rotatePoint(right, bottom, centerX, centerY, angle, x3, y3);
    rotatePoint(left, bottom, centerX, centerY, angle, x4, y4);
    
    // Draw rotated rectangle in red
    setcolor(RED);
    line(x1, y1, x2, y2);
    line(x2, y2, x3, y3);
    line(x3, y3, x4, y4);
    line(x4, y4, x1, y1);
    
    // Mark center point in yellow
    setcolor(YELLOW);
    circle(centerX, centerY, 3);
    
    getch();
    closegraph();
    return 0;
}
