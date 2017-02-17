Constants:

Static by default
Must have compilation-time value (i.e.: you can have "A"+"B" but cannot have method calls)
Can be used in attributes
Are copied into every assembly that uses them (every assembly gets a local copy of values)
Could be declared within functions
The compiler performs some optimization by not declaring any stack space for the field
Readonly instance fields:

Are evaluated when instance is created
Must have set value by the time constructor exits
Static readonly fields:

Static constructors :{
Static constructors are parameterless.

Static constructors can't be overloaded.

There is no accessibility specified for Static constructors.
}

Are evaluated when code execution hits class reference (i.e.: new instance is created or static method is executed)
Must have evaluated value by the time static constructor is done
You really do not want to put ThreadStaticAttribute on these (since static constructor will be executed in one thread only and it will set value for its thread; all other threads will have this value uninitialized)
Class that has only constant or readonly instance fields is considered to be prepared for the concurrency challenges of parallel computing, since it has no mutable state.