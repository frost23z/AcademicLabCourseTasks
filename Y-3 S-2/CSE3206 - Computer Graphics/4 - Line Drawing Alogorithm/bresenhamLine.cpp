#include <graphics.h>
#include <cmath>
#include <thread>
#include <chrono>

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
            std::this_thread::sleep_for(std::chrono::milliseconds(1));
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
            std::this_thread::sleep_for(std::chrono::milliseconds(1));
        }
    }
    putpixel(x2, y2, color);
}

int main() {
    int gdriver = DETECT, gmode;
    initgraph(&gdriver, &gmode, "");

    int maxX = getmaxx();
    int maxY = getmaxy();

    bresenhamLine(0, maxY, maxX, 0, WHITE);

    getch();
    closegraph();

    return 0;
}
