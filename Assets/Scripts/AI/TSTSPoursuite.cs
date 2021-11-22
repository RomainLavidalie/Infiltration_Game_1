using UnityEngine;

public class TSTSPoursuite : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        //infos.Controller.Attack(infos.LastPlayerPosition);
        infos.Controller.FindPathTo(infos.LastPlayerPosition);
    }
}