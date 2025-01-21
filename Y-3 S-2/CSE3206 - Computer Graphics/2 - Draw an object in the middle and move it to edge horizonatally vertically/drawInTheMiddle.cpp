#include <graphics.h>
#include <iostream>
#include <cmath>

using namespace std;

const int DELAY = 30;
const int RECT_COLOR = LIGHTBLUE;
const int BALL_COLOR = RED;

void drawRectangle(int x, int y, int rectWidth, int rectHeight, int color) {
    setcolor(color);
    rectangle(x - rectWidth / 2, y - rectHeight / 2, x + rectWidth / 2, y + rectHeight / 2);
}

void drawAndFillCircle(int x, int y, int radius, int color) {
    setcolor(color);
    circle(x, y, radius);
    floodfill(x, y, color);
}

void animateBall(int x, int y, int rectWidth, int rectHeight, int radius, int step) {
    int movements[][2] = {{1, 0}, {0, -1}, {-1, 0}, {0, 1}};

    for (auto &movement : movements) {
        int dx = movement[0], dy = movement[1];
        int distance = (dx != 0) ? rectWidth / 2 - radius : rectHeight / 2 - radius;

        for (int i = 0; i <= distance; i += step) {
            cleardevice();
            drawRectangle(x, y, rectWidth, rectHeight, RECT_COLOR);
            drawAndFillCircle(x + i * dx, y + i * dy, radius, BALL_COLOR);
            delay(DELAY);
        }

        for (int i = distance; i >= 0; i -= step) {
            cleardevice();
            drawRectangle(x, y, rectWidth, rectHeight, RECT_COLOR);
            drawAndFillCircle(x + i * dx, y + i * dy, radius, BALL_COLOR);
            delay(DELAY);
        }
    }
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, nullptr);

    if (graphresult() != grOk) {
        cout << "Graphics initialization failed!" << endl;
        return 1;
    }

    int left = 100, top = 100, right = getmaxx() - 100, bottom = getmaxy() - 100;
    int centerX = (left + right) / 2;
    int centerY = (top + bottom) / 2;
    int rectWidth = right - left;
    int rectHeight = bottom - top;
    int radius = 10;
    int step = 5;

    animateBall(centerX, centerY, rectWidth, rectHeight, radius, step);

    getch();
    closegraph();
    return 0;
}
