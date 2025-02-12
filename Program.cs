// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();
        Console.WriteLine("Hello world!");
        
        // thisFish = Fish("little fish")
	    // thisFish.setMaxSize(3)
	    // thisDuck = Duck("little duck")
	    // FOR count = 1 To 3
	    //   thisDuck.feed()
	    //   Output(thisDuck.getState())
	    //   thisFish.feed()
	    //   print(thisFish.getState())
	    // END FOR
    }
}

// Animal = CLASS
//   Protected
//     state: String 
//     size: Integer
//   Public
//     Constructor(s)
//       state = s
//       size = 0
 
//     Procedure feed()
//       size = size + 1
//       OUTPUT state, " fed"
 
//     Function getState()
//       RETURN state
 
//     Function getSize()
//       RETURN size
 
// END CLASS
 
// Fish = SubClass(Animal)
//   Private
//     maxSize : Integer
//   Public
//     Procedure setMaxSize(m)
//       maxSize = m
//     Procedure feed(Override)
//       size += 2
//       OUTPUT state, " fed"
//       IF size >= maxSize THEN
//         state = "BIG FISH"
// 	    END IF
// END CLASS
 
// Duck = Subclass(Animal)
//   Public
//     Procedure feed(Override)
//       Animal.feed()
//       IF size = 5 THEN
//         state = "BIG DUCK" 
// 	END IF
// END CLASS
 
	 
	
