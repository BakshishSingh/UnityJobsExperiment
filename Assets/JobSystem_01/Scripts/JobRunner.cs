using Unity.Collections;
using UnityEngine;
using Unity.Jobs;

public class JobRunner : MonoBehaviour
{

    NativeArray<float> result;

    SampleJob1 sampleJob;
    SampleJob2 areaJob;
    // Start is called before the first frame update
    void Awake()
    {
        result = new NativeArray<float>(1, Allocator.TempJob);
        sampleJob = new SampleJob1();
        sampleJob.center = 20;
        sampleJob.pointOnCircle = 8;
        sampleJob.radius = result;
        JobHandle sampleJobHandle = sampleJob.Schedule();

        areaJob = new SampleJob2();
        areaJob.result = result;
        JobHandle areaJobHandle = areaJob.Schedule(sampleJobHandle);
        areaJobHandle.Complete();

        Debug.Log("Area " + result[0]);
        result.Dispose();
    }

    // Update is called once per frame
    void Update()
    {



    }
}
