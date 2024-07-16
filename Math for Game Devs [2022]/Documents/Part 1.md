### Number line, Vector, fundamental

	Magnitude(a) = Abs(a) = |a| >= 0
	
	Distance(a, b) = Abs(b - a) = |b - a| >= 0
	
	Sign(a) = a / |a| = 1 (a > 0) or -1 (a < 0) or 0 (a = 0)
	
	Signed(a, b) = +1 (b > a) or -1 (b < a) or 0 (a = b)

### 2D Vectors

- x-axis y-axis
- A(x, y) 
- Represent: Position, Direction, Velocity, Offset
- vector a (3, 2) + vector b (-4, 1) = vector c (-1, 3)
- a - b = d; b - a = -d (all vector)
- Vector don't have origin, just has the end point

### Vector length (magnitude)


$$
Length (\overrightarrow{a})  = Magnitude(\overrightarrow{a})= \sqrt{(x^2 + y^2)} \quad \overrightarrow{a}(x,y)
$$

$$
Distance(\overrightarrow{a}, \overrightarrow{b}) = ||a, b||= |b-a|=  \sqrt{(b.x - a.x)^2 + (b.y - a.y)^2}
$$

### Vector Normalization

- Circle Ox (-1, 1), Oy (-1, 1)
- Normalize Vector = Unit Vector
- Represent direction
 
$$

Direction(\overrightarrow{a}) = Normalize(\overrightarrow{a}) = \overrightarrow{a}  \; / \; Magnitude(\overrightarrow{a})

$$

$$

Length (Normalize(\overrightarrow{a})) =1

$$
### Vector Multiplication

$$

\overrightarrow{a} * s = \overrightarrow{b}(a.x * s, a.y * s)

$$

$$

\overrightarrow{a} \; \textbullet \; \overrightarrow{b} = ???

$$

- Few different ways of multiply vector: __Cross Product__ , __Dot Product__

### Dot product

- Use in many different cases
- Depending on what kind of vectors use with => difference information about those vectors
- Also known as __Scalar Product__, __Symmetric Product__, __Interior Product__
- Result is a number

$$

\overrightarrow{a} \; \textbullet \; \overrightarrow{b}  = a.x \;* \;b.x \;+ \; a.y \;* \;b.y

$$
#### 1. Scalar Projection

$$

\overrightarrow{a} \; \textbullet \; \overrightarrow{b}     \quad \textrm{a is normalized vector}

$$
 - One of 2 vector is normalized
 - Return single number
 - Representing: How far along a is b
 - Project b on infinity line of direction a, return signed distance of b along a
 - The relationship between 2 vector
 - Object is how far _in front of_ or how far _behind_ other object and 
 ![[Scalar Projection.png]]Scalar Projection
- If both vector is normalized => Dot Product represents how similar these 2 vectors are. Can Get Angle between two vector

$$

acos(\overrightarrow{a} \; \textbullet \; \overrightarrow{b}) = angle

$$

	- Same direction value = 1
	- Opposite direction value = -1
![[Scalar Projection With 2 normalized vector.png]]

#### 2. Vector Projection

$$

\overrightarrow{a} \; (\overrightarrow{a} \; \textbullet \; \overrightarrow{b})     \quad \textrm{a is normalized vector}

$$
- Result is a vector
- The point that b project on a

![[Vector Projection.png]]

- Use case: flat something on a line

### Exercise

![[Exc 1.png]]
![[Exc 2.png]]
![[Exc 3.png]]