
# Sorting Comparisons


#### Solution
*[Solution- Sorting-Comparisons](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructures/SortingComparisons.cs)*

#### Unit Test
*[Unit Test- Sorting-Comparisons](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructuresTests/SortingComparisonsTest.cs)*


## Description

- write functions which sort domain objects. Your functions will receive an array of Movie objects. Each Movie object has a title (string), a year (number), and a list of genres (array of strings). One function will sort the movies by most recent year first. One function will sort the movies, alphabetical by title, but will ignore any leading “A”s, “An”s, or “The”s. Test outputs for these functions, and an array of sample data, have been provided in test and movies.

- write tests for your comparator functions. This may necessitate refactoring the code you wrote in part one. Your tests will need to call the comparator functions directly, and make assertions about the response values given test inputs.


# Approach & Efficiency (BigO)

Time: O(n log n) -  It is reducing the size of the array in half each time it has to work with it, thus reducing the amount of work to complete each iteration, Merging two sorted arrays of size n/2 each takes O(n) time.

Space: O(n) - A merge sort does not sort in place and requires additional storage space for the elements.


# Whiteboard

# Sorting Comparisons
<img src="./assets2/Insert20.jpg" style="width: 500px;">


