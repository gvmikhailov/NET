
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly FizzBuzz
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 08 46 69 7A 7A 42 75 7A 7A 00 00 )          // ...FizzBuzz..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 08 46 69 7A 7A 42 75 7A 7A 00 00 )          // ...FizzBuzz..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 38 00 00 )                            //  2018..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 34 61 66 63 31 36 32 34 2D 35 35 61 37   // ..$4afc1624-55a7
                                                                                                  2D 34 65 31 39 2D 38 30 31 31 2D 66 38 39 62 37   // -4e19-8011-f89b7
                                                                                                  32 61 65 63 65 39 61 00 00 )                      // 2aece9a..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 36 2E 31 01   // ,Version=v4.6.1.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 36 2E 31 )          // amework 4.6.1
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module FizzBuzz.exe
// MVID: {B2D2EE4E-21AA-409D-B2A2-E9EF7ED6557D}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x07F40000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit FizzBuzz.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       72 (0x48)
    .maxstack  2
    .locals init ([0] int32 i)
    IL_0000:  ldc.i4.1
    IL_0001:  stloc.0
    IL_0002:  br.s       IL_0042

    IL_0004:  ldloc.0
    IL_0005:  ldc.i4.s   15
    IL_0007:  rem
    IL_0008:  brtrue.s   IL_0016

    IL_000a:  ldstr      "FizzBuzz"
    IL_000f:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0014:  br.s       IL_003e

    IL_0016:  ldloc.0
    IL_0017:  ldc.i4.3
    IL_0018:  rem
    IL_0019:  brtrue.s   IL_0027

    IL_001b:  ldstr      "Fizz"
    IL_0020:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0025:  br.s       IL_003e

    IL_0027:  ldloc.0
    IL_0028:  ldc.i4.5
    IL_0029:  rem
    IL_002a:  brtrue.s   IL_0038

    IL_002c:  ldstr      "Buzz"
    IL_0031:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0036:  br.s       IL_003e

    IL_0038:  ldloc.0
    IL_0039:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_003e:  ldloc.0
    IL_003f:  ldc.i4.1
    IL_0040:  add
    IL_0041:  stloc.0
    IL_0042:  ldloc.0
    IL_0043:  ldc.i4.s   100
    IL_0045:  ble.s      IL_0004

    IL_0047:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class FizzBuzz.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\gm\Distrz\GeekBrain\Vebinar7\FizzBuzz.res
