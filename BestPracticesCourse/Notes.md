
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