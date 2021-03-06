// #Regression #Diagnostics 
// Regression test for FSHARP1.0:3292
// Give a warning when the user attempts to redefine "=", "<", ">", ">=", "<=" or "<>" or define static members with these names
//<Expects id="FS0086" span="(8,6-8,7)" status="warning">The '>' operator should not normally be redefined\. To define overloaded comparison semantics for a particular type, implement the 'System.IComparable' interface in the definition of that type\.</Expects>
//<Expects id="FS0086" span="(9,8-9,9)" status="warning">The '>' operator should not normally be redefined\. To define overloaded comparison semantics for a particular type, implement the 'System.IComparable' interface in the definition of that type\.</Expects>
//<Expects id="FS0086" span="(11,20-11,21)" status="warning">The name '\(>\)' should not be used as a member name\. To define comparison semantics for a type, implement the 'System\.IComparable' interface\. If defining a static member for use from other CLI languages then use the name 'op_GreaterThan' instead\.</Expects>
module M
let (>) x y = x + y
let f (>)  = 1 < 2
type C() =
    static member (>) (x:C,y:C) = true
