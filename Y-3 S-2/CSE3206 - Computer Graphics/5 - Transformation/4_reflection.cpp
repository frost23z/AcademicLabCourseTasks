#include <graphics.h>
#include <iostream>
#include <cmath>
using namespace std;

void reflectPoint(int x, int y, char axis, int &x_new, int &y_new) {
    switch(axis) {
        case 'x': // Reflect about x-axis
            x_new = x;
            y_new = -y;
            break;
        case 'y': // Reflect about y-axis
            x_new = -x;
            y_new = y;
            break;
        case 'o': // Reflect about origin
            x_new = -x;
            y_new = -y;
            break;
    }
}

void drawShape(int x[], int y[], int color) {
    setcolor(color);
    for(int i = 0; i < 4; i++) {
        line(x[i] + getmaxx()/2, getmaxy()/2 - y[i], 
             x[(i+1)%4] + getmaxx()/2, getmaxy()/2 - y[(i+1)%4]);
    }
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");
    
    // Original rectangle coordinates
    int x[] = {50, 150, 150, 50};
    int y[] = {50, 50, 150, 150};
    
    // Draw coordinate axes
    setcolor(WHITE);
    line(0, getmaxy()/2, getmaxx(), getmaxy()/2);    // X-axis
    line(getmaxx()/2, 0, getmaxx()/2, getmaxy());    // Y-axis
    
    // Draw original shape
    drawShape(x, y, YELLOW);
    
    // Reflected coordinates
    int x_new[4], y_new[4];
    
    // Reflect about y-axis
    for(int i = 0; i < 4; i++) {
        reflectPoint(x[i], y[i], 'y', x_new[i], y_new[i]);
    }
    drawShape(x_new, y_new, GREEN);
    
    // Reflect about x-axis
    for(int i = 0; i < 4; i++) {
        reflectPoint(x[i], y[i], 'x', x_new[i], y_new[i]);
    }
    drawShape(x_new, y_new, RED);
    
    // Reflect about origin
    for(int i = 0; i < 4; i++) {
        reflectPoint(x[i], y[i], 'o', x_new[i], y_new[i]);
    }
    drawShape(x_new, y_new, BLUE);
    
    getch();
    closegraph();
    return 0;
}
