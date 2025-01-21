#include <graphics.h>
#include <iostream>
#include <cmath>
using namespace std;

void drawPolygon(int x[], int y[], int n, int color) {
    setcolor(color);
    for(int i = 0; i < n; i++) {
        line(x[i], y[i], x[(i+1)%n], y[(i+1)%n]);
    }
}

void transform(int x[], int y[], int n, float matrix[3][3]) {
    for(int i = 0; i < n; i++) {
        int temp_x = x[i];
        int temp_y = y[i];
        x[i] = matrix[0][0] * temp_x + matrix[0][1] * temp_y + matrix[0][2];
        y[i] = matrix[1][0] * temp_x + matrix[1][1] * temp_y + matrix[1][2];
    }
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");

    // Define pentagon vertices
    int n = 5;
    int x[] = {100, 200, 250, 200, 100};
    int y[] = {100, 100, 200, 300, 200};

    // Draw original pentagon in white
    drawPolygon(x, y, n, WHITE);

    // Translation matrix
    float trans[3][3] = {
        {1, 0, 50},  // Move 50 pixels right
        {0, 1, 50},  // Move 50 pixels down
        {0, 0, 1}
    };
    transform(x, y, n, trans);
    drawPolygon(x, y, n, RED);

    // Scaling matrix
    float scale[3][3] = {
        {1.5, 0, 0},  // Scale x by 1.5
        {0, 1.5, 0},  // Scale y by 1.5
        {0, 0, 1}
    };
    transform(x, y, n, scale);
    drawPolygon(x, y, n, GREEN);

    // Rotation matrix (45 degrees)
    float angle = 45 * M_PI / 180;
    float rot[3][3] = {
        {cos(angle), -sin(angle), 0},
        {sin(angle), cos(angle), 0},
        {0, 0, 1}
    };
    transform(x, y, n, rot);
    drawPolygon(x, y, n, BLUE);

    getch();
    closegraph();
    return 0;
}
