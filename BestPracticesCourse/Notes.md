
# Naming and handling classes

1. Use PascalCasing as always for classes, properties, **Meaningful**, namespaces
2. Use camelCase for parameters
3. Don't be convuluted
4. Choose Private if possible (tests needs public)
5. **Use ///** Except if very obvious, useful for intelisense
6. *propfull*

7. One class per code file
8. No Large Classes!

## Constructor/Tests

1. *ctor*
2. constructor, use this() for calling the constructor without parameters (Actor Class), avoids repeated code
3. *testm*
4. Test Detail Summary (Will show output!)

## Namespaces

1. Use Namespaces in using when possible
2. Don't name Namespaces like Classes
3. Format <Company>.<Technology>.<Feature>

## Static

1. They can't be instanciated (as I usually forget)
2. Make a separed project for static classes
3. Don't forget references while testing
4. Use for Common Utilities (no random bucket)

5. *sparingly* - in a restricted or infrequent manner; in small quantities.

## Singletons

(see design C# for features)
1. Only if you need one instantce

## Method Overloading

1. /// reads parameters method
2. Comment
3. Use few parameters (or use an object)
4. Order

## Method Chaining

1. Avoid Duplication of code!
2. No need to alter test cases
3. Don't complicate

## Const/Readonly

1. Readonly can be setup in runtime

## Properties

1. See Lazy Loading (getter)
2. Validate incoming value with (setter) **important**
3. Use getter for simple protection, formatting, and initializing
4. Use setter for simple protection, formatting, and validation

5. *prop* when getter/setter can be ignored aka **Auto Implemented Properties**
6. No abbreviations

## Object

1. If a object is needed always initialize in construct
2. If sometimes use lazy load with property getter
3. Always check for null! Use null conditional operator

## using

1. For streams and DB connections