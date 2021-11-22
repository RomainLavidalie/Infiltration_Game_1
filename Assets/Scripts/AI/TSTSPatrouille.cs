using UnityEngine;

public class TSTSPatrouille : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        Debug.Log("Je fais ma petite patrouille...");
    }
}