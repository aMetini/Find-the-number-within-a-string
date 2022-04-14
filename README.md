# Find-the-number-within-a-string

A simple console application that takes a text string (string) as argument.  The text string is then searched through all sub-strings that are numbers beginning
and ending with the same number, but starting / final digit, or any other character must have the same  number of digits.

For example, 3463 is a correct number, but 34363 is not because there is an additional 3 in the number. Strings with letters in between (eg 95A9) is also not a 
correct number either.

Print and mark each correct part string
For each such substring string that matches the criterion above, the program will print a row with the entire string, wherein the sub-string is marked in another color.

Add together all numbers and print the total
Lastly, the program will also add together all numbers it found as above and print it in the program console. 
