# Permutations in C# (CodeWars 4kyu)
## To see the code, open the folder and then open "Program.cs."
## My solution in english...I sequence through the source string creating new permutations by inserting the new character between all the spaces in each of the previous generation's permutations.  In the end, I only return the permutations that have the same length as the input.  For example: 
input = "1234"
first round:  1
second round:  12, 21
third round:  312, 132, 123,    321, 231, 213
fourth round (the keepers):  4312, 3412, 3142, 3124     4132, 1432, 1342, 1324   ..... and so on

In this kata you have to create all permutations of an input string and remove duplicates, if present. This means, you have to shuffle all letters from the input in all possible orders.

Examples:

permutations('a'); // ['a']
permutations('ab'); // ['ab', 'ba']
permutations('aabb'); // ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
The order of the permutations doesn't matter.
ALGORITHMS      -   PERMUTATIONS    -   STRINGS

https://www.codewars.com/kata/5254ca2719453dcc0b00027d 