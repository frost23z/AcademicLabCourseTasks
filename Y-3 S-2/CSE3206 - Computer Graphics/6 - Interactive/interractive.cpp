#include <bits/stdc++.h>
#include <graphics.h>
#include <conio.h>
using namespace std;

int x, y;
char key;

void instructions()
{
    cout << "****** Welcome to Interactive Graphics *******\n";
    cout << "Instructions:\n";
    cout << "1. Left Mouse Click   - Draw a Circle.\n";
    cout << "2. Right Mouse Click  - Draw a Rectangle.\n";
    cout << "3. Middle Mouse Click - Draw a Triangle.\n";
    cout << "4. Press 'C'          - Clear the Screen.\n";
    cout << "5. Press 'Q'          - Quit the Program.\n";
}

void interactivegraphics()
{
    while (true)
    {
        // Left mouse click: draw a circle
        if (ismouseclick(WM_LBUTTONDOWN))
        {
            getmouseclick(WM_LBUTTONDOWN, x, y);
            setcolor(RED);
            circle(x, y, 20); // Circle with radius 20
        }

        // Right mouse click: draw a rectangle
        if (ismouseclick(WM_RBUTTONDOWN))
        {
            getmouseclick(WM_RBUTTONDOWN, x, y);
            setcolor(GREEN);
            rectangle(x - 30, y - 20, x + 30, y + 20); // Rectangle centered at (x, y)
        }

        // Middle mouse click: draw a triangle
        if (ismouseclick(WM_MBUTTONDOWN))
        {
            getmouseclick(WM_MBUTTONDOWN, x, y);
            setcolor(BLUE);
            line(x, y - 30, x - 25, y + 20); // Left edge of the triangle
            line(x - 25, y + 20, x + 25, y + 20); // Bottom edge of the triangle
            line(x + 25, y + 20, x, y - 30); // Right edge of the triangle
        }

        // Keyboard interaction
        if (kbhit()) // Check if a key is pressed
        {
            key = getch(); // Read the pressed key

            if (key == 'c' || key == 'C') // Clear the screen
            {
                cleardevice(); // Clear the graphics screen
                instructions(); // Re-display instructions
            }
            else if (key == 'q' || key == 'Q') // Quit the program
            {
                closegraph(); // Close graphics window
                exit(0);      // Exit the program
            }
        }
    }
}

int main()
{
    int gd = DETECT, gm;
    initgraph(&gd, &gm, (char*)" ");

    instructions();        // Display instructions
    interactivegraphics(); // Start graphics interaction

    closegraph();
    return 0;
}
