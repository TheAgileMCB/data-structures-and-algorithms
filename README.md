# data-structures-and-algorithms
a repository for DeltaV 301 and 401 code challenges

### Table of Contents
#### 301
#### 401
- [Challenge 1 (Reverse Array)](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/Program.cs)
- [Challenge 2 (Insert and Shift Array)](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/ArrayShift.cs) 
- [Challenge 3 (Binary Search)](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/ArrayMethods.cs)

#

## challenges301


## Challenges401

#### 20200504
### Reverse Array

#### Challenge
Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.
Example

#### Input / Output
[1, 2, 3, 4, 5, 6]	[6, 5, 4, 3, 2, 1]
[89, 2354, 3546, 23, 10, -923, 823, -12]	[-12, 823, -923, 10, 23, 3546, 2354, 89]
[2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199]	[199, 197, 193, 191, 181, 179, 173, 167, 163, 157, 151, 149, 139, 137, 131, 127, 113, 109, 107, 103, 101, 97, 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2]

#### Approach and Efficiency
- We used a for loop because it felt logical and most resembled material we were comfortable with from learning JavaScript. Our apporach has an O(n) time complexity.

#### Solution
![Challenge1ReverseArray](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/assets/Challenge1ReverseArray.jpg)

#

#### 20200505
### Insert and Shift Array

#### Challenge
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

#### Input / Output

[2,4,6,8], 5	[2,4,5,6,8]
[4,8,15,23,42], 16	[4,8,15,16,23,42]

#### Approach and Efficiency
- Our apporach has an O(n) time and space complexity.

#### Solution
![Challenge2ShiftArray](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/assets/Challenge2ShiftArray.png)

#

#### 20200506
### Binary Search

#### Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

#### Input / Output

[4,8,15,16,23,42], 15	2
[11,22,33,44,55,66,77], 90	-1

#### Approach and Efficiency
- The binary search is a notorious O log(n) function!

#### Solution
![Challenge3BinarySearch](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/Challenges401/assets/Challenge3BinarySearch.png)

#

## Badges
![.NET Core](https://github.com/mcbarnhart/data-structures-and-algorithms/workflows/.NET%20Core/badge.svg)

## Lincense
This information is licensed under the [MIT License](https://github.com/mcbarnhart/data-structures-and-algorithms/blob/master/LICENSE).
