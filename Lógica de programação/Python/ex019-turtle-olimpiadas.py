import turtle

t = turtle.Turtle()
t.pensize(2.5)

# Primeiro Circulo
t.circle(50)

# Segundo Circulo
t.penup()
t.forward(115)
t.pendown()
t.circle(50)

# Terceiro Circulo
t.penup()
t.forward(110)
t.left(90)
t.forward(100)
t.pendown()
t.circle(50)

# Quarto Circulo
t.penup()
t.left(90)
t.forward(115)
t.right(90)
t.pendown()
t.circle(50)

# Quinto Circulo
t.penup()
t.left(90)
t.forward(115)
t.right(90)
t.pendown()
t.circle(50)

turtle.Screen().exitonclick()