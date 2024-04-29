# Draw

The Draw Package is designed to take inputs for a drawing and "render" them to the user

The package will be able to draw 5 shapes, which in turn can be manipulated with the following attributes.
- Rectangle – width and height
- Square – width
- Ellipse – horizontal and vertical diameter
- Circle – diameter
- Textbox – bounding rectangle (i.e., the rectangle which surrounds the textbox; the text will be
centred within this rectangle).

Example Output:
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