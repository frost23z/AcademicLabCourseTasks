#include <graphics.h>
#include <math.h>
#include <iostream>

using namespace std;

// Function to calculate and draw a 4-point cubic Bezier curve
void drawCubicBezierCurve(int controlPoints[4][2]) {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "");

    const int STEPS = 1000; // Steps for smoothness

    for (float t = 0; t <= 1; t += 1.0 / STEPS) {
        float x = 0, y = 0;

        // Compute x and y coordinates using cubic Bezier formula
        x = pow(1 - t, 3) * controlPoints[0][0] +
            3 * pow(1 - t, 2) * t * controlPoints[1][0] +
            3 * (1 - t) * pow(t, 2) * controlPoints[2][0] +
            pow(t, 3) * controlPoints[3][0];

        y = pow(1 - t, 3) * controlPoints[0][1] +
            3 * pow(1 - t, 2) * t * controlPoints[1][1] +
            3 * (1 - t) * pow(t, 2) * controlPoints[2][1] +
            pow(t, 3) * controlPoints[3][1];

        putpixel(round(x), round(y), WHITE);
    }
}

int main() {
    // Define 4 control points for the cubic Bezier curve
    int controlPoints[4][2] = {
        {100, 300}, // P0: Start point
        {200, 100}, // P1: Control point 1
        {300, 400}, // P2: Control point 2
        {400, 200}  // P3: End point
    };

    // Draw the cubic Bezier curve
    drawCubicBezierCurve(controlPoints);
    getch();
    closegraph();

    return 0;
}
