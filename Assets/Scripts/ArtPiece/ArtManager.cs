using Ebac.Core.Singleton;
using System.Collections.Generic;
using UnityEngine;

public class ArtManager : Singleton<ArtManager>
{
    public enum ArtType
    {
        TYPE_01,
        TYPE_02,
        BEACH,
        SNOW
    }

    public List<ArtSetup> artSetups;

    public ArtSetup GetSetupByType(ArtType artType)
    {
        var setup = artSetups.Find(i => i.artType == artType);

        if (setup == null)
        {
            Debug.LogError("ArtSetup não encontrado para: " + artType);
        }

        return setup;
    }
}

[System.Serializable]
public class ArtSetup
{
    public ArtManager.ArtType artType;
    public GameObject gameObject;
}
