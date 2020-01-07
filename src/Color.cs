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
    public static class Color
    {

        /// <summary>
        /// Return a color by name from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="name">Color Name</param>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color ByName(string name, int alpha = 255)
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
            return (DSCore.Color)theMethod.Invoke(null, new object[] { alpha });
        }

        /// <summary>
        /// Aqua from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        /// 
        public static DSCore.Color Aqua(int alpha = 255)
        {
            return new Clr("#7fdbff").ByARGB(alpha);
        }

        /// <summary>
        /// Blue from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Blue(int alpha = 255)
        {
            return new Clr("#0074d9").ByARGB(alpha);
        }

        /// <summary>
        /// Lime from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Lime(int alpha = 255)
        {
            return new Clr("#01ff70").ByARGB(alpha);
        }

        /// <summary>
        /// Navy from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Navy(int alpha = 255)
        {
            return new Clr("#001f3f").ByARGB(alpha);
        }

        /// <summary>
        /// Teal from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Teal(int alpha = 255)
        {
            return new Clr("#39cccc").ByARGB(alpha);
        }

        /// <summary>
        /// Olive from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Olive(int alpha = 255)
        {
            return new Clr("#3d9970").ByARGB(alpha);
        }

        /// <summary>
        /// Green from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Green(int alpha = 255)
        {
            return new Clr("#2ecc40").ByARGB(alpha);
        }

        /// <summary>
        /// Red from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Red(int alpha = 255)
        {
            return new Clr("#ff4136").ByARGB(alpha);
        }

        /// <summary>
        /// Maroon from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Maroon(int alpha = 255)
        {
            return new Clr("#85144b").ByARGB(alpha);
        }

        /// <summary>
        /// Orange from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Orange(int alpha = 255)
        {
            return new Clr("#ff851b").ByARGB(alpha);
        }

        /// <summary>
        /// Purple from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Purple(int alpha = 255)
        {
            return new Clr("#b10dc9").ByARGB(alpha);
        }

        /// <summary>
        /// Yellow from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Yellow(int alpha = 255)
        {
            return new Clr("#ffdc00").ByARGB(alpha);
        }

        /// <summary>
        /// Fuchsia from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Fuchsia(int alpha = 255)
        {
            return new Clr("#f012be").ByARGB(alpha);
        }

        /// <summary>
        /// Gray from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Gray(int alpha = 255)
        {
            return new Clr("#aaaaaa").ByARGB(alpha);
        }

        /// <summary>
        /// White from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color White(int alpha = 255)
        {
            return new Clr("#ffffff").ByARGB(alpha);
        }

        /// <summary>
        /// Black from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Black(int alpha = 255)
        {
            return new Clr("#111111").ByARGB(alpha);
        }

        /// <summary>
        /// Silver from clrs.cc a nicer color palette
        /// </summary>
        /// <param name="alpha">Alpha</param>
        /// <returns>Color</returns>
        public static DSCore.Color Silver(int alpha = 255)
        {
            return new Clr("#dddddd").ByARGB(alpha);
        }

    }
}
