#include <iostream>
#include <cmath>
#include <thread>
#include <chrono>
#include <graphics.h>
#include <conio.h>

using namespace std;

void ddaLine(int x1, int y1, int x2, int y2, int color) {
    float dx = x2 - x1;
    float dy = y2 - y1;
    int steps = max(abs(static_cast<int>(dx)), abs(static_cast<int>(dy)));
    float xInc = dx / steps;
    float yInc = dy / steps;
    float x = x1;
    float y = y1;

    for (int i = 0; i <= steps; i++) {
        putpixel(round(x), round(y), color);
        x += xInc;
        y += yInc;
        this_thread::sleep_for(chrono::milliseconds(1));
    }
}

void bresenhamLine(int x1, int y1, int x2, int y2, int color) {
    int dx = abs(x2 - x1);
    int dy = abs(y2 - y1);
    int x = x1, y = y1;
    int sx = (x1 < x2) ? 1 : -1;
    int sy = (y1 < y2) ? 1 : -1;
    int p = (dx > dy) ? (2 * dy - dx) : (2 * dx - dy);

    if (dx > dy) {
        while (x != x2) {
            putpixel(x, y, color);
            x += sx;
            if (p >= 0) {
                y += sy;
                p -= 2 * dx;
            }
            p += 2 * dy;
            this_thread::sleep_for(chrono::milliseconds(1));
        }
    } else {
        while (y != y2) {
            putpixel(x, y, color);
            y += sy;
            if (p >= 0) {
                x += sx;
                p -= 2 * dy;
            }
            p += 2 * dx;
            this_thread::sleep_for(chrono::milliseconds(1));
        }
    }
    putpixel(x2, y2, color);
}

void bresenhamCircle(int xc, int yc, int r, int color) {
    int x = 0;
    int y = r;
    int p = 3 - 2 * r;

    auto plotCirclePoints = [&](int x, int y) {
        putpixel(xc + x, yc + y, color);
        putpixel(xc - x, yc + y, color);
        putpixel(xc + x, yc - y, color);
        putpixel(xc - x, yc - y, color);
        putpixel(xc + y, yc + x, color);
        putpixel(xc - y, yc + x, color);
        putpixel(xc + y, yc - x, color);
        putpixel(xc - y, yc - x, color);
    };

    plotCirclePoints(x, y);

    while (y >= x) {
        this_thread::sleep_for(chrono::milliseconds(20));
        if (p < 0) {
            p += 4 * x + 6;
        } else {
            y--;
            p += 4 * (x - y) + 10;
        }
        x++;
        plotCirclePoints(x, y);
    }
}

int main() {
    int gdriver = DETECT, gmode;
    initgraph(&gdriver, &gmode, "");

    cleardevice();

    int maxX = getmaxx();
    int maxY = getmaxy();

    // ddaLine(0, 0, maxX, maxY, WHITE);

    //bresenhamLine(0, maxY, maxX, 0, WHITE);

    int centerX = maxX / 2;
    int centerY = maxY / 2;
    int radius = maxY / 3;
    bresenhamCircle(centerX, centerY, radius, WHITE);

    getch();
    closegraph();

    return 0;
}
