![image](https://github.com/D0vid/Array2DExport/assets/42772925/9612ca8d-6690-4c5f-b858-688ad924f8d5)

Usage
* Export a godot ``Array<Array<int>>``
* Its name must contain **Array2D**

```csharp
[GlobalClass]
public partial class DebugResource : Resource
{
    [Export] public Array<Array<int>> DebugResourceArray2D;
}
```
