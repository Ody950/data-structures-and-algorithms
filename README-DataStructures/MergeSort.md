
# Merge Sort


#### Solution
*[Solution- MergeSort](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructures/MergeSort.cs)*

#### Unit Test
*[Unit Test- MergeSort](https://github.com/Ody950/data-structures-and-algorithms/blob/main/DataStructures/DataStructuresTests/MergeSortTest.cs)*


## Description

write a Merge sort method which is a divide-and-conquer algorithm based on the idea of breaking down a list into several sub-lists until each sublist consists of a single element and merging those sublists in a manner that results into a sorted list.

# Approach & Efficiency (BigO)

Time: O(n log n) -  It is reducing the size of the array in half each time it has to work with it, thus reducing the amount of work to complete each iteration, Merging two sorted arrays of size n/2 each takes O(n) time.

Space: O(n) - A merge sort does not sort in place and requires additional storage space for the elements.

# Whiteboard

## Insertion Sort

<img src="./assets2/Insert19.jpg" style="width: 500px;">

- Pass:

- The input array is divided into two subarrays: [8, 4, 23] and [42, 16, 15].
- Subarray [8, 4, 23] is further divided into [8], [4], and [23].
- Subarray [42, 16, 15] is further divided into [42], [16], and [15].
- The subarrays are recursively sorted and merged back together.
- The merged subarrays result in [4, 8, 23] and [15, 16, 42].
- Finally, the entire array is merged, resulting in [4, 8, 15, 16, 23, 42].

- the input array [8, 4, 23, 42, 16, 15] is sorted, and the sorted array is [4, 8, 15, 16, 23, 42].
