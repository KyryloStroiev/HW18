

using System.Reflection;

Assembly assemblys = Assembly.LoadFrom("MyAssembly.dll");
Type t = assemblys.GetType("MyLibrary.MyAssembly");
var metods = t.GetMethod("Metod", new Type[] {typeof(int), typeof(int)});

object[] constructorParameters = new object[2];
constructorParameters[0] = 0;
constructorParameters[1] = 0;

var obj = Activator.CreateInstance(t, constructorParameters);

object[] parameters = new object[2];
parameters[0] = 2342;
parameters[1] = 125;

var records = metods.Invoke(obj, parameters);
Console.WriteLine(records);
