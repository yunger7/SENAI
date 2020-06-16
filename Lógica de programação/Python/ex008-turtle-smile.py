import turtle

# turtle.resetscreen() limpa a tela

tart = turtle.Turtle()
tart.pensize(5)

tart.circle(150)

tart.penup()
tart.forward(75)
tart.left(90)
tart.forward(200)
tart.pendown()

tart.begin_fill()
tart.circle(25)
tart.end_fill()

tart.penup()
tart.left(90)
tart.forward(100)
tart.right(90)
tart.pendown()

tart.begin_fill()
tart.circle(25)
tart.end_fill()

tart.penup()
tart.left(90)
tart.forward(50)
tart.left(90)
tart.forward(75)
tart.pendown()

tart.circle(75, 175)

turtle.Screen().exitonclick()