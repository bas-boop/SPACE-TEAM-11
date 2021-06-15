using UnityEngine;

public class BuildManger : MonoBehaviour
{
    public static BuildManger instance;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild ()
    {
        return turretToBuild;
    }
}
