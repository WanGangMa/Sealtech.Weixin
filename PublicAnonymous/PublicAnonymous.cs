using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAnonymous
{
    class PublicAnonymous
    {
        static void Main(string[] args)
        {
            var asmFile = args[0];
            //Console.WriteLine("Making anonymous types public for '{0}'.", asmFile);

            var asmDef = AssemblyDefinition.ReadAssembly(asmFile, new ReaderParameters
            {
                ReadSymbols = true
            });

            var anonymousTypes = asmDef.Modules
                .SelectMany(m => m.Types)
                .Where(t => t.Name.Contains("<>f__AnonymousType"));

            foreach (var type in anonymousTypes)
            {
                type.IsPublic = true;
            }

            asmDef.Write(asmFile, new WriterParameters
            {
                WriteSymbols = true
            });
        }
    }
}
