# Hash Tables

A hash table is a data structure that stores data in an organized way using unique index values in an array format. This allows for fast data access if you know the specific index of the data you're looking for. In essence, it's a data structure where adding and finding data is quick, regardless of how much data you have. Hash tables use arrays for storage and employ a hashing technique to determine where to insert or find elements.


#### Solution
*[Solution- HashTables](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructures/HashTables)*

#### Unit Test
*[Unit Test- HashTables](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructuresTests/HashtableLabTest1.cs)*


## Challenge
Implement a Hashtable Class with the following methods:

### set
- Arguments: key, value
- Returns: nothing
- This method should hash the key, and set the key and value pair in the table, handling collisions as needed.
   Should a given key already exist, replace its value from the value argument given to this method.
### get
- Arguments: key
- Returns: Value associated with that key in the table
### has
- Arguments: key
- Returns: Boolean, indicating if the key exists in the table already.
### keys
- Returns: Collection of keys
### hash
- Arguments: key
- Returns: Index in the collection for that key



## Approach & Efficiency

### Big O Time:

- Set - O(1) 
- Get - O(n)
- Hash - O(1)
- Has - O(1)


### Big O Space:

- Set - O(1) 
- Get - O(1)
- Hash - O(1)
- Has - O(1)
