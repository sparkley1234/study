Short answer: minimum possible access (cf Jon Skeet's answer).

Long answer:

Non-nested types, enumeration and delegate accessibilities (may only have internal or public accessibility)

                     | Default   | Permitted declared accessibilities
------------------------------------------------------------------
namespace            | public    | none (always implicitly public)

enum                 | public    | none (always implicitly public)

interface            | internal  | public, internal

class                | internal  | public, internal

struct               | internal  | public, internal

delegate             | internal  | public, internal
Nested type and member accessiblities

                     | Default   | Permitted declared accessibilities
------------------------------------------------------------------
namespace            | public    | none (always implicitly public)

enum                 | public    | none (always implicitly public)

interface            | public    | none

class                | private   | All¹

struct               | private   | public, internal, private²

delegate             | private   | All¹

constructor          | private   | All¹

interface member     | public    | none (always implicitly public)

method               | private   | All¹

field                | private   | All¹

user-defined operator| none      | public (must be declared public)
¹ All === public, protected, internal, private, protected internal

² structs cannot inherit from structs or classes (although they can, interfaces), hence protected is not a valid modifier
The accessibility of a nested type depends on its accessibility domain, which is determined by both the declared accessibility of the member and the accessibility domain of the immediately containing type. However, the accessibility domain of a nested type cannot exceed that of the containing type.

Note: CIL also has the provision for protected and internal (as opposed to the existing protected "or" internal), but to my knowledge this is not currently available for use in C#.

See:

http://msdn.microsoft.com/en-us/library/ba0a1yw2.aspx
http://msdn.microsoft.com/en-us/library/ms173121.aspx
http://msdn.microsoft.com/en-us/library/cx03xt0t.aspx
(Man I love Microsoft URIs...)



Modifiers	| Outside Assembly		 | Derived Class
private		| No				 | No				
public		|Yes				 | Yes			
protected	| No				 | No
internal	| Yes ( this assembly only)	 | Yes ( this assembly only)
internal protected	Yes ( this assembly only)|Yes


Tables taken from MSDN:

~Declared accessibility	Meaning~
public - Access is not restricted.
protected - Access is limited to the containing class or types derived from the containing class.
internal - Access is limited to the current assembly.
protected internal - Access is limited to the current assembly or types derived from the containing class.
private - Access is limited to the containing type.