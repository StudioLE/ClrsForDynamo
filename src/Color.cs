using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clrs
{
    /// <summary>
    /// Colors from clrs.cc a nicer color palette
    /// http://clrs.cc
    /// </summary>
    public class Color
    {

        // Clrs from Clrs.cc

        /// <summary>
        /// Return a color by name from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="name">Color Name</param>
        /// <returns>Color</returns>
        public static DSCore.Color ByName(string name)
        {
            // This function uses Reflections to invoke the method of the specified name.
            // If the method name doesn't exist it throws an exception
            // @todo Add a try/catch to capture any exceptions thrown and deal with them gracefully...

            // The following resources were useful:
            // https://stackoverflow.com/questions/41042478/calling-a-static-method-of-a-class-using-reflection
            // https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase.invoke?redirectedfrom=MSDN&view=netframework-4.8#System_Reflection_MethodBase_Invoke_System_Object_System_Object___
            // https://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
            
            // Because the method is static we need to get type from this class name
            Type thisType = Type.GetType("Clrs.Color");

            // Get the method only if it is Public and Static
            MethodInfo theMethod = thisType.GetMethod(name, BindingFlags.Public | BindingFlags.Static);

            // Invoke the method with null params as it's static and parmeterless then force its return type to be DSCore.Color
            return (DSCore.Color)theMethod.Invoke(null, null);
        }

        /// <summary>
        /// Aqua from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Aqua()
        {
            return new Clr("#7fdbff").ByARGB();
        }

        /// <summary>
        /// Blue from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Blue()
        {
            return new Clr("#0074d9").ByARGB();
        }

        /// <summary>
        /// Lime from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Lime()
        {
            return new Clr("#01ff70").ByARGB();
        }

        /// <summary>
        /// Navy from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Navy()
        {
            return new Clr("#001f3f").ByARGB();
        }

        /// <summary>
        /// Teal from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Teal()
        {
            return new Clr("#39cccc").ByARGB();
        }

        /// <summary>
        /// Olive from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Olive()
        {
            return new Clr("#3d9970").ByARGB();
        }

        /// <summary>
        /// Green from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Green()
        {
            return new Clr("#2ecc40").ByARGB();
        }

        /// <summary>
        /// Red from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Red()
        {
            return new Clr("#ff4136").ByARGB();
        }

        /// <summary>
        /// Maroon from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Maroon()
        {
            return new Clr("#85144b").ByARGB();
        }

        /// <summary>
        /// Orange from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Orange()
        {
            return new Clr("#ff851b").ByARGB();
        }

        /// <summary>
        /// Purple from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Purple()
        {
            return new Clr("#b10dc9").ByARGB();
        }

        /// <summary>
        /// Yellow from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Yellow()
        {
            return new Clr("#ffdc00").ByARGB();
        }

        /// <summary>
        /// Fuchsia from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Fuchsia()
        {
            return new Clr("#f012be").ByARGB();
        }

        /// <summary>
        /// Gray from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Gray()
        {
            return new Clr("#aaaaaa").ByARGB();
        }

        /// <summary>
        /// White from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color White()
        {
            return new Clr("#ffffff").ByARGB();
        }

        /// <summary>
        /// Black from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Black()
        {
            return new Clr("#111111").ByARGB();
        }

        /// <summary>
        /// Silver from clrs.cc a nicer color palette
        /// </summary>
        /// <returns>Color</returns>
        public static DSCore.Color Silver()
        {
            return new Clr("#dddddd").ByARGB();
        }

    }
}
