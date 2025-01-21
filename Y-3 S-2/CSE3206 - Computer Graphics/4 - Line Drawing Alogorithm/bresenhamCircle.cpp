#include <graphics.h>
#include <cmath>
#include <thread>
#include <chrono>

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
        std::this_thread::sleep_for(std::chrono::milliseconds(20));
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

    int maxX = getmaxx();
    int maxY = getmaxy();

    int centerX = maxX / 2;
    int centerY = maxY / 2;
    int radius = maxY / 3;
    bresenhamCircle(centerX, centerY, radius, WHITE);

    getch();
    closegraph();

    return 0;
}
