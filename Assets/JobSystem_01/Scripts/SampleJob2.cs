using Unity.Jobs;
using Unity.Collections;
using UnityEngine;

public struct SampleJob2 : IJob
{

    public NativeArray<float> result;

    public void Execute()
    {
        result[0] = (result[0] * result[0]);
    }
}
