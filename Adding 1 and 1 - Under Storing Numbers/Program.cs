//Precalculation of result(into a variable)
int sum = 1 + 1;

// Output to the user
Console.WriteLine(@"
Answer to Simple Engineering maths test:

=======================================

One and One is: " + sum);

// Waiting for Enter
Console.ReadLine();

/* DISCUSSION:
 * 
 *  Please compare the calculation of ADDED 1 to 1 to the calculations from the previous
    chapter. Here you explicitly store the result in a variable. This allows you to avoid
    possible problems with the order of evaluation and getting the incorrect answer of 11.
 */