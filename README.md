# Draw

The Draw Package is designed to take inputs for a drawing and "render" them to the user

The package will be able to draw 5 shapes, which in turn can be manipulated with the following attributes.
- Rectangle – width and height
- Square – width
- Ellipse – horizontal and vertical diameter
- Circle – diameter
- Textbox – bounding rectangle (i.e., the rectangle which surrounds the textbox; the text will be
centred within this rectangle).

### Example Output:
```
----------------------------------------------------------------
Requested Drawing
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 Text="sample text"
----------------------------------------------------------------
```

## How to use
The Draw package contains a few different classes and functions to aid in the creation and displaying of various widgets.

### Canvas 
Base Functions:
* Add(widget) - function of canvas that takes a single widget and adds it to the canvas.
* Draw() - function of canvas that generates a string output of all the requested widgets.

The Canvas object is the base for a drawing, it has the ability to contain multiple widgets and render the output of those widgets. Widgets are currently stored in a list as there is no apparent need to worry about order or about further editing once the widgets are created and added.

### Widgets
Base Functions:
* Output() - output a string representation of the object
* SetLocation(x,y) - sets the location of the object in a 2d grid

To build a widget you must extend the abstract class of the same name and ensure you create an override of the output function.
This decision has been made to ensure the comminality amoung the widgets (currently the x/y Location and Widget name) is kept the same across all widgets, and by ensuring an Output function is created it allows the canvas object to only worry about the widgets and not dealing directly with each individual shape.

Each widget has further variables which control the various aspects. These are set at the time of object creation using the constructor. (There is currently no functionality to allow for changing of these variables after creation).

Available widgets and their inputs:
- Rectangle(int Width, int Height)
- Square(int Size)
- Ellipse(int diameterH, int diameterV)
- Circle(int size)
- Textbox(int width, int height, string text)

Variables which control the aspects of the different widgets have been made private where possible (being accessible through methods only) to limit extranious code from modifying data in an unexpected way.

# Extensions
Due to the project being short lived here are some possible paths to go do in order to improve the functionality and usability of the Draw package.
* Add the ability to render the widgets graphically using the drawing package built into c# (research into third party rendering, may be useful for quicker development)
* Create an interface to allow widgets to be added using commands entered into the command line interface
* Add the ability to modify widgets after they have been created.
* Add the ability to identify and modify (also remove) widgets which are already within the canvas. (Easiest route would be to pass pointers to the canvas then the widgets can be modified directly)
	- an addition to this if we allow for widgets to be added via commands then we could generate unique id's for widgets which will be output when generated thus allowing the user to refer to a shape if we added a modify command. (to aid this functionality store the canvas widgets in a map<id,widget> using the unique id's).
* Add the ability to save and load canvas'. Since security is not an apparant issue would be easiest to convert output into easy to read and store output such as Json or a CSV and simply store in a plain text file.
