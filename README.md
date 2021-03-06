LINQPadUtils
============
 
A small collection of extension methods which I find useful for LINQPad on occasion. They display a little more information than the `Dump()` counterpart. Use with caution on large data sets.

[Download the compiled binary here](https://github.com/vincpa/LINQPadUtils/releases)

#### `DumpReflect()`

In addition to the standard `Dump()` output, this will also obtain values by calling methods which do not contain any parameters. Private, internal, protected and private members are also displayed. There's also an option to specify the reflected depth which works a little differently. The main difference being that primitive types are also reflected rather than simply being displayed.

All of the standard overloads of the builtin `Dump()` method are supported.

![DumpReflect Screenshot](https://github.com/vincpa/LINQPadUtils/raw/master/DumpReflectScreenie.jpg)

#### `DumpSort()`

Not quite as sophisticated as its `Dump()` counterpart, but allows tables to be sorted and exported as HTML.

#### `DumpJson()`

Displays an object graph much like the `Dump()` method, but Json formatted.

![DumpJson Screenshot](https://github.com/vincpa/LINQPadUtils/raw/master/DumpJsonScreenie.jpg)

#### `Reflect()`

Reflects over a type and gets the values required for `DumpReflect()`. Can be used in conjunction with `Dump()`. For example, `obj.Reflect().DumpJson()` or `obj.Reflect().Dump()` which is equivalent to `DumpReflect()`.

### Known issues

- For some types `DumpReflect().DumpJson()` will fail due to cyclic dependencies.

- The DumpSort() extension method is still very buggy but works great on simple collections if you need to sort a data set and export it as HTML. Reverse engineering the LINQPad Dump() method with the same polish is much harder than it looks :-)
