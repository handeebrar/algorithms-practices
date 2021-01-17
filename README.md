<div align="center">
  
  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]

  <br />

  <h3 >Algorithm Practices</h3>
  <p>
    <a href="https://github.com/handeebrar/algorithms-practices/issues">Report Bug</a>
    ·
    <a href="https://github.com/handeebrar/algorithms-practices/issues">Request Feature</a>
  </p>
  <hr>
</div>

<!-- Table of Contents -->
<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#supported-programming-languages">Supported Programming Languages</a></li>
      </ul>
    </li>
    <li>
      <a href="#algorithms">Algorithms</a>
      <ul>
        <li><a href="#diagonal-difference">Diagonal Difference</a></li>
        <li><a href="#plus-minus">Plus Minus</a></li>
      </ul>
    </li>
  </ol>
</details>

<!-- About The Project -->
## About The Project

It is a repository, where we produce solutions in different programming languages with different suitable for the problems found in various sources (Hackerrank, Project Euler etc.) and collect them together. :rocket:

<!-- Supported Programming Languages -->
### Supported Programming Languages

* C
* C#
* Java
* GoLang

<!-- Algorithms -->
## Algorithms

<!-- Diagonal Difference -->
### Diagonal Difference

Given a square matrix, calculate the absolute difference between the sums of its diagonals. For example, the square matrix arr is shown below:

```bash
1 2 3
4 5 6
9 8 9 
```

The left-to-right diagonal = 1 + 5 + 9 = 15. The right to left diagonal = 3 + 5+ 9 = 17. Their absolute difference is |15–17| = 2 

#### Function description
Complete the diagonalDifference function in the editor below. diagonalDifference takes the following parameter:

* int arr[n][m]: an array of integers

#### Return

* int: the absolute diagonal difference

#### Input Format

The first line contains a single integer, n , the number of rows and columns in the matrix arr .
Each of the next n lines describes a row, arr[i], and consists of n space-separated integers arr[i][j].

#### Constraints
* — 100 ≤ arr[i][j] ≤ 100

#### Output Format
Print the absolute difference between the sums of the matrix’s two diagonals as a single integer.

#### Sample Input

```bash
3
11 2 4
4 5 6
10 8 -12
```

#### Sample Output

```bash
15
```

#### Explanation
The primary diagonal is:

```bash
11
   5
     -12
```

Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

```bash
     4
   5
10
```

Sum across the secondary diagonal: 4 + 5 + 10 = 19
Difference: |4 - 19| = 15

Note: |x| is the absolute value of x

<hr>

<!-- Plus Minus -->
### Plus Minus

Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10 ^ -4 are acceptable.

For example, given the array arr = [1, 1, 0, -1,-1] there are 5 elements, two positive, two negative and one zero. Their ratios would be 2/5 = 0.400000, 2/5 = 0.400000 and 1/5 = 0.200000. It should be printed as

```bash
0.400000
0.400000
0.200000
```

#### Function description
Complete the plusMinus function in the editor below. It should print out the ratio of positive, negative and zero items in the array, each on a separate line rounded to six decimals.

plusMinus has the following parameter(s):

* arr: an array of integers

#### Input Format

The first line contains an integer, n, denoting the size of the array.
The second line contains n space-separated integers describing an array of numbers arr(arr[0], arr[1], arr[2], . . . arr[n – 1]).

#### Constraints
* 0 < n < 100
* – 100 < arr[i] < 100

#### Output Format
You must print the following 3 lines:

1. A decimal representing of the fraction of positive numbers in the array compared to its size.
2. A decimal representing of the fraction of negative numbers in the array compared to its size.
3. A decimal representing of the fraction of zeros in the array compared to its size.

#### Sample Input

```bash
6
-4 3 -9 0 4 1
```

#### Sample Output

```bash
0.500000
0.333333
0.166667
```

#### Explanation
There are 3 positive numbers, 2 negative numbers, and 1 zero in the array.
The proportions of occurrence are positive: 3/6 = 0.500000, negative: 2/6 = 0.333333 and zeros: 1/6 = 0.166667.

<hr>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/handeebrar/algorithms-practices.svg?style=for-the-badge
[contributors-url]: https://github.com/handeebrar/algorithms-practices/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/handeebrar/algorithms-practices.svg?style=for-the-badge
[forks-url]: https://github.com/handeebrar/algorithms-practices/network/members
[stars-shield]: https://img.shields.io/github/stars/handeebrar/algorithms-practices.svg?style=for-the-badge
[stars-url]: https://github.com/handeebrar/algorithms-practices/stargazers
