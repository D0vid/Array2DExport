using Godot;
using Godot.Collections;

namespace Array2DExport.addons.array_2d_export;

[GlobalClass]
public partial class DebugResource : Resource
{
    [Export] public Array<Array<int>> DebugResourceArray2D;
}