using UnityEngine;
[System.Serializable] 
public class TSTStateInfo : FSMStateInfo
{
    public bool CanSeeTarget;
    public bool CanHearTarget;
    public Vector3 LastPlayerPosition;
    public Vector3 LastPlayerVelocity;
    public float LastPlayerPerceivedTime;
    public bool CloseToTarget;
    public float PcentLife;
    public IG1EnemyController Controller;
}