This file contains code additions & changes for the code samples published in this repository from the book Data Structures & Algorithms using C# by Michael McMillian.

---
Pg. 287 - Vertex class now includes ToString overridde to display vertex label.

---
Pg. 288 - Graph class now has additional directed member, this member indicates whether the graph is directed or non-directed. The member is initilized in the contstructor. The AddEdge method has been updated to only add the second from => to edge for non-directed graphs.

---
Pg. 288 - Methods in graph class now include error handling to prevent invalid indexes from being specified.

---
Pg. 288 - Graph class now has copy constructor used by updated TopSort Algorithm. 

---
Pg. 288 - Graph class has new ShowAdjacencyMatrix() method which displays the full adjacency matrix for the graph.

---
Page 291 - TopSort algorithm no longer changes the graph itself, instead it creates a copy of the graph & uses that to do the sort.

---
