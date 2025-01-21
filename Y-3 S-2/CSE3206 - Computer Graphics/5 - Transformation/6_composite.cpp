#include <graphics.h>
#include <iostream>
#include <cmath>

using namespace std;

void transformPoint(int &x, int &y, int tx, int ty, float sx, float sy, float angle) {
    // Translation
    x += tx;
    y += ty;
    
    // Scaling
    x = round(x * sx);
    y = round(y * sy);
    
    // Rotation
    float rad = angle * M_PI / 180.0;
    int temp_x = x;
    x = round(x * cos(rad) - y * sin(rad));
    y = round(temp_x * sin(rad) + y * cos(rad));
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");
    
    // Original triangle coordinates
    int x[] = {100, 150, 50};
    int y[] = {100, 175, 175};
    
    // Draw original triangle in white
    setcolor(WHITE);
    for(int i = 0; i < 3; i++) {
        line(x[i], y[i], x[(i+1)%3], y[(i+1)%3]);
    }
    
    // Get transformation parameters
    int tx, ty;
    float sx, sy, angle;
    
    cout << "Enter translation (tx ty): ";
    cin >> tx >> ty;
    cout << "Enter scaling (sx sy): ";
    cin >> sx >> sy;
    cout << "Enter rotation angle: ";
    cin >> angle;
    
    // Create transformed triangle
    int new_x[3], new_y[3];
    for(int i = 0; i < 3; i++) {
        new_x[i] = x[i];
        new_y[i] = y[i];
        transformPoint(new_x[i], new_y[i], tx, ty, sx, sy, angle);
    }
    
    // Draw transformed triangle in green
    setcolor(GREEN);
    for(int i = 0; i < 3; i++) {
        line(new_x[i], new_y[i], new_x[(i+1)%3], new_y[(i+1)%3]);
    }
    
    // Draw connection lines between original and transformed shapes in blue
    setcolor(BLUE);
    for(int i = 0; i < 3; i++) {
        line(x[i], y[i], new_x[i], new_y[i]);
    }
    
    getch();
    closegraph();
    return 0;
}
