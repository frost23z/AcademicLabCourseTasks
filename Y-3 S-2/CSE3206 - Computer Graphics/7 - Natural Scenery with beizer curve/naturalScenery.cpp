#include <graphics.h>
#include <math.h>
#include <iostream>
#include <vector>

using namespace std;

void drawAndFillBezierCurve(int controlPoints[4][2], int color) {
    const int STEPS = 1000; // Steps for smoothness
    vector<int> points;

    for (float t = 0; t <= 1; t += 1.0 / STEPS) {
        float x = 0, y = 0;

        x = pow(1 - t, 3) * controlPoints[0][0] +
            3 * pow(1 - t, 2) * t * controlPoints[1][0] +
            3 * (1 - t) * pow(t, 2) * controlPoints[2][0] +
            pow(t, 3) * controlPoints[3][0];

        y = pow(1 - t, 3) * controlPoints[0][1] +
            3 * pow(1 - t, 2) * t * controlPoints[1][1] +
            3 * (1 - t) * pow(t, 2) * controlPoints[2][1] +
            pow(t, 3) * controlPoints[3][1];

        points.push_back(round(x));
        points.push_back(round(y));
    }

    // Close the polygon by adding the start and end points
    points.push_back(controlPoints[3][0]);
    points.push_back(controlPoints[3][1]);
    points.push_back(controlPoints[0][0]);
    points.push_back(controlPoints[0][1]);

    setcolor(color);
    setfillstyle(SOLID_FILL, color);
    fillpoly(points.size() / 2, points.data());
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

void drawTree(int x, int y) {
    setcolor(BROWN);
    setfillstyle(SOLID_FILL, BROWN);
    rectangle(x - 10, y, x + 10, y + 60);
    floodfill(x, y + 30, BROWN);

    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    fillellipse(x, y, 30, 30);
    fillellipse(x - 20, y + 10, 20, 20);
    fillellipse(x + 20, y + 10, 20, 20);
}

void drawStaticScenery() {
    cleardevice();

    setcolor(LIGHTCYAN);
    setfillstyle(SOLID_FILL, LIGHTCYAN);
    rectangle(0, 0, 640, 480);
    floodfill(1, 1, LIGHTBLUE);

    setcolor(YELLOW);
    setfillstyle(SOLID_FILL, YELLOW);
    fillellipse(580, 80, 50, 50);

    setcolor(GREEN);
    setfillstyle(SOLID_FILL, GREEN);
    rectangle(0, 400, 640, 480);
    floodfill(10, 410, GREEN);

    // Draw and fill hills using Bezier curves
    int hill1[4][2] = {{50, 400}, {150, 300}, {250, 300}, {350, 400}};
    int hill2[4][2] = {{300, 400}, {400, 250}, {500, 250}, {600, 400}};
    int hill3[4][2] = {{100, 400}, {200, 350}, {300, 350}, {400, 400}};
    drawAndFillBezierCurve(hill1, LIGHTGRAY);
    drawAndFillBezierCurve(hill2, LIGHTGRAY);
    drawAndFillBezierCurve(hill3, LIGHTGRAY);

    drawTree(150, 350);
    drawTree(450, 350);

    drawCloud(100, 100);
    drawCloud(300, 150);
    drawCloud(500, 100);

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

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, nullptr);

    if (graphresult() != grOk) {
        cout << "Graphics initialization failed!" << endl;
        return 1;
    }

    drawStaticScenery();

    getch();
    closegraph();
    return 0;
}
