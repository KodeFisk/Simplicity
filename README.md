# KodeFisk.Simplicity

A library of extension methods to make C# easier to write and read.

## Methods

### HasValue

Checks if the string has a valid value (not `null`, empty or whitespace) and is at least the specified length.

```C#
"Valid".HasValue(); // True
"Valid".HasValue(5); // True
"Valid".HasValue(6); // False (length less than 6)
```

### Mutate

Let's you make changes to an object in a one-line expression. It returns the original instance of the object.

```C#
myWpfButton.Mutate(button =>
{
    Grid.SetColumn(button, 1);
});
```

### Assign

Let's you assign an object to a variable in a "fluent" syntax.

```C#
List<int> list;
new List<int> {0, 1, 2}.Assign(out list);
```

