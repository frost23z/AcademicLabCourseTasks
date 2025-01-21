#include <graphics.h>
#include <cmath>
#include <thread>
#include <chrono>

void ddaLine(int x1, int y1, int x2, int y2, int color) {
    float dx = x2 - x1;
    float dy = y2 - y1;
    int steps = std::max(abs(static_cast<int>(dx)), abs(static_cast<int>(dy)));
    float xInc = dx / steps;
    float yInc = dy / steps;
    float x = x1;
    float y = y1;

    for (int i = 0; i <= steps; i++) {
        putpixel(round(x), round(y), color);
        x += xInc;
        y += yInc;
        std::this_thread::sleep_for(std::chrono::milliseconds(1));
    }
}

int main() {
    int gdriver = DETECT, gmode;
    initgraph(&gdriver, &gmode, "");

    int maxX = getmaxx();
    int maxY = getmaxy();

    ddaLine(0, 0, maxX, maxY, WHITE);

    getch();
    closegraph();

    return 0;
}
