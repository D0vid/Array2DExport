﻿#if TOOLS
using Godot;
using Godot.Collections;

namespace Array2DExport.addons.array_2d_export;

[Tool]
public static class Utils
{
    public const int DefaultArraySize = 3;

    public static Array<Array<int>> Default2DArray(int size = DefaultArraySize)
    {
        var result = new Array<Array<int>>();
        
        for (int x = 0; x < size; x++)
        {
            result.Add(new Array<int>());
            for (int y = 0; y < size; y++)
            {
                result[x].Add(0);
            }
        }

        int c = size / 2;
        result[c][c] = 1;
        return result;
    }
}
#endif