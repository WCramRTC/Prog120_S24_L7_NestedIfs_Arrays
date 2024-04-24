# Prog120_S24_L7_NestedIfs_Arrays

---

## Nested Ifs


**What are Nested Conditions?**

Nested conditions are like a series of decisions within decisions. You evaluate one condition, and if it's true, you might have to make another decision, and maybe even another one after that.

**Real-World Examples**

1. **Ordering a Meal at a Restaurant**

   * **Condition 1:** Are you hungry?
      * **If yes:** Proceed to the restaurant. (Nested decisions begin)
          * **Condition 2:** Do you want a burger or pasta?
             * **If burger:** 
                 *  **Condition 3:** Do you want fries or a salad with it?
             * **If pasta:**
                 * **Condition 3:** Do you want red sauce or white sauce?
   * **If no:** Stay home.

2. **Getting Ready for the Day**

   * **Condition 1:** Is it raining outside?
      * **If yes:**
          * **Condition 2:** Is it heavily raining?
              * **If yes:** Take your car.
              * **If no:** Grab an umbrella and walk.
   * **If no:**
          * **Condition 2:** Is it cold outside?
               * **If yes:** Put on a jacket.
               * **If no:** You can go with a lighter outfit.

**C# Code Example**

Let's translate the getting ready for the day scenario into a C# snippet:

```csharp
bool isRaining = true; 
bool isCold = false;

if (isRaining) 
{
    if (isHeavilyRaining) 
    {
        Console.WriteLine("Take your car.");
    } 
    else 
    {
        Console.WriteLine("Grab an umbrella and walk.");
    }
} 
else 
{
    if (isCold)
    {
        Console.WriteLine("Put on a jacket.");
    } 
    else 
    {
        Console.WriteLine("You can go with a lighter outfit.");
    }
}
```

**Key Points**

* **Indentation:** Notice how the inner `if` statements are indented. This makes the code much easier to read and understand the logical flow.
* **Flexibility:** Nested conditions let you create complex decision-making processes to match real-life scenarios where multiple factors influence outcomes.
* **Efficiency:**  In some cases, nested conditions provide a more organized and potentially efficient way to structure your logic compared to a long chain of `if...else if` statements.

---

## Arrays

**What is an Array?**

* **Analogy:** Think of an array as a special container that stores a collection of items having the same data type. Imagine it like an egg carton—you can store multiple eggs (data) in an organized way, but they all have to be eggs (the same data type).

**Key Characteristics**

* **Data Type:** An array holds items of a single data type (e.g., integers, strings, floats, even custom objects).
* **Ordered:** Each item in an array has a specific position, called an index, starting at 0.  
* **Fixed Size:** When you create an array, you specify its size, so the number of elements it can hold is set.

**Real-World Examples**

1. **Grocery List:** You can store your grocery list as an array of strings: 
   ```csharp
   string[] shoppingList = { "Bread", "Milk", "Eggs", "Apples" };
   ```

2. **Student Grades:** Store a class's test scores in an array of numbers:
   ```csharp
   int[] testScores = { 85, 92, 78, 90, 81 };
   ```

3. **Days of the Week:** Represent the days of the week as an array of strings:
   ```csharp
   string[] daysOfWeek = { "Monday", "Tuesday", ... , "Sunday"};
   ```

**C# Code Snippets**

**1. Declaring an Array**

```csharp
// Declare an array of integers 
int[] numbers; 

// Declare an array of strings
string[] colors;
```

**2. Creating and Initializing an Array**

```csharp
// Create an array of numbers with values 
int[] ages = { 25, 32, 18, 40 }; 

// Create an empty array of size 5 (for strings)
string[] names = new string[5]; 
```

**3. Accessing and Modifying elements**

```csharp
// Get the first element (index 0)
Console.WriteLine(ages[0]); // Output: 25

// Change the third element (index 2)
ages[2] = 20;
```

**4. Looping Through an Array**

```csharp
// Using a for loop
for (int i = 0; i < colors.Length; i++)
{
    Console.WriteLine(colors[i]);
}

// Using a foreach loop (simpler)
foreach (string color in colors)
{
    Console.WriteLine(color);
}
```

**Important Note:** Array indices start at 0. So, an array of size 5 has elements at indices 0, 1, 2, 3, and 4.

---

## Terminology

Here's a list of key terminology associated with arrays and nested conditions, along with brief explanations:

**Array Terminology**

* **Array:** A data structure that stores a fixed-size collection of elements of the same data type.
* **Element:** A single value stored within an array.
* **Index:** The numerical position of an element within an array (starting from 0).
* **Length:**  The total number of elements that an array can hold.
* **Initialization:** The process of assigning initial values to an array when it's created.
* **Iteration/Looping:** The process of going through each element of an array using constructs like `for` loops or `foreach` loops.
* **Multidimensional Arrays:** Arrays that have more than one dimension (e.g., a 2D array represents a table).

**Nested Condition Terminology**

* **Nested `if`, `if...else`, `if...else if`:**  Where `if` statements are placed inside other `if` statements to create multiple levels of decision-making.
* **Boolean Operators:** Used to combine conditions (`&&` for AND, `||` for OR, `!` for NOT).
* **Logical Flow:** The order in which conditions are evaluated and how the outcome of one condition affects the evaluation of subsequent conditions.
* **Branching:** The different paths the code can take depending on the results of conditions.
