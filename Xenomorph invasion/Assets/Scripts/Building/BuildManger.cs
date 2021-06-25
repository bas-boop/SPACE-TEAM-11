using UnityEngine;

public class BuildManger : MonoBehaviour
{
    public static BuildManger instance;

    void Awake ()
    {
        if(instance != null)
        {
            Debug.LogError("Meer dan 1 BuildManger in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }


    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }



    public void Update()
    {
        GetComponent<ToggleBuildOff>().codeIsOn = true;
    }
}
