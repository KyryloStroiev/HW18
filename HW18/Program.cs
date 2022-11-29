

using System.Reflection;

Assembly assemblys = Assembly.LoadFrom("C:\\Users\\User\\Desktop\\HM\\HW18\\MyLibrary\\MyAssembly.cs");
Type t = assemblys.GetType("MyLibrary.MyAssembly");
var metods = t.GetMethod("Metod", new Type[] {typeof(int), typeof(int)});
if (metods != null)
{
    throw new Exception();
}
object[] constructorParameters = new object[2];
constructorParameters[0] = 150;
constructorParameters[1] = 5;

var obj = Activator.CreateInstance(t, constructorParameters);

object[] parameters = new object[2];
parameters[0] = 2342;
parameters[1] = 125;

var records = metods.Invoke(obj, parameters);
Console.WriteLine(records);