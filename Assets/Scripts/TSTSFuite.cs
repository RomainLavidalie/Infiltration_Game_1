using UnityEngine;

public class TSTSFuite : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        Debug.Log("Je m'enfuie !");
    }
}