using Unity.Jobs;
using Unity.Collections;

public struct SampleJob1 : IJob
{

    public float center;
    public float pointOnCircle;
    public NativeArray<float> radius;

    public void Execute()
    {
        radius[0] = center - pointOnCircle;
    }
}
