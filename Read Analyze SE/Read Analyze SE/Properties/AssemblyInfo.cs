using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Read Analyze SE")]
[assembly: AssemblyDescription("Read plain text files in to see the number of occurences of words in the document. Also see the amount of starting words in sentences with the number of occurences. To use this, first convert a document to plain text, then open it with this. -NEW- Filter out charecters that are not in the CHARDEF list (lim 93). Limitations of program include that text files must be used for best results, some fancy charecters will not be reconized and words may be grouped togather. Product modules currently in build version 2.0--RA1-The orginal program for reading and analzing the word variance in a document. Includes counting word variance score and input document too. RAS1-Counts the uniqe sentence starters after a punctuation point (./!/?). RASE1- The search module function, users can use the search funtion to see the words before the searched word. **NEW IN 2.5** Search functionality, simplely change the option from find to search and search away.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Daniel Feissle")]
[assembly: AssemblyProduct("Read Analyze SE")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("830d10c3-4022-4c1d-b835-f6cd1f4d3811")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2.5.0.0")]
[assembly: AssemblyFileVersion("2.5.0.0")]
