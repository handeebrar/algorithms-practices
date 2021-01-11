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


<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/handeebrar/algorithms-practices.svg?style=for-the-badge
[contributors-url]: https://github.com/handeebrar/algorithms-practices/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/handeebrar/algorithms-practices.svg?style=for-the-badge
[forks-url]: https://github.com/handeebrar/algorithms-practices/network/members
[stars-shield]: https://img.shields.io/github/stars/handeebrar/algorithms-practices.svg?style=for-the-badge
[stars-url]: https://github.com/handeebrar/algorithms-practices/stargazers
