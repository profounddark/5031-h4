1. Why is test case #1 important?
   Test case #1 is an important edge case. An empty array is a meaningful test case because there are no elements (nothing to sort) but it's still a viable input for the algorithm. It's surprisingly easy to write an algorithm that works on an array and have it fail on an empty array, so that's always a good test case.

2. What’s the key difference between test cases #2 and #3? Why is this important when
   testing MergeSort?
   The size of the array. Test case #2 has an even number of elements, test case #3 has an odd number of elements. Because the MergeSort break the array into two halves, it's important to verify that it works when that break results in two pieces of different size.

3. Test case #4 is some digits of π. What else is important about test case #4?
   Test case #4 has duplicate items: 1 and 5 appear twice. This is another situation where a sorting algorithm may run afoul due to how it handles duplicates.
