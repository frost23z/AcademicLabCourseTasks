#include <graphics.h>
#include <conio.h>

const int SUN_RADIUS = 50;
const int CAR_WIDTH = 210;
const int CAR_HEIGHT = 60;  // Increased car height for better visual
const int STEP_SIZE = 10;
const int DELAY_TIME = 50;  // Reduced delay time for smoother animation
const int SUN_Y = 100;

void draw_sun(int sun_x, int sun_y);
void draw_car(int car_x, int car_y);
void draw_scene(void);
void draw_house(int x, int y);

int main() {
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)"" );

    int sun_x = 100;
    int car_x = 0;

    // Animate both sun and car simultaneously
    while (car_x <= getmaxx() - CAR_WIDTH) {
        // Clear and redraw everything
        cleardevice();
        draw_scene();
        
        // Draw sun at current position
        draw_sun(sun_x, SUN_Y);
        
        // Draw car at current position
        draw_car(car_x, getmaxy() - 150);
        
        // Update positions
        sun_x += STEP_SIZE;
        car_x += STEP_SIZE;
        
        delay(DELAY_TIME);
    }

    getch();
    closegraph();
    return 0;
}

void draw_scene() {
    // Sky - softer blue
    setfillstyle(SOLID_FILL, COLOR(135, 206, 235));
    bar(0, 0, getmaxx(), getmaxy() / 2);

    // Ground - natural green
    setfillstyle(SOLID_FILL, COLOR(34, 139, 34));
    bar(0, getmaxy() / 2, getmaxx(), getmaxy());

    // Road - asphalt gray
    setcolor(COLOR(64, 64, 64));
    setfillstyle(SOLID_FILL, COLOR(64, 64, 64));
    bar(0, getmaxy() - 100, getmaxx(), getmaxy() - 50);

    // Draw houses just above the road
    draw_house(50, getmaxy() - 250);
    draw_house(200, getmaxy() - 250);
    draw_house(400, getmaxy() - 250);
    draw_house(600, getmaxy() - 250);
}

// Draw the sun at the given coordinates
void draw_sun(int sun_x, int sun_y) {
    // Warmer yellow for sun
    setcolor(COLOR(255, 223, 0));
    setfillstyle(SOLID_FILL, COLOR(255, 223, 0));
    circle(sun_x, sun_y, SUN_RADIUS);
    floodfill(sun_x, sun_y, COLOR(255, 223, 0));
}

// Draw the car at the given position
void draw_car(int car_x, int car_y) {
    // Car body - deep red
    setcolor(COLOR(180, 0, 0));
    setfillstyle(SOLID_FILL, COLOR(180, 0, 0));
    rectangle(car_x, car_y, car_x + CAR_WIDTH, car_y + CAR_HEIGHT);
    floodfill(car_x + 1, car_y + 1, COLOR(180, 0, 0));

    // Car roof - metallic gray
    int roofPoints[] = {
        car_x + 50, car_y,
        car_x + 75, car_y - 30,
        car_x + 150, car_y - 30,
        car_x + 165, car_y,
        car_x + 50, car_y
    };
    setcolor(COLOR(128, 128, 128));
    setfillstyle(SOLID_FILL, COLOR(128, 128, 128));
    drawpoly(5, roofPoints);
    floodfill(car_x + 100, car_y - 15, COLOR(128, 128, 128));

    // Car windows - light blue tint
    setcolor(BLACK);
    setfillstyle(SOLID_FILL, COLOR(173, 216, 230));
    rectangle(car_x + 80, car_y + 10, car_x + 130, car_y + 40);
    floodfill(car_x + 81, car_y + 11, BLACK);

    // Wheels with chrome rims
    setcolor(COLOR(32, 32, 32));
    setfillstyle(SOLID_FILL, COLOR(32, 32, 32));
    circle(car_x + 65, car_y + CAR_HEIGHT, 15);
    floodfill(car_x + 65, car_y + CAR_HEIGHT, COLOR(32, 32, 32));
    
    circle(car_x + 145, car_y + CAR_HEIGHT, 15);
    floodfill(car_x + 145, car_y + CAR_HEIGHT, COLOR(32, 32, 32));

    // Wheel hubs - silver
    setcolor(COLOR(192, 192, 192));
    circle(car_x + 65, car_y + CAR_HEIGHT, 5);
    circle(car_x + 145, car_y + CAR_HEIGHT, 5);
}

void draw_house(int x, int y) {
    // Main house body - warm beige
    setcolor(COLOR(245, 222, 179));
    setfillstyle(SOLID_FILL, COLOR(245, 222, 179));
    rectangle(x, y, x + 100, y + 100);
    floodfill(x + 1, y + 1, COLOR(245, 222, 179));

    // Roof - terra cotta
    int roofPoints[] = {x, y, x + 50, y - 50, x + 100, y};
    setcolor(COLOR(204, 85, 0));
    setfillstyle(SOLID_FILL, COLOR(204, 85, 0));
    fillpoly(3, roofPoints);

    // Door - rich wood brown
    setcolor(COLOR(139, 69, 19));
    setfillstyle(SOLID_FILL, COLOR(139, 69, 19));
    rectangle(x + 40, y + 40, x + 60, y + 100);
    floodfill(x + 41, y + 41, COLOR(139, 69, 19));

    // Window - sky blue
    setcolor(COLOR(135, 206, 235));
    setfillstyle(SOLID_FILL, COLOR(135, 206, 235));
    rectangle(x + 70, y + 20, x + 90, y + 40);
    floodfill(x + 71, y + 21, COLOR(135, 206, 235));
}
