#include <graphics.h>
#include <conio.h>
#include <dos.h>

void drawScenery(int sunX) {
    // Draw sky
    setcolor(LIGHTBLUE);
    setfillstyle(SOLID_FILL, LIGHTBLUE);
    rectangle(0, 0, getmaxx(), getmaxy() / 2);
    floodfill(1, 1, LIGHTBLUE);

    // Draw ground
    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    rectangle(0, getmaxy() / 2, getmaxx(), getmaxy());
    floodfill(1, getmaxy() / 2 + 1, GREEN);

    // Draw sun
    setcolor(YELLOW);
    setfillstyle(SOLID_FILL, YELLOW);
    circle(sunX, 80, 40);
    floodfill(sunX, 80, YELLOW);

    // Draw tree trunk
    setcolor(BROWN);
    setfillstyle(SOLID_FILL, BROWN);
    rectangle(getmaxx() / 2 - 20, getmaxy() / 2 - 120, getmaxx() / 2 + 20, getmaxy() / 2);
    floodfill(getmaxx() / 2 - 19, getmaxy() / 2 - 119, BROWN);

    // Draw tree leaves
    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    circle(getmaxx() / 2, getmaxy() / 2 - 150, 40);
    floodfill(getmaxx() / 2, getmaxy() / 2 - 150, GREEN);
    circle(getmaxx() / 2 - 30, getmaxy() / 2 - 210, 40);
    floodfill(getmaxx() / 2 - 30, getmaxy() / 2 - 210, GREEN);
    circle(getmaxx() / 2 + 30, getmaxy() / 2 - 210, 40);
    floodfill(getmaxx() / 2 + 30, getmaxy() / 2 - 210, GREEN);
}

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, "C:\\Turboc3\\BGI");

    int sunX = 0;

    while (!kbhit()) {
        cleardevice();
        drawScenery(sunX);
        delay(100);

        sunX += 5;
        if (sunX > getmaxx()) {
            sunX = 0;
        }
    }

    getch();
    closegraph();
    return 0;
}
