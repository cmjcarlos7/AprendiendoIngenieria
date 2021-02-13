import random
import math

needle_number = int(input('How many needles do you want to throw?'))

radius_circumference = 1
needle_inside = 0

for needle in range(needle_number):
  # Generate a random coordinates.
  x = random.uniform(-1,1)
  y = random.uniform(-1,1)

  # Check if the needle fell in or out using the Pythagorean theorem.
  hypotenuse = math.sqrt(x**2 + y**2)
  # If hypotenuse < radius = needle inside circumference.
  if(hypotenuse < radius_circumference):
    needle_inside +=1


# Check PI number
print('There are {} needles inside'.format(needle_inside))

probability_inside = needle_inside / needle_number
PI = probability_inside * 4

print('The stimate PI number is {}'.format(PI))
