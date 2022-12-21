# Intersecting_points_4
Problem Statement:
Write a program to calculate intersection point between two lines.

Inputs:
• Start End ( s1 e1 ) points of first line.
• Start End ( s2 e2 ) points of second line.
Output:
• Check line are parallel or not ( true/false ).
• If not then display the intersect point (P).

Pseudo Code:

determinant = a1 b2 - a2 b1
if (determinant == 0)
{
// Lines are parallel
}
else
{
x = (c1b2 - c2b1)/determinant
y = (a1c2 - a2c1)/determinant
}
