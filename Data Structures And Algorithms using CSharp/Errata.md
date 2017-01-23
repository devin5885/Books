This file contains the Errata I have found in the book Data Structures & Algorithms using C# by Michael McMillian.

##Chapter 16 - Graphs and Graph Algorithms

---
Pg. 288 - Graph class:

The graph class allocates the array & matrix based on NUM_VERTICES, however the methods in the next section rely on there being NUM_VERTICES + 1 because they copy & rows columns from the next row down/column to the right. Therefore the ctor has been updated to allocate the array & matrix with NUM_VERTICES + 1 elements. The matrix initialization has also been updated appropropriately.

---
Pg. 288 - AddEdge Method:

Second parameter is `eend` should be `end`.

---
Pg. 288 - AddEdge Method:

The update for the second matrix entry (i.e.) from -> to

`adjMatrix[end, start] = 1;`

is only appropriate in a non-directed graph however the first example starting on Pg. 289 is for a directed graph. This can be resolved by commenting out this line or adding another attribute to the class to indicate a directed or non-directed graph & execute this line only when appropriate (See additions).

---
Pg. 290 - NumSuccessors method:
Pg. 291 - DelVertex method:
Pg. 291 - TopSort method:

References to:
`numVertices`
should be:
`numVerts`

---
Pg. 291 - DelVertex method:

Lines:
```
if (vert != numVerts - 1)
{
```
don't make sense, this prevents the final column from being processed & causes TopSort to loop indefinately.

---
Pg. 291 - DelVertex method:

```
moveRow
moveColumn
```
should be
```
MoveRow
MoveColumn
```

---
Pg. 291 - DelVertex method:

```
moveRow[row, NumVertices]
moveCol[row, NumVertices-1]
```
should be:
```
moveRow(row, NumVertices)
moveCol(row, NumVertices-1)
```

---
Pg. 291 - DelVertex method:

`moveCol(row, numVertices-1)`
should be
`moveCol(col, numVertices-1)`

---
Pg. 291 - DelVertex method:

Fails to reduce the vertex count.
`numVerts--;`
needs to be added to the end of the method.

---
Pg. 292 - TopSort method:

Declaration of gStack is missing:
`Stack<string> gStack = new Stack<string>();`

---
Pg. 292 - TopSort method.

Line:
```
int origVerts = numVertices;
```
is not needed. origVerts is never used.

---
Pg. 293 - Program block.

Line:
```
theGraph.AddEdge(3, 4);
```
is invalid, there are only 4 vertexes, index 0 - 3, thus this statement should cause an error & has been removed.
