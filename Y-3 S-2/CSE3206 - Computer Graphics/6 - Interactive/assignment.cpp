#include <graphics.h>
#include <conio.h>
#include <iostream>
#include <stdlib.h>

using namespace std;

void drawStaticScenery()
{
    cleardevice();

    setcolor(LIGHTCYAN);
    setfillstyle(SOLID_FILL, LIGHTCYAN);
    rectangle(0, 0, 640, 480);
    floodfill(1, 1, LIGHTBLUE);

    setcolor(YELLOW);
    setfillstyle(SOLID_FILL, YELLOW);
    fillellipse(580, 80, 50, 50);

    setcolor(BROWN);
    setfillstyle(SOLID_FILL, LIGHTGRAY);

    int leftMountain[] = {0, 400, 250, 150, 470, 400};
    fillpoly(3, leftMountain);

    int rightMountain[] = {200, 400, 450, 120, 700, 400};
    fillpoly(3, rightMountain);

    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    rectangle(0, 400, 640, 480);
    floodfill(10, 410, GREEN);

    setcolor(BROWN);
    setfillstyle(SOLID_FILL, BROWN);
    rectangle(100, 350, 130, 450);
    floodfill(110, 360, BROWN);

    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    fillellipse(115, 320, 50, 50);

    setcolor(RED);
    setfillstyle(SOLID_FILL, RED);
    rectangle(400, 350, 500, 450);
    floodfill(410, 360, RED);

    setcolor(BLUE);
    setfillstyle(SOLID_FILL, BLUE);
    line(400, 350, 450, 300);
    line(450, 300, 500, 350);
    line(400, 350, 500, 350);
    floodfill(450, 320, BLUE);

    setcolor(WHITE);
    setfillstyle(SOLID_FILL, WHITE);
    rectangle(420, 390, 450, 430);
    floodfill(425, 395, WHITE);

    rectangle(470, 390, 490, 450);
    floodfill(475, 395, WHITE);
}



void drawCloud(int x, int y) {
    setcolor(WHITE);
    setfillstyle(SOLID_FILL, WHITE);

    fillellipse(x, y, 20, 20);
    fillellipse(x + 20, y - 10, 30, 30);
    fillellipse(x + 40, y + 5, 25, 25);
    fillellipse(x - 15, y + 10, 15, 15);
    fillellipse(x + 15, y + 20, 25, 25);
    fillellipse(x + 35, y - 15, 20, 20);
}

void drawBird(int x, int y)
{
    setcolor(BLACK);
    arc(x, y, 30, 150, 20);
    arc(x + 40, y, 30, 150, 20);
}

int main()
{
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)"");

    drawStaticScenery();
    cout << "Instructions:\n";
    cout << "1. Left-click to draw a cloud.\n";
    cout << "2. Right-click to draw a bird.\n";
    cout << "3. Press 'C' to clear and redraw scenery.\n";
    cout << "4. Press 'Q' to quit.\n";

    int x, y;
    char key;

    while (true)
    {
        if (ismouseclick(WM_LBUTTONDOWN))
        {
            getmouseclick(WM_LBUTTONDOWN, x, y);
            drawCloud(x, y);
        }
        if (ismouseclick(WM_RBUTTONDOWN))
        {
            getmouseclick(WM_RBUTTONDOWN, x, y);
            drawBird(x, y);
        }

        if (kbhit())
        {
            key = getch();
            if (key == 'c' || key == 'C')
            {
                drawStaticScenery();
            }
            else if (key == 'q' || key == 'Q')
            {
                closegraph();
                exit(0);
            }
        }
    }

    closegraph();
    return 0;
}
