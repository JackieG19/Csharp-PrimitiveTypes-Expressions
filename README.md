# Primitive Type and Expressions

*_Integral Numbers_*

| C# Type | .NET Type | Bytes  | Range |
| ------- | ----------| ------ | ----- |
|   byte  |     Byte  |   1    | 0 to 255 |
|   short |    Int16  |   2    | -32,768 to 32,767 |
|   int   |    Int32  |   4    | -2.1B to 2.1B |
|   long  |   Int64   |   8    | ... |

*_Real Number_*

| C# Type | .NET Type | Bytes  | Range |
| ------- | ----------| ------ | ----- |
|  float  |   Single  |   4    | -3.4x10(38) to 3.4x10(38) |
|  double |   Double  |   8    | ... |
| decimal |  Decimal  |   16   | -7.9x10(28) to 7.9x10(28) |

*_Character and Boolean_*

| C# Type | .NET Type | Bytes  | Range |
| ------- | ----------| ------ | ----- |
|   char  |     Char  |   2    | Unicode Characters |
|   bool  |  Boolean  |   1    | True / False |

*_Non-Primitive Types_*
- String
- Array
- Enum
- Class
___

## 1. Variables and Constants
- Variable : a name given to a storage location in memory
- Constant : an immutable value

## 2. Overflowing

## 3. Scope
```
// where a variable or constnt has meaning

{
    byte a = 1;
    {
        byte b = 2;
        {
            byte c = 3;
        }
    }
}
```
___
## 4. Type Conversion
- Implicit Type Conversion
```
byte b = 1; // 00000001
int i = b;  // 00000000 00000000 00000000 00000001

int i = 1;
float f = i;
```
- Explicit Type Conversion
```
int i = 1;  
byte b = i; // won't compile

int i = 1;
byte b = (byte)i; 

float f = 1.0f;
int i = (int)f;
```
- Non-compatible types
```
string s = "1";
int i = (int)s; // won't compile

string s = "1";
int i = Convert.ToInt32(s);
nt j = int.Parse(s);
```
- Convert
  - ToByte()
  - ToInt16()
  - ToInt32()
  - ToInt64()
___

## 5. Operators

| Arithmetic | Operators | Example  | 
| ---------- | ----------| -------- |
|       Add  |      +    |   a + b  | 
|   Subtract |      -    |   a - b  | 
|   Multiply |      *    |   a * b  | 
|    Divide  |      /    |   a / b  |
|   Remainder|     %     |   a % b  |
|  Increment |     ++    |    a++ (a = a + 1) |
|  Decrement |    --     |    a-- (a = a - 1) |

- Postfix Increment
```
int a = 1;
int b = a++;
// a = 2, b = 1
```
- Prefix Increment
```
int a = 1;
int b = ++a;
// a = 2, b = 2
```
| Comparison | Operators | Example  | 
| ---------- | ----------| -------- |
|     Equal  |     ==    |  a == b  | 
|   No Equal |     !=    |  a != b  | 
| Greater than |    >    |   a > b  | 
| Greater than or equal to |   >=   |   a >= b  |
|  Less than  |    <     |   a < b  |
|  Less than or equal to |  <=  |   a <= b  |

| Assignment | Operators | Example  | 
| ---------- | ----------| -------- |
| Assignment |     ==    |    a = 1 | 
| Addition   |     +=    |  a += b (a = a + 3)| 
| Subtraction |    -=    |   a -= b | 
| Multiplication |   *=  |   a *= b  |
|  Division  |    /=    |   a /= b  |

| Logical | Operators | Example  | 
| ---------- | ----------| -------- |
|     Add    |     &&    |  a && b  | 
|     Or     |     ll    |  a ll b  | 
|     Not    |      !    |    !a    | 

| Bitwise | Operators | Example  | 
| ---------- | ----------| -------- |
|     Add    |     &    |  a & b  | 
|     Or     |     l    |  a l b  | 
