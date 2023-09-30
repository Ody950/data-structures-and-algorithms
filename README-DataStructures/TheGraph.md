# Graphs
Graphs are nonlinear data structures composed of vertices (or nodes) that may be connected by line segments referred to as edges. Using this application, you can see how a graph and its nodes are created, as well as how the nodes are connected.



#### Solution
*[Solution- Graphs](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructures/Graph)*

#### Unit Test
*[Unit Test- Graphs](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructuresTests/GraphTest.cs)*



## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:

AddNode()
* Adds a new node to the graph
* Takes in the value of that node
* Returns the added node

AddEdge()
* Adds a new edge between two nodes in the graph
* Include the ability to have a “weight”
* Takes in the two nodes to be connected by the edge
* Both nodes should already be in the Graph

GetNodes()
* Returns all of the nodes in the graph as a collection (set, list, or similar)

GetNeighbors()
* Returns a collection of nodes connected to the given node
* Takes in a given node
* Include the weight of the connection in the returned collection

Size()
* Returns the total number of nodes in the graph
## Approach & Efficiency
* Big O Space = O(n)
* Big O Time = O(n)

This approach starts with creating a Node class specific to graphs in that each node has properties for a Value, and a List of Edges, and each Edge has properties for a Neighbor node and a Weight of the connection between nodes. Every instance of a graph has its nodes stored in a List of nodes which can be counted or returned as a list.

## API
AddNode()
* Adds a node to the graph.

AddEdge()
* Adds an edge to a node which connects to another node or itself, and includes a weight value.

GetNodes()
* Returns a list of nodes within the graph.

GetNeighbors()
* Returns a list of neighbors of a given node, including the weight of each edge between them.

Size()
* Returns a count of all the nodes in a graph.
